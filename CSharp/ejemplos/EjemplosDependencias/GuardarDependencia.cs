using BF.Borde.Models.ApiModel;

namespace BF.Ejemplos.EjemplosDependencias
{
    public class GuardarDependencia : Ejemplo
    {
        public override void Execute()
        {
            var rs = this.Client.Dependencia.Guardar(new DependenciaGuardarRequest
            {
                CodigoDependencia = "1",
                Nombre = "Dependencia de prueba"
            });

            Log(rs.Status);
            Log(rs.Message);

            if (rs.Status)
            {
                Log(rs.Data.CodigoDependencia);
            }
        }
    }
}
