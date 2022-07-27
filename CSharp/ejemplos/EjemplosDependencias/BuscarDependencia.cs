using BF.Borde.Models.ApiModel;
using System;

namespace BF.Ejemplos.EjemplosDependencias
{
    public class BuscarDependencia : Ejemplo
    {
        public override void Execute()
        {
            var rs = this.Client.Dependencia.Buscar(new DependenciaBuscarRequest
            {
                CodigoOrganismo = "PJDLPDC-AR-U-PUB",
                Nombre = "prueba"
            });

            Log(rs.Status);
            Log(rs.Message);

            if (rs.Status)
            {
                Log($"TotalRegistros: {rs.Data.TotalRegistros}");
                Log("Resultados");

                rs.Data.Items?.ForEach(x =>
                {
                    Log($".... {x.CodigoDependencia}: {x.Nombre}");
                });
            }
        }
    }
}
