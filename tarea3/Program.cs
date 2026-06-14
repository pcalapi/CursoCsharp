namespace tarea3
{
    internal class Tarea3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tarea 3");
            Console.WriteLine("");

            Console.WriteLine("1. Nombre del Mes");
            Console.WriteLine("2. Número Par o Impar");
            Console.WriteLine("3. Pago Estacionamiento");

            Console.WriteLine("0. Salir");
            Console.WriteLine("");

            string tituloVentana = "Escoja una opción";
            Console.Title = tituloVentana;

            Console.WriteLine("Seleccione una Opción");
            string opcionMenu;
            opcionMenu = Console.ReadLine();
            // si quisiera tomar el valor ingresado como entero, le transformo a int
            int menu;
            //menu = Convert.ToInt32(opcionMenu);
            menu = Int32.Parse(opcionMenu);        // es otra forma de pasar a entero

            Console.WriteLine("Opción Seleccionada Es {0}", menu);

            int num1, num2;
            

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Ingrese Número de Mes");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    switch (num1)
                    {
                        case 1:
                            Console.WriteLine("Enero");
                            break;
                        case 2:
                            Console.WriteLine("Febrero");
                            break;
                        case 3:
                            Console.WriteLine("Marzo");
                            break;
                        case 4:
                            Console.WriteLine("Abril");
                            break;
                        case 5:
                            Console.WriteLine("Mayo");
                            break;
                        case 6:
                            Console.WriteLine("Junio");
                            break;
                        case 7:
                            Console.WriteLine("Julio");
                            break;
                        case 8:
                            Console.WriteLine("Agosto");
                            break;
                        case 9:
                            Console.WriteLine("Septiembre");
                            break;
                        case 10:
                            Console.WriteLine("Octubre");
                            break;
                        case 11:
                            Console.WriteLine("Noviembre");
                            break;
                        case 12:
                            Console.WriteLine("Diciembre");
                            break;
                        default:
                            Console.WriteLine("Número no válido");
                            break;
                    }

                    break;
                case 2:
                    Console.WriteLine("Ingrese número para evaluación");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    if (num1 % 2 == 0)
                        Console.WriteLine("Número Par");
                    else
                        Console.WriteLine("IMPAR");
                    break;
                case 3:
                    Console.WriteLine("Ingrese Horas");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese Minutos");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    int tiempo_total;
                    tiempo_total = num1 * 60 + num2;

                    Console.WriteLine("Tiempo de Estacionamiento {0} minutos ", tiempo_total);
                    if (tiempo_total>120)
                        Console.WriteLine("Costo Total {0} ", 40);
                    else if (tiempo_total>60)
                        Console.WriteLine("Costo Total {0} ", 15);
                        else
                            Console.WriteLine("Costo Total {0} ", 5);

                    break;

                case 0:
                    Console.WriteLine("Adiós");
                    break;
                default:
                    Console.WriteLine("Opción no Programada");
                    break;

            }



            // funciones
            //static void Suma(decimal valor1, decimal valor2)
            //{
            //    Console.Write("Opción Suma {0}+{1} tiene como ", valor1, valor2);
            //    Console.WriteLine("Resultado " + (valor1 + valor2));
            //}
        }
    }
}
