using System;
using System.Threading;     // igual funciona sin incluir porque el 2026 ya lo trae por default

namespace HolaMundo
{
    internal class Program
    {
        static void otrafuncion()
        {
            Console.WriteLine("Otra función...");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!... Programa de Consola.");
            otrafuncion();
            otrafuncion2();
            // espera 3 segundos y se cierra Herramientas,Opciones,Depuración,Cerrar consola al detener la depuración
            Thread.Sleep(3000);
        }
        static void otrafuncion2()
        {
            Console.WriteLine("Comentario2 función2..." + DateTime.Now);
            otrafuncion();

        }
    }
}


