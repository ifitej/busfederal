using BF.Borde.Models.Services.Documentos;

namespace BF.Ejemplos.EjemplosDocumentos
{
    public class TraerDocumento : Ejemplo
    {
        public override void Execute()
        {
            var rs = this.Client.Documento.Traer(new DocumentoTraerRequest
            {
                Uuid = "............"
            });

            Log(rs.Status);
            Log(rs.Message);

            if (rs.Status)
            {
                Log($"PayloadBase64: {rs.Data?.Documento?.PayloadBase64}");
            }
        }
    }
}
