using BF.ApiClientHelper;
using BF.Common;
using Microsoft.Extensions.Logging;

namespace BF.Borde.ApiClient.Modules
{
	/// <inheritdoc />
	public class StatusModule : ModuleBase
	{
		/// <inheritdoc />
		public StatusModule(string baseUrl, ApiHelper api, ILogger logger) : base(baseUrl, api, logger)
		{ 
		}

		/// <summary>
		/// Ping
		/// </summary>
		/// <returns>"Pong", si el servicio se encuentra vivo.</returns>
		public string Ping()
		{
			return this.Api.Get(Url("Status/Ping"));
		}

		/// <summary>
		/// Devuelve el estado del servicio
		/// </summary>
		/// <returns>Estado del servicio</returns>
		public string Status()
		{
			return this.Api.Get(Url("Status/Ready"));
		}

		/// <summary>
		/// Devuleve la url para realizar la autenticación.
		/// </summary>
		/// <returns>Url del servicio de autenticacion OpenID</returns>
		public ServiceResponse<string> GetAuthorityUrl() 
		{
			return this.Api.Get<string>(Url("Api/GetAuthorityUrl"));
		}
	}
}
