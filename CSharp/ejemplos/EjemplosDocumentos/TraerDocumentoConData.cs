using BF.Borde.Models.Services.Documentos;

namespace BF.Ejemplos.EjemplosDocumentos
{
    public class TraerDocumentoConData : Ejemplo
    {
        public override void Execute()
        {
            var rs = this.Client.Documento.Traer<DemoMetadata>(new DocumentoTraerRequest
            {
                Uuid = "............"
            });

            Log(rs.Status);
            Log(rs.Message);

            if (rs.Status)
            {
                Log($"PayloadBase64: {rs.Data?.Documento?.PayloadBase64}");

                Log($"Metadata: {rs.Data?.Data.Numero}");
            }
        }
    }
}
