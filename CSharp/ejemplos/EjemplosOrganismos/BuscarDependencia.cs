using BF.Borde.Models.ApiModel;
using System;

namespace BF.Ejemplos.EjemplosOrganismos
{
    public class BuscarDependencia : Ejemplo
    {
        public override void Execute()
        {
            var rs = this.Client.Organismo.Buscar(new OrganismoBuscarRequest
            {
                Provincia = "Chubut"
            });

            Log(rs.Status);
            Log(rs.Message);

            if (rs.Status)
            {
                Log("Resultados");

                rs.Data.Items?.ForEach(x =>
                {
                    Log($".... {x.CodigoOrganismo}: {x.Nombre}");
                });
            }
        }
    }
}
