namespace seccion04
{
    internal class tarea4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tarea 04");
            Console.WriteLine("");

            Console.WriteLine("1. Potencia");
            Console.WriteLine("2. Números Primos 1-100");
            
            Console.WriteLine("0. Me voy");
            Console.WriteLine("");

            string tituloVentana = "Escoja una opción";
            Console.Title = tituloVentana;

            Console.WriteLine("Seleccione una Opción");
            int opcionMenu;
            opcionMenu = Convert.ToInt32( Console.ReadLine());
          
            //menu = Int32.Parse(opcionMenu);        // es otra forma de pasar a entero
            Console.WriteLine("Opción Seleccionada Es {0} Recuerde usar COMA para decimales", opcionMenu);


            switch (opcionMenu)
            {
                case 1:
                    double num1, num2;
                    Console.WriteLine("Ingrese número base");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese número potencia");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Potencia(num1, num2);
                    break;
                case 2:
                    Primos();
                    break;
                case 0:
                    Console.WriteLine("Adiós...");
                    break;
                default:
                    Console.WriteLine("Opción no Programada");
                    break;

            }

            static void Potencia(double valor1, double potencia)
            {
                double resultado= 1;
                int i;
                Console.Write("Opción Potencia de {0} elevado a {1} tiene como ", valor1, potencia);
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
                Console.WriteLine("Resultado {0} ", resultado);
            }

            static void Primos()
            {
                Console.WriteLine("Números Primos");
                int control, ciclo;
                string tipo_numero = "";
                //bool primo = false;
                int primo=0;
                for (control = 2; control <= 100; control++)
                {
                    //primo = false;
                    primo=0;
                    for (ciclo = 1; ciclo <= control; ciclo++)
                    {
                        if (control % ciclo == 0)
                            {
                            primo += 1;
                            }
                    }
                    
                    if (primo ==2)  // unidad y el mismo
                    {
                        Console.WriteLine("Número primo {0} {1}", control, tipo_numero);
                    }
                    
                }
                //Console.ReadKey();    
            }

        }
    
    
    
    
    
    }
}
