namespace tarea05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir5 = false;
            do
            {

                Console.WriteLine("Tarea 05");
                Console.WriteLine("");

                Console.WriteLine("1. Transformar Grados a Radianes");
                Console.WriteLine("2. Calcular Area de Círculo, Cuadrado o Triángulo");

                Console.WriteLine("0. Me voy");
                Console.WriteLine("");

                string tituloVentana = "Escoja una opción";
                Console.Title = tituloVentana;

                Console.WriteLine("Seleccione una Opción");
                int opcionMenu;
                opcionMenu = Convert.ToInt32(Console.ReadLine());

                //menu = Int32.Parse(opcionMenu);        // es otra forma de pasar a entero
                Console.WriteLine("Opción Seleccionada Es {0} Recuerde usar COMA para decimales", opcionMenu);


                switch (opcionMenu)
                {
                    case 1:
                        Console.Clear();
                        double num1, total_radianes;
                        Console.WriteLine("Ingrese número en Grados");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        total_radianes = Radianes(num1);
                        Console.WriteLine("Radianes en Main {0}", total_radianes);

                        break;
                    case 2:
                        Console.Clear();
                        Areas();
                        break;
                    case 0:
                        Console.WriteLine("Adiós...");
                        salir5 = true;
                        break;
                    default:
                        Console.WriteLine("Opción no Programada");
                        break;

                }
            }
            while (salir5 == false);

            static double Radianes(double grados)
            {
                double resultado = 1.0;               
                resultado = grados * Math.PI/180;
                Console.WriteLine("Método Radianes: {0} Grados en Radianes es {1}",grados, resultado);
                return resultado;
            }

            static void Areas()
            {
                string opcion; 
                Console.WriteLine("Menú Areas");
                Console.Title ="Menú Areas";
                Console.WriteLine("I=Círculo");
                Console.WriteLine("C=Cuadrado");
                Console.WriteLine("T=Triángulo");
                Console.WriteLine("R=Regresar");

                opcion = Console.ReadLine().ToUpper();

                Console.WriteLine("Opción Seleccionada {0}", opcion);

                switch (opcion)
                {
                    case "I":
                        AreaCirculo();
                        break;

                    case "C":
                            AreaCuadrado();
                            break;
                    case "T":
                        AreaTriangulo();
                        break;
                    case "R":
                        break;
                    default:
                        break;
                }
            }

            static void AreaCuadrado()
            {
                double num1, area;
                Console.WriteLine("Ingrese Lado");
                num1 = Convert.ToDouble(Console.ReadLine());
                area = num1*num1;
                Console.WriteLine("Area de Cuadrado de lado {0} es {1}", num1,area);

            }

            static void AreaCirculo()
            {
                double num1, num2, area;
                Console.WriteLine("Ingrese Radio");
                num1 = Convert.ToDouble(Console.ReadLine());
                area = Math.PI*num1*num1/2;
                Console.WriteLine("Area de Círculo de Radio {0} es {1}", num1, area);

            }

            static void AreaTriangulo()
            {
                double num1, num2, area;
                Console.WriteLine("Ingrese Base");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese Altura");
                num2 = Convert.ToDouble(Console.ReadLine());
                area = num1 * num2 / 2;
                Console.WriteLine("Area de Triángulo de Base {0} con Altura {1} es {2}", num1,num2, area);

            }

        }


    }
}
