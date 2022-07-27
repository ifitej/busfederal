using BF.Borde.Models.Services.Documentos;
using BF.Borde.Models.Shared.Dtos;
using BF.Ejemplos.Resources;
using System.Collections.Generic;

namespace BF.Ejemplos.EjemplosDocumentos
{
    public class EnviarDocumentoConData : Ejemplo
    {
        public override void Execute()
        {
            var rs = this.Client.Documento.EnviarConJsonMetadata<DemoMetadata>(new DocumentoEnviarRequest<DemoMetadata>
            {
                DependenciaOrigen = new CausaDto 
                {
                    NumeroCausa = "123/2022",
                    Caratula = "Lorem Ipsum",
                    Dependencia = new IdentificadorDependenciaDto
                    {
                        CodigoOrganismo = "PJDLPDC-AR-U-PUB",
                        CodigoDependencia = "1"
                    }
                }, 
                DependenciaDestino = new CausaDto 
                {
                    NumeroCausa = "456/2022", 
                    Caratula = "Isum Isum Isum ", 
                    Dependencia = new IdentificadorDependenciaDto 
                    {
                        CodigoOrganismo = "PJBA-AR-B-PUB",
                        CodigoDependencia = "PJBA-AR-B-PUB-1-15"
                    }
                },
                Documento = new DocumentoDto 
                {
                    NombreDocumento = "demo.pdf", 
                    PayloadBase64 = ResourcesHelper.GetPdfBase64()
                }, 
                Data = new DemoMetadata 
                {
                    Numero = 123456, 
                    Imputados = new List<DemoMetadata.Persona> 
                    {
                        new DemoMetadata.Persona
                        {
                            Apellido = "Oratio", 
                            Nombre = "Nominati", 
                            Documento = 123456
                        },
                        new DemoMetadata.Persona
                        {
                            Apellido = "Signiferumque",
                            Nombre = "Adipisci",
                            Documento = 654321
                        }
                    }                    
                }
            });

            Log(rs.Status);
            Log(rs.Message);

            if (rs.Status)
            {
                Log($"Uuid: {rs.Data.Uuid}");
            }

            // Recupera el documento
            var rsTraer = this.Client.Documento.Traer<DemoMetadata>(new DocumentoTraerRequest
            {
                Uuid = rs.Data.Uuid
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
