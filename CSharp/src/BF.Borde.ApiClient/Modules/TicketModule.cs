using BF.ApiClientHelper;
using BF.Borde.Models.Services.Tickets;
using BF.Common;
using Microsoft.Extensions.Logging;

namespace BF.Borde.ApiClient.Modules
{
	/// <inheritdoc />
	public class TicketModule : ModuleBase
	{
		private string _urlBase = "ticket/";

		/// <inheritdoc />
		public TicketModule(string baseUrl, ApiHelper api, ILogger logger) : base(baseUrl, api, logger)
		{ 
		}

		/// <summary>
		/// Trae un ticket
		/// </summary>
		/// <param name="rq">Filtro de busqueda del ticket</param>
		/// <returns>Ticket encontrado</returns>
		public ServiceResponse<TicketTraerResponse> Traer(TicketTraerRequest rq)
		{
			return this.Api.Get<TicketTraerResponse>(this.Url(_urlBase), rq);
		}

		/// <summary>
		/// Trae un ticket con informacion de metadata
		/// </summary>
		/// <param name="rq">Filtro de busqueda del ticket</param>
		/// <returns>Ticket encontrado</returns>
		public ServiceResponse<TicketTraerResponse<T>> Traer<T>(TicketTraerRequest rq)
		{
			var srTraer = Traer(rq);
			var sr = new ServiceResponse<TicketTraerResponse<T>>().Attach(srTraer);

			if (srTraer.Status && srTraer.Data?.Data != null)
			{
				sr.Data = new TicketTraerResponse<T>(srTraer.Data);

				var data = srTraer.Data.Data;

				if (!string.IsNullOrEmpty(data.DataBase64))
					sr.Data.Data = Utils.ObjectUtils.JsonBase64ToObject<T>(data.DataBase64);
			}

			return sr;
		}

		/// <summary>
		/// Busqueda de tickets
		/// </summary>
		/// <param name="rq">Filtro de busqueda del ticket</param>
		/// <returns>Ticket encontrado</returns>
		public ServiceResponse<TicketBuscarResponse> Buscar(Models.ApiModel.TicketBuscarRequest rq)
		{
			return this.Api.Post<TicketBuscarResponse>(this.Url(_urlBase + "buscar"), rq);
		}

		/// <summary>
		/// Lista los tickets nuevos
		/// </summary>
		/// <returns>Tickets encontrado</returns>
		public ServiceResponse<TicketBuscarResponse> Nuevos()
		{
			return this.Api.Get<TicketBuscarResponse>(this.Url(_urlBase + "nuevos"));
		}
	}
}
