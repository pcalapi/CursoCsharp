using System.Diagnostics.CodeAnalysis;

namespace seccion02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La Sección 2 trata Acerca De Las Variables");
            Console.WriteLine("");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar");
            Console.WriteLine("3. Restar");
            Console.WriteLine("4. Multiplicar");
            Console.WriteLine("5. Dividir");   // Write no hace salto de línea
            Console.WriteLine("6. Residuo");
            Console.WriteLine("7. Area y Perímetro del Rectángulo o Cuadrado");
            Console.WriteLine("8. Transformar grados Centígrados a Fahrenheit");
            Console.WriteLine("9. Perímetro de un Polígono Regular");
            Console.WriteLine("0. Me voy");
            Console.WriteLine("");
            string tituloVentana = "Escoja una opción";
            //Console.WriteLine(tituloVentana);
            Console.Title = tituloVentana;

            /*para hacer diagramas de flujo www.lucidchart.com*/

            Console.WriteLine("Seleccione una Opción");
            string opcionMenu;
            opcionMenu = Console.ReadLine();
            // si quisiera tomar el valor ingresado como entero, le transformo a int
            int menu, menu2;
            /*
            menu = Convert.ToInt32(Console.ReadLine()); // captura y convierte la variable pero es confuso
            */
            menu = Convert.ToInt32(opcionMenu);
            menu2 = Int32.Parse(opcionMenu);        // es otra forma de pasar a entero
            Console.WriteLine("Vamos por {0}", menu);

            if (opcionMenu == "1")
            {
                Saluda();
            }
            else if (opcionMenu == "2")
                {
                    Suma();
                }
                else if (opcionMenu == "3")
                    {
                        Resta();
                    }
                    else if (opcionMenu == "4")
                        {
                            Multiplica();
                        }
                        else if (opcionMenu == "5")
                            {
                                Divida();
                            }
                            else if (opcionMenu == "6")
                                {
                                    Residuo();
                                }
                                else if (opcionMenu == "7")
                                    {
                                        Rectangulo();
                                    }
                                    else if (opcionMenu == "8")
                                        {
                                            Grados();
                                        }
                                        else if (opcionMenu == "9")
                                            {
                                                Perimetro();
                                            }
                                            else if (opcionMenu == "0")
                                                {
                                                    Salida();
                                                }
       

                Thread.Sleep(3000);     // para poder ver el título de la ventana de consola
            


            // funciones o métodos
            static void Saluda()
            {
                // variables
                string saluda = "Recordando C# a los años";
                Console.Write(saluda);
            }
            static void Suma()
            {
                // variables
                int opcionPaso, numeroUno;
                opcionPaso = 2;
                numeroUno = 1;
                Console.Write("Opción Suma {0}+{1} tiene como ", opcionPaso, numeroUno);
                Console.WriteLine("Resultado " + (numeroUno + opcionPaso));
            }

            static void Resta()
            {
                Console.WriteLine("Opción Resta");
                // decimales y flotantes usan M y F
                double valorPi2 = 3.1416;
                float valorGrande = 200020030.16f;
                double valorDoble = 5.5;
                Console.WriteLine(valorGrande);     // no imprime la parte decimal
                Console.WriteLine(valorDoble);
                Console.WriteLine("Numero valorUno es valor {0} menos el segundo valor es  {1}", valorDoble, valorPi2);

                Console.WriteLine(valorDoble - valorPi2);
            }
            static void Multiplica()
            {
                int numero3 = 3;
                Console.WriteLine("Opción Multiplica 3*3");
                Console.WriteLine(numero3 * numero3);
            }

            static void Divida()
            {
                double numeroDecimal = 3.9;
                Console.WriteLine("Opción Dividir 3,9/2");
                Console.WriteLine(numeroDecimal / 2);
            }

            static void Residuo()
            {
                double numeroDecimal = 3.9;
                Console.WriteLine("Opción Residuo 3,9 % 2");
                Console.WriteLine(numeroDecimal % 2);
            }

            static void Rectangulo()
            {
                decimal altura, largo;
                Console.WriteLine("Ingrese la ALTURA");
                string leeAltura, leeLargo;
                leeAltura = Console.ReadLine();


                Console.WriteLine("Ingrese el BASE");
                leeLargo = Console.ReadLine();

                altura = Convert.ToInt32(leeAltura);
                largo = Convert.ToInt32(leeLargo);
                if (largo == altura)
                {
                    Console.WriteLine("Cuadrado");
                    Console.WriteLine("Area = " + altura * altura);
                    Console.WriteLine("Perímetro = " + altura * 4);

                }
                else
                {
                    Console.WriteLine("Rectángulo");
                    Console.WriteLine("Area = " + (altura * largo / 2));
                    Console.WriteLine("Perímetro = " + ((altura * 2) + largo * 2));
                }

            }

            static void Grados()
            {
                decimal farenheit;
                Console.WriteLine("Ingrese grados Celcius");
                string leecelcius;
                leecelcius = Console.ReadLine();


                farenheit = Convert.ToInt32(leecelcius);
                Console.WriteLine("{0} grados Celcius es = a {1} en Farenheit ", Convert.ToInt32(leecelcius), Convert.ToInt32(leecelcius) * 9 / 5 + 32);

            }

            static void Perimetro()
            {
                int numero_lados;
                double medida_lado, perimetro;
                Console.WriteLine("Ingrese número de LADOS");
                numero_lados = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Ingrese la medida de un LADO (Use , como separador decimal)");
                medida_lado = Convert.ToDouble(Console.ReadLine());

                perimetro = numero_lados * medida_lado;
                Console.WriteLine("Polígono de {0} lados ", numero_lados);
                Console.WriteLine("Perímetro = {0} ", perimetro);
            }


            static void Salida()
            {

                Console.WriteLine("Adios");

            }
        }
    }
}