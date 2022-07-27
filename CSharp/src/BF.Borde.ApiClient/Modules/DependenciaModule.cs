using BF.ApiClientHelper;
using BF.Borde.Models.Services.Dependencias;
using BF.Common;
using Microsoft.Extensions.Logging;

namespace BF.Borde.ApiClient.Modules
{
	/// <inheritdoc />
	public class DependenciaModule : ModuleBase
	{
		private string _urlBase = "dependencias";

		/// <inheritdoc />
		public DependenciaModule(string baseUrl, ApiHelper api, ILogger logger) : base(baseUrl, api, logger)
		{ 
		}

		/// <summary>
		/// Busqueda de dependencias
		/// </summary>
		/// <param name="rq">Filtros de busqueda</param>
		/// <returns>Lista de dependencias encontradas</returns>
		public ServiceResponse<DependenciaBuscarResponse> Buscar(Models.ApiModel.DependenciaBuscarRequest rq)
		{
			return this.Api.Get<DependenciaBuscarResponse>(this.Url(_urlBase), rq);
		}

		/// <summary>
		/// Creación o modificación de depdendencias. Si se envía una dependencia inexistente la crea, caso contrario modifica sus attributos.
		/// </summary>
		/// <param name="rq">Nuevos valores de la dependencia</param>
		/// <returns>Codigo de dependencia guardado</returns>
		public ServiceResponse<DependenciaGuardarResponse> Guardar(Models.ApiModel.DependenciaGuardarRequest rq)
		{
			return this.Api.Put<DependenciaGuardarResponse>(this.Url(_urlBase), rq);
		}

		/// <summary>
		/// Elimina una dependencia existente
		/// </summary>
		/// <param name="rq">Identificador de la dependencia que se desea eliminar</param>
		/// <returns>Codigo de dependencia eliminada</returns>
		public ServiceResponse<DependenciaEliminarResponse> Eliminar(Models.ApiModel.DependenciaEliminarRequest rq)
		{
			return this.Api.Delete<DependenciaEliminarResponse>(this.Url(_urlBase), rq);
		}
	}
}
