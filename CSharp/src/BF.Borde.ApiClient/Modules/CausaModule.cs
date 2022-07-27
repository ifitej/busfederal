using BF.ApiClientHelper;
using BF.Borde.Models.Services.Causas;
using BF.Common;
using Microsoft.Extensions.Logging;

namespace BF.Borde.ApiClient.Modules
{
	/// <inheritdoc />
	public class CausaModule : ModuleBase
	{	
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="baseUrl">Url del servicio de borde</param>
		/// <param name="api">Objecto con el que se realizan las llamadas a la api</param>
		/// <param name="logger">Logger</param>
		public CausaModule(string baseUrl, ApiHelper api, ILogger logger) : base(baseUrl, api, logger)
		{ 
		}

		/// <summary>
		/// Busqueda de causas por numero
		/// </summary>
		/// <param name="rq">Filtro de busqueda</param>
		/// <returns>Causas encontradas</returns>
		public ServiceResponse<BuscarCausaResponse> BuscarPorNumero(BuscarCausaPorNumeroRequest rq)
		{
			return this.Api.Get<BuscarCausaResponse>(this.Url("api/get_causa_numero"), rq);
		}

		/// <summary>
		/// Busqueda de causas por caratula
		/// </summary>
		/// <param name="rq">Filtro de busqueda</param>
		/// <returns>Causas encontradas</returns>
		public ServiceResponse<BuscarCausaResponse> BuscarPorCaratula(BuscarCausaPorCaratulaRequest rq)
		{
			return this.Api.Get<BuscarCausaResponse>(this.Url("api/get_causa_caratula"), rq);
		}
	}
}
