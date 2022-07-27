using BF.Common;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;

namespace BF.ApiClientHelper
{
	/// <summary>
	/// Wrapper para las llamadas al Servicio de Borde
	/// </summary>
	public class BFClientBase
	{
		/// <summary>
		/// Nombre del claims para devolver el código de organismo del usuario
		/// </summary>
		public static string CodigoOrganismoClaimName { get; set; } = "codigo_organismo";

		private Settings _settings;
		private ApiHelper _api;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public delegate void ConfigureEventHandler(object sender, ConfigureEventArg e);
		/// <summary>
		/// 
		/// </summary>
		public event ConfigureEventHandler OnConfigure;

		/// <summary>
		/// Helper para las llamadas a la api
		/// </summary>
		public ApiHelper Api => _api;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="settings">Objeto de configuración</param>
		public BFClientBase(Settings settings) : this(settings, null)
		{
		}

		/// <summary>
		/// Constructor 
		/// </summary>
		/// <param name="settings">Objeto de configuración</param>
		/// <param name="logger">Objeto sobre el cual se loguea la actividad del componente</param>
		public BFClientBase(Settings settings, ILogger logger)
		{
			_settings = settings;

			NormalizeSettings();

			if (logger == null)
				logger = this.CreateDefaultLogger();

			logger.LogDebug("Iniciando modulos de api");

			_api = new ApiHelper(settings, logger);

			this.CreateModules(_settings, _api, logger);

			logger.LogDebug("Configurando api");
			_api.Configure();

			OnConfigureEvent();
		}

		/// <summary>
		/// Login
		/// </summary>
		public void Login()
		{
			_api.Login();
		}

		/// <summary>
		/// Crea un modulo
		/// </summary>
		/// <param name="settings"></param>
		/// <param name="api"></param>
		/// <param name="logger"></param>
		protected virtual void CreateModules(Settings settings, ApiHelper api, ILogger logger)
		{ 
		}

		private ILogger CreateDefaultLogger()
		{
			var loggerFactory = LoggerFactory.Create(builder =>
			{
				builder.AddSimpleConsole(options =>
				{
					options.IncludeScopes = true;
					options.SingleLine = true;
					options.TimestampFormat = "hh:mm:ss ";
				});
			});

			return loggerFactory.CreateLogger(this.GetType());
		}


		private void OnConfigureEvent()
		{
			if (this.OnConfigure != null)
				this.OnConfigure(this, new ConfigureEventArg(_api.HttpClient));
		}

		private void NormalizeSettings()
		{
			if (string.IsNullOrEmpty(_settings.ServiceUrl))
				throw new ApiClientException("Configuracion Inválida. ServiceUrl sin definir");

			_settings.ServiceUrl = _settings.ServiceUrl.TrimEnd('/') + "/";
		}

		/// <summary>
		/// Devuelve el usuario logueado
		/// </summary>
		/// <returns>Usuario logueado</returns>
		public ServiceResponse<List<Claim>> GetLoggedUser()
		{
			return _api.GetLoggedUser();
		}

		/// <summary>
		/// Devuleve el token de autentiación
		/// </summary>
		/// <returns></returns>
		public ServiceResponse<string> GetToken()
		{
			return _api.GetToken();
		}

		/// <summary>
		/// Devuelve el código de organismo del usuario logueado
		/// </summary>
		/// <returns>Codigo de organismo</returns>
		public ServiceResponse<string> GetCodigoOrganismo()
		{
			var sr = new ServiceResponse<string>();
			var srUser = GetLoggedUser();

			if (!sr.Attach(srUser).Status)
				return sr;

			var claim = srUser.Data.FirstOrDefault(x => x.Type == CodigoOrganismoClaimName);

			if (claim == null)
				return sr.AddError($"No se encontro el claims \"{CodigoOrganismoClaimName}\" para obtener el codigo de organismo");

			sr.Data = claim.Value;

			return sr;
		}

		/// <summary>
		/// Setea el objeto http que se utilizará en la llamada a la api
		/// </summary>
		/// <param name="httpClient"></param>
		public void SetHttpClient(HttpClient httpClient)
		{
			_api.HttpClient = httpClient;
		}
	}
}