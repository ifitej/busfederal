using System.Collections.Generic;

namespace BF.Ejemplos.EjemplosDocumentos
{
    public class DemoMetadata
    {
        public int Numero { get; set; }
        public List<Persona> Imputados { get; set; } = new List<Persona>();

        public class Persona 
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public long Documento { get; set; }
        }
    }
}
