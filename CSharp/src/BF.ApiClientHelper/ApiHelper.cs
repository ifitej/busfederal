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

namespace BF.ApiClientHelper
{
	/// <summary>
	/// Helper para el llamado de metodos de una api
	/// </summary>
	public class ApiHelper
	{
		/// <summary>
		/// Objeto HttpClient para realizar los llamados a la api
		/// </summary>
		public HttpClient HttpClient { get; set; }
		private Settings _settings;
		private string _authorityServer;
		private ILogger _logger;
		private OpenIDConnectClient.OpenIDClient _openIDClient;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="settings"></param>
		/// <param name="logger"></param>
		public ApiHelper(Settings settings, ILogger logger)
		{
			_settings = settings;
			_logger = logger;

			this.HttpClient = new HttpClient();
		}

		/// <summary>
		/// Configura el cliente
		/// </summary>
		public void Configure()
		{
			
		}

		/// <summary>
		/// Realiza el login para obtener token de autenticación
		/// </summary>
		/// <returns></returns>
		public ServiceResponse Login()
		{
			var sr = new ServiceResponse();

			var srToken = GetToken();

			sr.Attach(srToken);

			return sr;
		}

		/// <summary>
		/// Devuelve el usuario actual
		/// </summary>
		/// <returns>Lista de claims del usuario logueado</returns>
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

		
		/// <summary>
		/// Realizar una llamada a la api con metodo "GET"
		/// </summary>
		/// <typeparam name="T">Tipo de dato del objeto que se devolverá</typeparam>
		/// <param name="url">Url donde se realizará la llamada</param>
		/// <returns>Respuesta de la api</returns>
		public ServiceResponse<T> Get<T>(string url)
		{
			return Get<T>(url, null);
		}

		/// <summary>
		/// Realizar una llamada a la api con metodo "GET"
		/// </summary>
		/// <typeparam name="T">Tipo de dato del objeto que se devolverá</typeparam>
		/// <param name="url">Url donde se realizará la llamada</param>
		/// <param name="model">Objeto que se enviará</param>
		/// <returns>Respuesta de la api</returns>
		public ServiceResponse<T> Get<T>(string url, object model)
		{
			return Get<T>(url, model, true);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="url"></param>
		/// <returns></returns>
		public ServiceResponse<T> GetServiceResponse<T>(string url)
		{
			return GetServiceResponse<T>(url, null, true);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="url"></param>
		/// <param name="model"></param>
		/// <returns></returns>
		public ServiceResponse<T> GetServiceResponse<T>(string url, object model)
		{
			return GetServiceResponse<T>(url, model, true);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="url"></param>
		/// <param name="model"></param>
		/// <param name="withToken"></param>
		/// <returns></returns>
		public ServiceResponse<T> GetServiceResponse<T>(string url, object model, bool withToken)
		{
			url = GetUrlWithQueryString(url, model);

			return ApiServiceResponse<T>(url, HttpMethod.Get, null, withToken);
		}

		/// <summary>
		/// Realizar una llamada a la api con metodo "GET"
		/// </summary>
		/// <typeparam name="T">Tipo de dato del objeto que se devolverá</typeparam>
		/// <param name="url">Url donde se realizará la llamada</param>
		/// <param name="model">Objeto que se enviará</param>
		/// <param name="withToken">True para que se envíe token de autenticación</param>
		/// <returns>Respuesta de la api</returns>
		public ServiceResponse<T> Get<T>(string url, object model, bool withToken)
		{
			url = GetUrlWithQueryString(url, model);

			return Api<T>(url, HttpMethod.Get, null, withToken);
		}

		/// <summary>
		/// Realizar una llamada a la api con metodo "PUT"
		/// </summary>
		/// <typeparam name="T">Tipo de dato del objeto que se devolverá</typeparam>
		/// <param name="url">Url donde se realizará la llamada</param>
		/// <param name="model">Objeto que se enviará</param>
		/// <returns>Respuesta de la api</returns>
		public ServiceResponse<T> Put<T>(string url, object model)
		{
			return Api<T>(url, HttpMethod.Put, model);
		}

		/// <summary>
		/// Realizar una llamada a la api con metodo "POST"
		/// </summary>
		/// <typeparam name="T">Tipo de dato del objeto que se devolverá</typeparam>
		/// <param name="url">Url donde se realizará la llamada</param>
		/// <param name="model">Objeto que se enviará</param>
		/// <returns>Respuesta de la api</returns>
		public ServiceResponse<T> Post<T>(string url, object model)
		{
			return Api<T>(url, HttpMethod.Post, model);
		}

		/// <summary>
		/// Realizar una llamada a la api con metodo "DELETE"
		/// </summary>
		/// <typeparam name="T">Tipo de dato del objeto que se devolverá</typeparam>
		/// <param name="url">Url donde se realizará la llamada</param>
		/// <param name="model">Objeto que se enviará</param>
		/// <returns>Respuesta de la api</returns>
		public ServiceResponse<T> Delete<T>(string url, object model)
		{
			return Api<T>(url, HttpMethod.Delete, model);
		}

		private string GetUrlWithQueryString(string url, object model)
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

			return url;
		}

		private ServiceResponse<T> Api<T>(string url, HttpMethod method, object model, bool withToken = true)
		{
			var sr = new ServiceResponse<T>();

			var srRequest = CreateRequest(url, method, model, withToken);

			if (!sr.Attach(srRequest).Status)
				return sr;

			return ApiCall<T>(srRequest.Data);
		}

		private ServiceResponse<T> ApiServiceResponse<T>(string url, HttpMethod method, object model, bool withToken = true)
		{
			var sr = new ServiceResponse<T>();

			var srRequest = CreateRequest(url, method, model, withToken);

			if (!sr.Attach(srRequest).Status)
				return sr;

			return ApiServiceResponseCall<T>(srRequest.Data);
		}

		private ServiceResponse<HttpRequestMessage> CreateRequest(string url, HttpMethod method, object model, bool withToken)
		{
			_logger.LogDebug($"Creando Request: {url}");
			var sr = new ServiceResponse<HttpRequestMessage>();

			var request = new HttpRequestMessage(method, url);

			if (model != null)
				request.Content = new StringContent(Utils.ObjectUtils.ObjetToJson(model), Encoding.UTF8, "application/json");

			HttpClient.DefaultRequestHeaders.Remove("Authorization");

			if (withToken)
			{
				var srToken = GetToken();

				if (!sr.Attach(srToken).Status)
					return sr;

				if (srToken.Status)
					HttpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + srToken.Data);
			}

			sr.Data = request;

			return sr;
		}

		/// <summary>
		/// Devuleve el token de autenticación
		/// </summary>
		/// <returns>Token</returns>
		public ServiceResponse<string> GetToken()
		{
			var sr = new ServiceResponse<string>();

			if (!string.IsNullOrEmpty(_settings.AuthenticationToken))
			{
				_logger.LogDebug($"... utilizando token definido en configuración");
				sr.Data = _settings.AuthenticationToken;
			}
			else
			{
				var srOpenID = GetOpenIDClient();

				if (!sr.Attach(srOpenID).Status)
				{
					_logger.LogDebug($"...... {srOpenID.Message}");
					return sr;
				}

				var openID = srOpenID.Data;

				var srToken = openID.GetToken();

				if (!sr.Attach(srToken).Status)
				{
					_logger.LogDebug($"...... {srToken.Message}");
					return sr;
				}

				sr.Data = srToken.Data.AccessToken;
			}

			return sr;
		}

		private ServiceResponse<string> GetAuthorityServer()
		{
			var sr = new ServiceResponse<string>();

			if (string.IsNullOrEmpty(_authorityServer))
			{
				if (!string.IsNullOrEmpty(_settings.AuthorityServerUrl))
				{
					// Se seteo la Autoridad por configuracion 
					_authorityServer = _settings.AuthorityServerUrl;
				}
				else
				{
					// Le pide al servicio la URL de la Autoridad

					if (string.IsNullOrEmpty(_settings.AuthorityMethod))
						sr.AddError("No se especificó una url (settings.AuthorityServerUrl) para obtener token de autorizacion. Debe indicar la url o metodo del servicio actual (settings.AuthorityMethod) para obtener dicha url");

					_settings.AuthorityMethod = _settings.AuthorityMethod.TrimStart('/');

					var srGet = this.Get<string>(_settings.ServiceUrl + _settings.AuthorityMethod, null, false);

					if (!sr.Attach(srGet).Status)
						return sr;

					_authorityServer = srGet.Data;
				}
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

				_openIDClient = new OpenIDConnectClient.OpenIDClient(_authorityServer, _settings.ClientID, _settings.SecretClient, _logger);
	 		}

			sr.Data = _openIDClient;

			return sr;
		}

		private ServiceResponse<T> ApiCall<T>(HttpRequestMessage rq)
		{
			try
			{
				_logger.LogError($"Call [{rq.Method}] {rq.RequestUri.ToString()}");

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

		private ServiceResponse<T> ApiServiceResponseCall<T>(HttpRequestMessage rq)
		{
			try
			{
				_logger.LogError($"Call [{rq.Method}] {rq.RequestUri.ToString()}");

				var task = HttpClient.SendAsync(rq);

				task.Wait();

				HttpResponseMessage httpResponse = task.Result as HttpResponseMessage;

				if (httpResponse.IsSuccessStatusCode)
				{
					// Read response
					Task<string> taskRead = httpResponse.Content.ReadAsStringAsync();

					// Wait for the task to complete
					taskRead.Wait();

					var result = Utils.ObjectUtils.JsonToObject<T>(taskRead.Result);

					return new ServiceResponse<T>
					{
						Data = result, 
						Status = true
					};
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="url"></param>
		/// <returns></returns>
		public string Get(string url)
		{
			return HttpClient.GetStringAsync(url).Result;
		}
	}
}
