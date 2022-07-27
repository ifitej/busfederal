using System;
using System.Net.Http;

namespace BF.Borde.ApiClient
{
	public class ConfigureEventArg : EventArgs
	{
		public HttpClient HttpClient { get; private set; }

		public ConfigureEventArg(HttpClient httpClient)
		{
			this.HttpClient = httpClient;

		}
	}
}
