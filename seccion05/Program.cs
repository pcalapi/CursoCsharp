using System.Diagnostics;

namespace seccion05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            do
            {
                
                Console.WriteLine("Sección 05");
                Console.WriteLine("");

                Console.WriteLine("1. Potencia");
                Console.WriteLine("2. Números Primos 1-100");
                Console.WriteLine("3. Llamar Tarea05");

                Console.WriteLine("0. Me voy");
                Console.WriteLine("");

                string tituloVentana = "Escoja una opción";
                Console.Title = tituloVentana;

                Console.WriteLine("Seleccione una Opción");
                int opcionMenu;
                opcionMenu = Convert.ToInt32(Console.ReadLine());

                //menu = Int32.Parse(opcionMenu);        // es otra forma de pasar a entero
                Console.WriteLine("Opción Seleccionada Es {0} ", opcionMenu);


                switch (opcionMenu)
                {
                    case 1:
                        Console.Clear();
                        double num1, num2, total_potencia;
                        Console.WriteLine("Ingrese número base");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese número potencia");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        total_potencia = Potencia(num1, num2);
                        Console.WriteLine("Potencia en Main {0}", total_potencia);
                        break;
                    case 2:
                        Console.Clear();
                        int total_primos;       // captura el valor de la suma de los números primos
                        total_primos = Primos();
                        Console.WriteLine("Total valor números primos {0}", total_primos);
                        break;
                    case 3:
                        // llamar a otro archivo
                        Console.WriteLine("Llamando a otro programa...");
                        Process.Start("C:\\pedrocalapi\\VScursoUdemy\\tarea05\\bin\\Debug\\net10.0\\tarea05.exe");
                        salir = true;
                        break;
                    case 0:
                        Console.WriteLine("Adiós...");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no Programada");
                        break;

                }
            }
            while (salir == false);

            static double Potencia(double valor1, double potencia)
            {
                double resultado = 1;
                int i;
                Console.WriteLine("Opción Potencia de {0} elevado a {1} tiene como ", valor1, potencia);
                if (potencia < 0)
                {
                    potencia *= -1;
                    for (i = 1; i <= potencia; i++)
                    {
                        resultado = resultado *= valor1;
                    }
                    resultado = 1 / resultado;
                }
                else
                {
                    for (i = 1; i <= potencia; i++)
                    {
                        resultado = resultado *= valor1;
                    }
                }
                //resultado = Math.Pow(valor1, potencia);
                Console.WriteLine("Resultado en método {0} ", resultado);
                return resultado;
            }

            static int Primos()
            {
                Console.WriteLine("Números Primos");
                int control, ciclo, acumulador;
                string tipo_numero = "";
                //bool primo = false;
                int primo = 0;
                acumulador = 0;
                for (control = 2; control <= 100; control++)
                {
                    //primo = false;
                    primo = 0;
                    for (ciclo = 1; ciclo <= control; ciclo++)
                    {
                        if (control % ciclo == 0)
                        {
                            primo += 1;
                        }
                    }

                    if (primo == 2)  // unidad y el mismo
                    {
                        Console.WriteLine("Número primo {0} {1}", control, tipo_numero);
                        acumulador += control;   
                    }
                }
                return acumulador;
                //Console.ReadKey();    
            }

        }


    }
}
