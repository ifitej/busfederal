using System;
using System.Net.Http;

namespace BF.ApiClientHelper
{
	/// <summary>
	/// 
	/// </summary>
	public class ConfigureEventArg : EventArgs
	{
		/// <summary>
		/// 
		/// </summary>
		public HttpClient HttpClient { get; private set; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="httpClient"></param>
		public ConfigureEventArg(HttpClient httpClient)
		{
			this.HttpClient = httpClient;

		}
	}
}
