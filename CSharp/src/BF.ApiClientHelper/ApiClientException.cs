using System;

namespace BF.ApiClientHelper
{
	/// <summary>
	/// 
	/// </summary>
	public class ApiClientException : ApplicationException
	{
		/// <summary>
		/// 
		/// </summary>
		public ApiClientException() { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public ApiClientException(string message) : base(message) { }
	}
}
