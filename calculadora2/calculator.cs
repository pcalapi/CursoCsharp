namespace calculadora2
{
    internal class Calculador
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de 2 Números");
            Console.WriteLine("");

            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");   // Write no hace salto de línea
            Console.WriteLine("5. Residuo");
            Console.WriteLine("6. Potencia");

            Console.WriteLine("0. Me voy");
            Console.WriteLine("");

            string tituloVentana = "Escoja una opción";
            Console.Title = tituloVentana;

            Console.WriteLine("Seleccione una Opción");
            string opcionMenu;
            opcionMenu = Console.ReadLine();
            // si quisiera tomar el valor ingresado como entero, le transformo a int
            int menu, menu2;
            /*
            menu = Convert.ToInt32(Console.ReadLine()); // captura y convierte la variable pero es confuso
            */
            //menu = Convert.ToInt32(opcionMenu);
            menu = Int32.Parse(opcionMenu);        // es otra forma de pasar a entero

            Console.WriteLine("Opción Seleccionada Es {0} Recuerde usar COMA para decimales", menu);

            double num1,num2;
            Console.WriteLine("Ingrese primer número");
            num1 = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Ingrese segundo número");
            num2 = Convert.ToDouble( Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Suma(num1,num2);
                    break;
                case 2:
                    Resta(num1, num2);
                    break;
                case 3:
                    Multiplica(num1, num2);
                    break;
                case 4:
                    Divide(num1, num2);
                    break;
                case 5:
                    Residuo(num1, num2);
                    break;
                case 6:
                    Potencia(num1, num2);
                    break;

                default:
                    Console.WriteLine("Opción no Programada");
                    break;

            }



            // funciones
            static void Suma(double valor1, double valor2)
            {
                Console.Write("Opción Suma {0}+{1} tiene como ", valor1, valor2);
                Console.WriteLine("Resultado " + (valor1 + valor2));
            }

            static void Resta(double valor1, double valor2)
            {
                Console.Write("Opción Resta de {0} - {1} tiene como ", valor1, valor2);
                Console.WriteLine("Resultado " + (valor1 - valor2));
            }

            static void Multiplica(double valor1, double valor2)
            {
                Console.Write("Opción Multiplicar de {0} * {1} tiene como ", valor1, valor2);
                Console.WriteLine("Resultado " + (valor1 * valor2));
            }

            static void Divide(double valor1, double valor2)
            {
                if (valor2 == 0)
                    Console.WriteLine("Dividendo no válido");
                else
                {
                    Console.Write("Opción Dividir de {0} / {1} tiene como ", valor1, valor2);
                    Console.WriteLine("Resultado " + (valor1 / valor2));
                }
            }

            static void Residuo(double valor1, double valor2)
            {
                if (valor2 == 0)
                    Console.WriteLine("Dividendo no válido");
                else
                {
                    Console.Write("Opción Residuo de {0} / {1} tiene como ", valor1, valor2);
                    Console.WriteLine("Resultado " + (valor1 % valor2));
                }
            }

            static void Potencia(double valor1, double potencia)
            {
                double resultado;
                Console.Write("Opción Potencia de {0} elevado a {1} tiene como ", valor1, potencia);
                resultado = Math.Pow(valor1, potencia);
                Console.WriteLine("Resultado {0} ", resultado );
            }

        }
    
    
    
    
    
    
    
    
    }
}
