namespace seccion08_listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables necesarias
            int opcion, indice;
            string alumno;

            //Instancia de List
            List<string> Alumnos = new List<string>();

            do
            {
                Console.Clear();

                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Eliminar estudiante");
                Console.WriteLine("3. Mostrar estudiantes");
                Console.WriteLine("4. Buscar por nombre");

                //Escoger opción
                Console.Write("Escoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingresa el nombre del alumno: ");
                        alumno = Console.ReadLine();

                        Alumnos.Add(alumno);
                        break;
                    case 2:
                        Console.Write("Ingrese el número del estudiante que quiera eliminar: ");
                        indice = Convert.ToInt32(Console.ReadLine());

                        indice--; //Reducimos en 1 a índice, porque el usuario no sabe que el índice empieza en cero, por lo tanto, si se ingresa 1, en realidad será 0.

                        if (indice >= Alumnos.Count() || indice < 0)
                        {
                            Console.WriteLine("El Alumno no existe");
                        }
                        else
                        {
                            string alumnoElim = Alumnos[indice];
                            Alumnos.RemoveAt(indice); //Quitamos al alumno de la List
                            Console.WriteLine("{0} se ha eliminado correctamente", alumnoElim);
                        }
                        Console.Write("\nPresione cualquier tecla para regresar al menú ");
                        Console.ReadKey();
                        break;
                    case 3:
                        int i = 1; //Nos sirve para mostrar el indice de los alumnos

                        foreach (string estudiante in Alumnos)
                        {
                            Console.WriteLine("{0}. {1}", i++, estudiante);
                        }
                        Console.Write("\nPresione cualquier tecla para regresar al menú ");
                        Console.ReadKey();
                        break;
                    case 4:
                        string encontrarAlum;
                        int j; //número de lista

                        Console.Write("Ingrese el nombre del estudiante a buscar: ");
                        alumno = Console.ReadLine();

                        //Verificar si el elemento(alumno) está o no en la List
                        if (Alumnos.IndexOf(alumno) >= 0)
                        {
                            encontrarAlum = Alumnos[Alumnos.IndexOf(alumno)]; //Alumnos[3]
                            j = Alumnos.IndexOf(alumno) + 1;

                            Console.WriteLine("El estudiante {0} se encuentra en el número de lista {1}", encontrarAlum, j);
                        }
                        else
                        {
                            Console.WriteLine("El estudiante {0} no se encuentra en el sistema", alumno);
                        }
                        Console.Write("\nPresione cualquier tecla para regresar al menú ");
                        Console.ReadKey();
                        break;
                }

            } while (opcion >= 1 && opcion <= 4);
        }
    }
}

