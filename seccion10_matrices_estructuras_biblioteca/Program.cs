using System.Globalization;

namespace seccion10_matrices_estructuras_biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            bool repetir = true; //Se encarga de repetir el menú hasta que nosotros decidamos salir del programa
            string opcion;

            // Creamos una instancia de la clase Biblioteca
            Biblioteca biblioteca1 = new Biblioteca();

            do
            {
                Console.WriteLine("\nBiblioteca Tropical {0}\n", DateTime.Now.ToString());
                Console.WriteLine("1. Agregar libro");
                Console.WriteLine("2. Mostrar todos los libros");
                Console.WriteLine("3. Búsqueda exacta de un libro");
                Console.WriteLine("4. Búsqueda parcial de un libro");
                Console.WriteLine("5. Eliminar un libro");
                Console.WriteLine("6. Revisar Fechas");
                Console.WriteLine("7. Salir");

                Console.Write("\nIngresar una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": // Agregar un nuevo libro
                        biblioteca1.AgregarLibro();
                        break;

                    case "2":  // Mostrar una lista de los libros
                        biblioteca1.MostrarLibros();
                        break;

                    case "3":  // Búsqueda exacta
                        biblioteca1.BuscarLibro();
                        break;

                    case "4": // Búsqueda parcial de un libro
                        biblioteca1.BusquedaParcial();
                        break;

                    case "5":  // Eliminar libro
                        biblioteca1.EliminarLibro();
                        break;
                    case "6":  // Revisión fechas
                        Console.Clear();
                        Console.WriteLine("Vamos a revisar varios formatos de fechas \n");
                        Console.WriteLine("Fecha y hora actuales {0}",DateTime.Now.ToString());
                        DateTime ahora = DateTime.Now;

                        
                        Console.WriteLine("Solo FECHA: " + DateTime.Now.ToShortDateString());
                        Console.WriteLine("Año DateTime.Now.Year: " + DateTime.Now.Year);
                        Console.WriteLine("Mes variable_fecha.Month: " + ahora.Month);
                        Console.WriteLine("Día variable_fecha.Day " + ahora.Day);
                        Console.WriteLine("Solo La HORA: " + ahora.ToShortTimeString());
                        Console.WriteLine("Hora variable_fecha.Hour: " + ahora.Hour);
                        Console.WriteLine("Minuto variable_fecha.Minute: " + ahora.Minute);
                        Console.WriteLine("Segundo variable_fecha.Second: " + ahora.Second);
                        Console.WriteLine("Día de la semana ahora.DayOfWeek: " + ahora.DayOfWeek);

                        // para la semana
                        CultureInfo cultura = new CultureInfo("es-EC"); // Ecuador (puedes usar es-ES también)
                        Calendar calendario = cultura.Calendar;
                        int semana = calendario.GetWeekOfYear(
                            ahora,
                            CalendarWeekRule.FirstFourDayWeek, // regla común (ISO)
                            DayOfWeek.Monday                  // semana inicia en lunes
                        );
                        Console.WriteLine("Semana del año: " + semana);



                        Console.WriteLine("Día del año: " + ahora.DayOfYear);



                        break;
                    case "7":  // Finalizar el programa
                        repetir = false; //El bucle se repite mientras "repetir == true", por lo tanto, esta instrucción nos sacará del programa
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n{0} ¡Opción invalida, intenta de nuevo!\n", opcion);
                        break;
                }


            } while (repetir);

        }
    }
    class Biblioteca
    {
        // Campos
        Libro[] libros; //Declaramos una matriz de tipo struct "Libro"
        int cantidadLibros = 0; // No existen libros al inicio del programa
        string buscarLibro;
        bool libroEncontrado;
        int posicionLibroEliminar;

        // Constructor
        public Biblioteca()
        {
            libros = new Libro[1000]; //Inicializamos la matriz con una capacidad de mil elementos
        }

        // Métodos para interactuar con los libros
        public void AgregarLibro()
        {
            if (cantidadLibros < libros.Length) // Verificar si podemos ingresar un nuevo libro
            {
                Console.Clear();
                Console.WriteLine($"Ingresar información para el libro {cantidadLibros + 1}\n"); // Decimos +1 para mostrar un índice que el usuario entienda

                Console.Write("Ingresa el nombre del libro: ");
                libros[cantidadLibros].Titulo = Console.ReadLine();
                Console.Write("Ingresa el Autor: ");
                libros[cantidadLibros].Autor = Console.ReadLine();
                Console.Write("Ingresa el año: ");
                libros[cantidadLibros].Año = Console.ReadLine();

                cantidadLibros++; // Aumentamos la cantidad de libros existentes

                Console.Clear();
                Console.WriteLine("¡Libro agregado correctamente!\n");
            }
            else
            {
                // En caso de que excedamos el número de libros, mostramos este mensaje
                Console.WriteLine("¡Biblioteca llena! Intenta eliminar un libro");
            }
        }

        public void MostrarLibros()
        {
            Console.Clear();

            if (cantidadLibros == 0)
            {
                // Si no existe ningún libro, mostramos el sig. mensaje
                Console.WriteLine("¡Biblioteca vacía! Agrega libros para poder visualizarlos");
            }
            else
            {
                for (int i = 0; i < cantidadLibros; i++) // Si existe al menos uno, mostramos   su información
                {
                    Console.WriteLine($"{i + 1}.- Título = {libros[i].Titulo}, Autor = {libros[i].Autor}, Año = {libros[i].Año}");
                }

                Console.Write("\nPresiona cualquier tecla para continuar... ");
                Console.ReadKey();
                Console.WriteLine(); //Espacio en blanco
            }
        }

        public void BuscarLibro()
        {
            Console.Clear();

            Console.Write("Ingresa el nombre exacto del libro para buscarlo: ");
            buscarLibro = Console.ReadLine();
            libroEncontrado = false;//Inicializamos al campo en "false" para indicar que al iniciar el recorrido por la matriz no hemos encontrado un libro

            for (int i = 0; i < cantidadLibros; i++)
            {
                if (libros[i].Titulo.Equals(buscarLibro))
                {
                    Console.WriteLine($"El libro \"{libros[i].Titulo}\" del autor(a): \"{libros[i].Autor}\" se encuentra disponible en la biblioteca en el índice: {i + 1}");
                    libroEncontrado = true; // Asignamos "true" para indicar que hemos encontrado el libro, y así evitar entrar en el siguiente "if"
                }
            }
            if (!libroEncontrado) //Lo mismo que colocar if(libroEncontrado == false)
            {
                Console.WriteLine("¡Libro no encontrado!\n");
            }
        }

        public void BusquedaParcial()
        {
            Console.Clear();

            Console.Write("Ingresa al menos una parte del título o del nombre del autor de un libro para buscarlo: ");
            buscarLibro = Console.ReadLine().ToLower();

            libroEncontrado = false;//Inicializamos la variable en "false" para indicar que al iniciar el recorrido por la matriz no hemos encontrado un libro

            for (int i = 0; i < cantidadLibros; i++)
            {
                if (libros[i].Titulo.ToLower().Contains(buscarLibro) || libros[i].Autor.ToLower().Contains(buscarLibro))
                {
                    Console.WriteLine($"La palabra \"{buscarLibro}\" fue encontrada en el libro: \"{libros[i].Titulo}\" del autor(a): \"{libros[i].Autor}\" en el índice: {i + 1}");
                    libroEncontrado = true; // Asignamos "true" para indicar que hemos encontrado el libro, y así evitar entrar en el siguiente "if"
                }
            }
            if (!libroEncontrado) //Lo mismo que colocar if(encontrar == false)
            {
                Console.WriteLine("¡No se encontraron coincidencias!\n");
            }

        }

        public void EliminarLibro()
        {
            Console.Clear();

            if (cantidadLibros == 0)
            {
                Console.WriteLine("¡La biblioteca está vacía, no hay nada que eliminar!");
            }
            else
            {
                Console.Write($"Ingrese el número de libro que desea eliminar (Del 1 al {cantidadLibros}): ");
                posicionLibroEliminar = Convert.ToInt32(Console.ReadLine()) - 1; //Decimos que es -1 para que el índice ingresado por el usuario coincida con el índice real de matriz

                // Verificamos que el número ingresado sea válido
                if (posicionLibroEliminar >= 0 && posicionLibroEliminar < cantidadLibros)
                {
                    //Confirmamos si el libro que ingresó es el que quiere eliminar
                    Console.Write($"¿El libro que deseas eliminar es: \"{libros[posicionLibroEliminar].Titulo}\"? (Sí/No): ");
                    string opcion = Console.ReadLine().ToLower();

                    if (opcion == "si")
                    {
                        // Variables para mostrar un mensaje de cuál fue el libro eliminado
                        string tituloEliminado = libros[posicionLibroEliminar].Titulo;
                        string autorEliminado = libros[posicionLibroEliminar].Autor;

                        for (int i = posicionLibroEliminar; i < cantidadLibros; i++)
                        {
                            libros[i] = libros[i + 1];
                        }
                        cantidadLibros--; //Reducimos la cantidad de libros en uno, por el que acabamos de eliminar

                        // Le mostramos al usuario el libro que se eliminó
                        Console.WriteLine($"\n¡El libro \"{tituloEliminado}\" del autor(a): \"{autorEliminado}\" fue eliminado!");
                    }
                    else
                    {
                        Console.WriteLine("Operación \"eliminar libro\" cancelada");
                    }


                }
                else
                {
                    Console.WriteLine("¡El número de libro no es válido!");
                }
            }
        }


        struct Libro
        {
            //Campos
            string titulo;
            string autor;
            string año;

            // Propiedades
            public string Titulo { get => titulo; set => titulo = value; }
            public string Autor { get => autor; set => autor = value; }
            public string Año { get => año; set => año = value; }
        }
    }
}


