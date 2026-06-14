using System;
using System.Diagnostics;   // para llamar a otro programa
using System.Threading;     // para hacer demoras de tiempo Sleep

namespace Tarea1
{
    internal class tarea1
    {
        static void Main(string[] args)
        {
            Console.Title = "Primera Tarea";
            Console.WriteLine("Mi nombre es Pedro Calapi ");
            Thread.Sleep(2000);
            Console.WriteLine("Tarea 1 creada hoy " + DateTime.Now);
            Thread.Sleep(3000);

            // llamar a otro archivo
            Console.WriteLine("Llamando a otro programa...");
           Process.Start("C:\\pedrocalapi\\VScursoUdemy\\HolaMundo\\bin\\Debug\\net10.0\\holamundo.exe");
        }
    }
}
