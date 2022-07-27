using System;

namespace BF.Borde.ApiClient
{
	public class BordeException : ApplicationException
	{
		public BordeException() { }
		public BordeException(string message) : base(message) { }
	}
}
