using BF.Common;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BF.Borde.ApiClient
{
	public class ApiHelper
	{
		public HttpClient HttpClient { get; set; }
		private BordeClientSettings _settings;
		private string _authorityServer;
		private ILogger _logger;
		private OpenIDConnectClient.OpenIDClient _openIDClient;


		public ApiHelper(BordeClientSettings settings, ILogger logger)
		{
			_settings = settings;
			_logger = logger;
		}

		public void Configure()
		{
			this.HttpClient = new HttpClient();
		}

		public ServiceResponse Login()
		{
			var sr = new ServiceResponse();

			var srToken = GetToken();

			sr.Attach(srToken);

			return sr;
		}

		public ServiceResponse<List<Claim>> GetLoggedUser()
		{
			var sr = new ServiceResponse<List<Claim>>();

			var srOpenID = GetOpenIDClient();

			if (!sr.Attach(srOpenID).Status)
				return sr;

			var srUser = srOpenID.Data.GetLoggedUser();

			if (!sr.Attach(srUser).Status)
				return sr;

			sr.Data = srUser.Data.Claims.ToList();

			return sr;
		}

		public ServiceResponse<T> Get<T>(string url)
		{
			return Get<T>(url, null);
		}

		public ServiceResponse<T> Get<T>(string url, object model)
		{
			return Get<T>(url, model, true);
		}

		public ServiceResponse<T> Get<T>(string url, object model, bool withToken)
		{
			var query = new System.Collections.Specialized.NameValueCollection();

			if (model != null)
			{
				var properties = model.GetType().GetProperties();

				foreach (var p in properties)
				{
					if (!p.CanRead)
						continue;

					var name = p.Name;

					if (p.CustomAttributes != null)
					{
						var attributes = p.GetCustomAttributes(true);
						foreach (var att in attributes)
						{
							if (att is System.Text.Json.Serialization.JsonPropertyNameAttribute)
							{
								var jsonAtt = (System.Text.Json.Serialization.JsonPropertyNameAttribute)att;

								name = jsonAtt.Name;
							}
							if (att is Microsoft.AspNetCore.Mvc.BindPropertyAttribute)
							{
								var bindAtt = (Microsoft.AspNetCore.Mvc.BindPropertyAttribute)att;

								name = bindAtt.Name;
							}

							if (att is Newtonsoft.Json.JsonPropertyAttribute)
							{
								var jsonAtt = (Newtonsoft.Json.JsonPropertyAttribute)att;

								name = jsonAtt.PropertyName;
							}

						}
					}

					var val = p.GetValue(model);
					var strVal = val?.ToString();

					if (val != null)
					{
						var dateFormat = "yyyy-MM-ddTHH:mm:ss";

						if (val is DateTime)
							strVal = ((DateTime)val).ToString(dateFormat);

						if (val is DateTime?)
							strVal = ((DateTime?)val).Value.ToString(dateFormat);
					}

					query[name] = strVal;
				}

				if (query.Count > 0)
				{
					url += "?";

					foreach (var q in query.AllKeys)
					{
						url += $"{q}={HttpUtility.UrlEncode(query[q])}&";
					}
				}
			}

			return Api<T>(url, HttpMethod.Get, null, withToken);
		}

		public ServiceResponse<T> Put<T>(string url, object model)
		{
			return Api<T>(url, HttpMethod.Put, model);
		}

		public ServiceResponse<T> Post<T>(string url, object model)
		{
			return Api<T>(url, HttpMethod.Post, model);
		}

		public ServiceResponse<T> Delete<T>(string url, object model)
		{
			return Api<T>(url, HttpMethod.Delete, model);
		}

		private ServiceResponse<T> Api<T>(string url, HttpMethod method, object model, bool withToken = true)
		{
			var request = new HttpRequestMessage(method, url);

			if (model != null)
				request.Content = new StringContent(Utils.ObjectUtils.ObjetToJson(model), Encoding.UTF8, "application/json");

			HttpClient.DefaultRequestHeaders.Remove("Authorization");

			if (withToken)
			{
				var sr = new ServiceResponse<T>();

				var srToken = GetToken();

				if (!sr.Attach(srToken).Status)
					return sr;

				if (srToken.Status)
					HttpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + srToken.Data);
			}

			return ApiCall<T>(request);
		}

		private ServiceResponse<string> GetToken()
		{
			var sr = new ServiceResponse<string>();

			var srOpenID = GetOpenIDClient();

			if (!sr.Attach(srOpenID).Status)
				return sr;

			var openID = srOpenID.Data;

			var srToken = openID.GetToken();

			if (!sr.Attach(srToken).Status)
				return sr;

			sr.Data = srToken.Data.AccessToken;

			return sr;
		}

		private ServiceResponse<string> GetAuthorityServer()
		{
			var sr = new ServiceResponse<string>();

			if (string.IsNullOrEmpty(_authorityServer))
			{
				var srGet = this.Get<string>(_settings.ServiceUrl + "api/GetAuthorityUrl", null, false);

				if (!sr.Attach(srGet).Status)
					return sr;

				_authorityServer = srGet.Data;
			}

			sr.Data = _authorityServer;

			return sr;
		}


		private	ServiceResponse<OpenIDConnectClient.OpenIDClient> GetOpenIDClient()
		{
			var sr = new ServiceResponse<OpenIDConnectClient.OpenIDClient>();

			if (_openIDClient == null)
			{
				var srAuthority = GetAuthorityServer();

				if (!sr.Attach(srAuthority).Status)
					return sr;

				_openIDClient = new OpenIDConnectClient.OpenIDClient(_authorityServer, _settings.ClientID, _settings.SecretClient);
	 		}

			sr.Data = _openIDClient;

			return sr;
		}

		private ServiceResponse<T> ApiCall<T>(HttpRequestMessage rq)
		{
			try
			{

				var task = HttpClient.SendAsync(rq);

				task.Wait();

				HttpResponseMessage httpResponse = task.Result as HttpResponseMessage;

				if (httpResponse.IsSuccessStatusCode)
				{
					// Read response
					Task<string> taskRead = httpResponse.Content.ReadAsStringAsync();

					// Wait for the task to complete
					taskRead.Wait();

					return Utils.ObjectUtils.JsonToObject<ServiceResponse<T>>(taskRead.Result);
				}
				else
				{
					Task<string> taskRead = httpResponse.Content.ReadAsStringAsync();

					// Wait for the task to complete
					taskRead.Wait();

					var result = taskRead.Result;

					_logger.LogError($"Error ApiCall: {rq.RequestUri.ToString()}. {httpResponse.StatusCode} {result}");

					return new ServiceResponse<T>
					{
						Status = false,
						Message = $"[{httpResponse.StatusCode}] {httpResponse.ReasonPhrase}. {result}"
					};
				}
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, $"Error ApiCall: {rq.RequestUri}");

				return new ServiceResponse<T>
				{
					Status = false,
					Message = ex.Message,
					Exception = ex
				};
			}
		}

		public string Get(string url)
		{
			return HttpClient.GetStringAsync(url).Result;
		}
	}
}
