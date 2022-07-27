using BF.ApiClientHelper;
using BF.Borde.Models.Services.Documentos;
using BF.Common;
using Microsoft.Extensions.Logging;
using System;

namespace BF.Borde.ApiClient.Modules
{
	/// <inheritdoc />
	public class DocumentoModule : ModuleBase
	{
		/// <inheritdoc />
		public DocumentoModule(string baseUrl, ApiHelper api, ILogger logger) : base(baseUrl, api, logger)
		{ 
		}

		/// <summary>
		/// Envia un documento
		/// </summary>
		/// <param name="rq">Datos a enviar</param>
		/// <returns>Codigo de operacion. Éste código será utilizado para recuperar el ticket correspondiente a ésta operación</returns>
		public ServiceResponse<DocumentoEnviarResponse> Enviar(Models.ApiModel.DocumentoEnviarRequest rq)
		{
			if (rq.Documento != null && string.IsNullOrEmpty(rq.Documento.SHA256Payload))
				rq.Documento.SHA256Payload = Utils.SHA256.ComputeHash(rq.Documento.PayloadBase64);

			if (rq.Data != null && !string.IsNullOrEmpty(rq.Data.DataBase64) && string.IsNullOrEmpty(rq.Data.SHA256Data))
				rq.Data.SHA256Data = Utils.SHA256.ComputeHash(rq.Data.DataBase64);

			return this.Api.Post<DocumentoEnviarResponse>(this.Url("enviar"), rq);
		}

		/// <summary>
		/// Envía un documento con un objeto de metadata. La metadata puede ser utilizada para enviar datos que puedan ser interpretados por el destinatario
		/// </summary>
		/// <typeparam name="T">Tipo del objeto de metadata que se desea enviar</typeparam>
		/// <param name="rq">Datos a enviar</param>
		/// <returns>Codigo de operacion. Éste código será utilizado para recuperar el ticket correspondiente a ésta operación</returns>
		public ServiceResponse<DocumentoEnviarResponse> EnviarConJsonMetadata<T>(Models.ApiModel.DocumentoEnviarRequest<T> rq)
		{
			var rqEnviar = new Models.ApiModel.DocumentoEnviarRequest(rq)
			{
				Data = new Models.Shared.Dtos.MetadataDto()
			};

			if (rq.Data != null)
				rqEnviar.Data.DataBase64 = Utils.ObjectUtils.ObjectToJsonBase64(rq.Data);

			return Enviar(rqEnviar);
		}

		/// <summary>
		/// Trae un documento
		/// </summary>
		/// <param name="rq">Identificador de la operacion de envio del documento</param>
		/// <returns>Documento encontrado</returns>
		public ServiceResponse<DocumentoTraerResponse> Traer(DocumentoTraerRequest rq)
		{
			return this.Api.Get<DocumentoTraerResponse>(this.Url("documento/"), rq);
		}

		/// <summary>
		/// Trae solo el contenido binario del documento
		/// </summary>
		/// <param name="rq">Identificador de la operacion de envio del documento</param>
		/// <returns>Contenido en Base64</returns>
		public ServiceResponse<byte[]> ContenidoBinario(DocumentoTraerRequest rq)
		{
			return this.Api.Get<byte[]>(this.Url("documento/binario"), rq);
		}


		/// <summary>
		/// Trae solo el contenido en Base64 del campo data
		/// </summary>
		/// <param name="rq">Identificador de la operacion de envio del documento</param>
		/// <returns>Contenido en Base64</returns>
		public ServiceResponse<string> ContenidoData(DocumentoTraerRequest rq)
		{
			return this.Api.Get<string>(this.Url("documento/data"), rq);
		}

		/// <summary>
		/// Crea un link para acceder al documento. Éste link tiene un período de expiración de 2 minutos.
		/// </summary>
		/// <param name="rq">Identificador de la operacion de envio del documento</param>
		/// <returns>Link para acceder al documento</returns>
		public ServiceResponse<string> Link(DocumentoTraerRequest rq)
		{
			return this.Api.Get<string>(this.Url("documento/link"), rq);
		}

		/// <summary>
		/// Trae un documento con metadata
		/// </summary>
		/// <param name="rq">Identificador de la operacion de envio del documento</param>
		/// <returns>Documento encontrado junto al objeto deserializado de metadata</returns>
		public ServiceResponse<DocumentoTraerResponse<T>> Traer<T>(DocumentoTraerRequest rq)
		{
			var srTraer = Traer(rq);
			var sr = new ServiceResponse<DocumentoTraerResponse<T>>().Attach(srTraer);

			if (srTraer.Status && srTraer.Data?.Data != null)
			{
				sr.Data = new DocumentoTraerResponse<T>(srTraer.Data);

				var data = srTraer.Data.Data;

				if (!string.IsNullOrEmpty(data.DataBase64))
					sr.Data.Data = Utils.ObjectUtils.JsonBase64ToObject<T>(data.DataBase64);
			}

			return sr;
		}
	}
}
