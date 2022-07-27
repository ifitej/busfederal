namespace BF.ApiClientHelper
{
	/// <summary>
	/// Objeto de configuracion del servicio
	/// </summary>
	public class Settings
	{
		/// <summary>
		/// Url del servico a utilizar
		/// </summary>
		public string ServiceUrl { get; set; }

		/// <summary>
		/// ClientID para obtener token de autenticacion
		/// </summary>
		public string ClientID { get; set; }

		/// <summary>
		/// SecretClient para obtener token de autenticacion
		/// </summary>
		public string SecretClient { get; set; }

		/// <summary>
		/// Token de autenticacion que se desea utilizar. Cunado se especifica un token se ignoran los datos de ClientID y SercretClient
		/// </summary>
		public string AuthenticationToken { get; set; }

		/// <summary>
		/// Url del servidor de Autorizacion. Si no se indica ninguno se utiliza el 
		/// metodo <see cref="Settings.AuthorityMethod"/> del servicio <see cref="Settings.ServiceUrl"/> para obtenerlo.
		/// </summary>
		public string AuthorityServerUrl { get; set; }

		/// <summary>
		/// Metodo del servicio <see cref="Settings.ServiceUrl"/> que devuelve la url <see cref="Settings.AuthorityServerUrl"/>
		/// </summary>
		public string AuthorityMethod { get; set; }
	}
}
