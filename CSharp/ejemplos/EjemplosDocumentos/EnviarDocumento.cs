using BF.Borde.Models.Services.Documentos;
using BF.Borde.Models.Shared.Dtos;
using BF.Ejemplos.Resources;

namespace BF.Ejemplos.EjemplosDocumentos
{
    public class EnviarDocumento : Ejemplo
    {
        public override void Execute()
        {
            var rs = this.Client.Documento.Enviar(new DocumentoEnviarRequest
            {
                DependenciaOrigen = new CausaDto 
                {
                    NumeroCausa = "123/2022",
                    Caratula = "Lorem Ipsum",
                    Dependencia = new IdentificadorDependenciaDto
                    {
                        CodigoOrganismo = "PJDLPDC-AR-U-PUB",
                        CodigoDependencia = "187"
                    }
                }, 
                DependenciaDestino = new CausaDto 
                {
                    NumeroCausa = "456/2022", 
                    Caratula = "Isum Isum Isum ", 
                    Dependencia = new IdentificadorDependenciaDto 
                    {
                        CodigoOrganismo = "PJBA-AR-B-PUB",
                        CodigoDependencia = "PJBA-AR-B-PUB-21-3532"
                    }
                },
                Documento = new DocumentoDto 
                {
                    NombreDocumento = "demo.pdf", 
                    PayloadBase64 = ResourcesHelper.GetPdfBase64()

                }
            });

            Log(rs.Status);
            Log(rs.Message);

            if (rs.Status)
            {
                Log($"Uuid: {rs.Data.Uuid}");
            }
        }
    }
}
