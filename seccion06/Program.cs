namespace seccion06
{
    internal class Matrices
    {
        static void Main(string[] args)
        {
            //Variables
            byte i, j, numAlumnos, salones;
            double sumaCalif = 0, sumaCalifSalon, totalAlumnos = 0, promedio, califMin = 10, califMax = 0;

            //Pedimos el número de salones
            Console.Write("Ingrese el número de salones: ");
            salones = Convert.ToByte(Console.ReadLine());

            //Creación de la matriz
            double[][] calificaciones = new double[salones][];

            //Espacio en blanco
            Console.WriteLine();

            // Pedimos el número de alumnos por salón
            for (i = 0; i < salones; i++)
            {
                Console.Write("Ingrese el número de alumnos para el salón {0}: ", i);
                numAlumnos = Convert.ToByte(Console.ReadLine());

                //Acumulamos el número de alumnos totales, para el promedio de toda la escuela
                totalAlumnos += numAlumnos;

                //Instanciamos las matrices internas (alumnos en cada salón)
                calificaciones[i] = new double[numAlumnos];
            }

            //Espacio en blanco
            Console.WriteLine();

            //Declaramos matrices unidimensionales para almacenar datos por salón
            double[] califMinSalon = new double[salones];
            double[] califMaxSalon = new double[salones];
            double[] promedioSalon = new double[salones];

            //Pedimos las calificaciones de los alumnos de cada salón
            for (i = 0; i < salones; i++)
            {
                /*Los valores de calMax, calMin y sumaCalifSalon se tienen que reiniciar a un valor de cero en cada vuelta del ciclo, para que puedan ser comparados nuevamente en cada salón, o de lo contrario se quedaran con los últimos valores que acumularon o encontaron */
                sumaCalifSalon = 0;
                califMax = 0;
                califMin = 10;

                //Mostramos el salón en el que estamos
                Console.WriteLine("Salón {0}", i);
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    //Pedimos la calificación
                    Console.Write("Ingresa la calificación del alumno {0}: ", j);
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

                    //Acumulamos las calificaciones de toda la escuela
                    sumaCalif += calificaciones[i][j];

                    //Acumulamos las calificaciones por salón
                    sumaCalifSalon += calificaciones[i][j];

                    //Encontramos la calificación mínima en cada salón
                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }
                    //Asignamos la calificación más baja encontrada, en la casilla correspondiente al salón
                    califMinSalon[i] = califMin;

                    //Encontramos la calificación máxima en cada salón
                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }
                    //Asignamos la calificación más alta encontrada, en la casilla correspondiente al salón
                    califMaxSalon[i] = califMax;
                }
                //Calculamos el promedio de cada salón
                promedioSalon[i] = sumaCalifSalon / calificaciones[i].Length;
            }

            //Calculamos el promedio de toda la escuela
            promedio = sumaCalif / totalAlumnos;

            /*El cálculo de las calificaciones mínima y máxima para toda la escuela se tiene que volver a hacer, usando otras instrucciones de iteración, porque el reinicio de los valores en las variables causaria conflicto*/

            //Calculamos la calificación mínima y máxima para toda la escuela en un mismo "for"
            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    // Calificación mínima
                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }
                    // Calificación máxima
                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }
                }
            }
            //Espacio en blanco
            Console.WriteLine();
            Console.WriteLine();

            //Titulo para indicar que estamos mostrando información
            Console.WriteLine("¡DATOS DE LA ESCUELA!");

            //Espacio en blanco
            Console.WriteLine();


            //Mostramos las calificaciones de todos los alumnos de la escuela
            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("Salón {0}", i);
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine("El alumno {0}, tiene {1} de calificación", j, calificaciones[i][j]);
                }
            }

            //Espacio en blanco
            Console.WriteLine();

            //Mostramos los resultados de cada salón
            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("INFORMACIÓN DEL SALÓN {0}: ", i);
                Console.WriteLine("Calificación máxima: {0}, calificación mínima: {1}", califMaxSalon[i], califMinSalon[i]);
                Console.WriteLine("Promedio: {0}", promedioSalon[i]);
            }

            //Espacio en blanco
            Console.WriteLine();

            //Mostramos los resultados para toda la escuela
            Console.WriteLine("El promedio de toda la escuela es: {0}", promedio);
            Console.WriteLine("La calificación más baja de la escuela es: {0}", califMin);
            Console.WriteLine("La calificación más alta de la escuela es: {0}", califMax);


            // llamamos a la funcion 
            FunMatrices();
        }


        // funciones o métodos
        static void FunMatrices()
        {
            string[] frutas = new string[4];
            string frutas_todas = "";
            frutas[0] = "Orange";
            frutas[1] = "Lemon";
            frutas[2] = "Apple";
            frutas[3] = "Mango";

            byte i;
            for(i=0;i<4;i++)
            {
                Console.WriteLine("Fruta {0} es {1} ",i, frutas[i] );
                // cambios de valor
                frutas_todas = frutas_todas + frutas[i] +",";
            }
            Console.WriteLine("Lista general {0}", frutas_todas);
            Console.WriteLine("Lista Original {0}", frutas);
            Console.WriteLine("Longitud de Frutas {0}", frutas.Length);
        }
    }
}
