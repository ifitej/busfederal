namespace BF.Borde.ApiClient
{
	/// <inheritdoc />
	public class BordeClientSettings : ApiClientHelper.Settings
	{
		/// <inheritdoc />
		public BordeClientSettings()
		{
			this.AuthorityMethod = "api/GetAuthorityUrl";
		}
	}
}
