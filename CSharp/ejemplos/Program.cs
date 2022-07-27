using BF.Borde.ApiClient;

namespace BF.Ejemplos
{
	class Program
	{
		public const string CLIENT_ID = "servicio-test-integracion";
		public const string SECRET_CLIENT = "740af6c9-de2a-4f2e-9abd-d2c103270db2";
		public const string SERVICE_URL = "https://servicio-de-borde.bus-justicia.org.ar";

		static void Main(string[] args)
		{
			var client = new BordeClient(new BordeClientSettings
			{
				ClientID = CLIENT_ID,
				SecretClient = SECRET_CLIENT, 
				ServiceUrl = SERVICE_URL				
			});

			//var ejemplo = new EjemplosDependencias.GuardarDependencia();
			//var ejemplo = new EjemplosDependencias.BuscarDependencia();
			//var ejemplo = new EjemplosDependencias.EliminarDependencia();
			//var ejemplo = new EjemplosOrganismos.BuscarDependencia();
			var ejemplo = new EjemplosDocumentos.EnviarDocumento();
			//var ejemplo = new EjemplosDocumentos.EnviarDocumentoConData();
			//var ejemplo = new EjemplosDocumentos.TraerDocumento();
			//var ejemplo = new EjemplosDocumentos.TraerDocumentoConData();


			ejemplo.Client = client;
			ejemplo.Execute();					
		}
	}
}
