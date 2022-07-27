using BF.ApiClientHelper;
using BF.Borde.Models.Services.Organismos;
using BF.Common;
using Microsoft.Extensions.Logging;

namespace BF.Borde.ApiClient.Modules
{
	/// <inheritdoc />
	public class OrganismoModule : ModuleBase
	{
		/// <inheritdoc />
		public OrganismoModule(string baseUrl, ApiHelper api, ILogger logger) : base(baseUrl, api, logger)
		{ 
		}

		/// <summary>
		/// Busca organismos
		/// </summary>
		/// <param name="rq">Filtro de búsqueda</param>
		/// <returns>Lista de organismos encontrados</returns>
		public ServiceResponse<OrganismoBuscarResponse> Buscar(Models.ApiModel.OrganismoBuscarRequest rq)
		{
			return this.Api.Get<OrganismoBuscarResponse>(this.Url("organismos/"), rq);
		}

		/// <summary>
		/// Lanza el proceso de sincronización de organismos. 
		/// </summary>
		/// <returns></returns>
		public ServiceResponse<OrganismoBuscarResponse> Sincronizar()
		{
			return Sincronizar(new OrganismoSincronizarRequest { });
		}

		/// <summary>
		/// Lanza el proceso de sincronización de un organismo
		/// </summary>
		/// <param name="rq">Identificador del organismo que se desea sincronizar</param>
		/// <returns></returns>
		public ServiceResponse<OrganismoBuscarResponse> Sincronizar(OrganismoSincronizarRequest rq)
		{
			return this.Api.Post<OrganismoBuscarResponse>(this.Url("organismos/sincronizar"), rq);
		}
	}
}
