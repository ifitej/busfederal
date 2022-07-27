using Microsoft.Extensions.Logging;

namespace BF.ApiClientHelper
{
	/// <summary>
	/// Modulo para el llamado de las operaciones
	/// </summary>
	public class ModuleBase
	{
		/// <summary>
		/// Helper para las llamadas a la api
		/// </summary>
		protected ApiHelper Api { get; private set; }
		/// <summary>
		/// Objeto sobre el cual se realiza el log de la actividad del componente
		/// </summary>
		protected ILogger Logger { get; private set; }
		/// <summary>
		/// Url del Servicio de Borde
		/// </summary>
		protected string BaseUrl { get; private set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="baseUrl">Url del servicio de borde</param>
		/// <param name="api">Objecto con el que se realizan las llamadas a la api</param>
		/// <param name="logger">Logger</param>
		public ModuleBase(string baseUrl, ApiHelper api, ILogger logger)
		{
			this.Api = api;
			this.Logger = logger;
			this.BaseUrl = baseUrl;
		}

		/// <summary>
		/// Devuelve la url completa
		/// </summary>
		/// <param name="method">Método de la api del cual se desea armar la url completa</param>
		/// <returns></returns>
		public string Url(string method)
		{
			return BaseUrl + method;
		}
	}
}
