using BF.ApiClientHelper;
using BF.Borde.ApiClient.Modules;
using Microsoft.Extensions.Logging;

namespace BF.Borde.ApiClient
{
	/// <inheritdoc />
	public class BordeClient : BFClientBase
	{
		/// <summary>
		/// </summary>
		public StatusModule Status { get; private set; }

		/// <summary>
		/// </summary>
		public CausaModule Causa { get; private set; }

		/// <summary>
		/// </summary>
		public DependenciaModule Dependencia { get; private set; }

		/// <summary>
		/// </summary>
		public TicketModule Ticket { get; private set; }

		/// <summary>
		/// </summary>
		public DocumentoModule Documento { get; private set; }

		/// <summary>
		/// </summary>
		public OrganismoModule Organismo { get; private set; }


		/// <summary>
		/// Cliente para realizar llamadas a los metodos del servicio de borde
		/// </summary>
		/// <param name="settings">Objeto de configuración del servicio</param>
		public BordeClient(BordeClientSettings settings) : base(settings) {}

		/// <summary>
		/// Cliente para realizar llamadas a los metodos del servicio de borde
		/// </summary>
		/// <param name="settings">Objeto de configuración del servicio</param>
		/// <param name="logger">Objeto para loguear actividad del componente</param>
		public BordeClient(BordeClientSettings settings, ILogger logger) : base (settings, logger) { }

		/// <summary>
		/// Creación de modulos ser servicio
		/// </summary>
		/// <param name="settings">Objeto de configuración del servicio</param>
		/// <param name="api"></param>
		/// <param name="logger">Objeto para loguear actividad del componente</param>
		protected override void CreateModules(Settings settings, ApiHelper api, ILogger logger)
		{
			this.Status = new StatusModule(settings.ServiceUrl, api, logger);
			this.Causa = new CausaModule(settings.ServiceUrl, api, logger);
			this.Dependencia = new DependenciaModule(settings.ServiceUrl, api, logger);
			this.Ticket = new TicketModule(settings.ServiceUrl, api, logger);
			this.Documento = new DocumentoModule(settings.ServiceUrl, api, logger);
			this.Organismo = new OrganismoModule(settings.ServiceUrl, api, logger);
		}
	}
}
