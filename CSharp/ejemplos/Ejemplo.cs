using BF.Borde.ApiClient;
using System;

namespace BF.Ejemplos
{
    public abstract class Ejemplo
    {
        public BordeClient Client { get; set; }

        public abstract void Execute();

        public void Log(object texto)
        {
            Log(texto?.ToString());
        }

        public void Log(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
