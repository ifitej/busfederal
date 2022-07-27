using System;
using System.IO;
using System.Reflection;

namespace BF.Ejemplos.Resources
{
    public class ResourcesHelper
	{
		private const string Pdf01 = "test-01";

		public static byte[] GetPdf(string pdfName)
		{
			var assembly = Assembly.GetExecutingAssembly();
			var resourceName = $"BF.Ejemplos.Resources.{pdfName}.pdf";

			using (var stream = assembly.GetManifestResourceStream(resourceName))
			{
				if (stream == null)
					throw new ApplicationException("No se encontro el PDF");

				using (var reader = new BinaryReader(stream))
					return reader.ReadBytes(Convert.ToInt32(reader.BaseStream.Length));
			}
		}

		public static byte[] GetPdf()
		{
			return GetPdf(Pdf01);
		}

		public static string GetPdfBase64()
		{
			var pdf = GetPdf();

			return Convert.ToBase64String(pdf);
		}
	}
}
