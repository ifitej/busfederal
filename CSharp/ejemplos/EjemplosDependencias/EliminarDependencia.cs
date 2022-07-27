using BF.Borde.Models.ApiModel;

namespace BF.Ejemplos.EjemplosDependencias
{
    public class EliminarDependencia : Ejemplo
    {
        public override void Execute()
        {
            var rs = this.Client.Dependencia.Eliminar(new DependenciaEliminarRequest
            {
                CodigoDependencia = "1"
            });

            Log(rs.Status);
            Log(rs.Message);
        }
    }
}
