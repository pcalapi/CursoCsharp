namespace seccion08_diccionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables necesarias ciclo y lectura
            int opcion;
            string nombre;
            long numero;
            bool continuar = true;

            //Instanciamos a la colección
            Dictionary<string, long> contactos = new Dictionary<string, long>();

            do
            {
                Console.Clear();

                //Menú
                Console.WriteLine("1. Agregar contacto   contactos.Add(Key, Value)");
                Console.WriteLine("2. Buscar contacto    contactos.ContainsKey(Key)");
                Console.WriteLine("3. Eliminar contacto  contactos.Remove(Key)");
                Console.WriteLine("4. Mostrar contactos  Escribir (\"{0}: {1}\", elemento.Key, elemento.Value)");
                Console.WriteLine("5. Actualizar   contactos[nombre] = numero");
                Console.WriteLine("0. Salir");

                Console.Write("\nEscoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();

                        Console.Write("Número: ");
                        numero = Convert.ToInt64(Console.ReadLine());

                        contactos.Add(nombre, numero);
                        Console.WriteLine("\n({0}) se ha agregado con exito", nombre);

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Buscar contacto por nombre: ");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            Console.WriteLine("\n¡Contacto encontrado!");

                            Console.WriteLine("{0}: {1}", nombre, contactos[nombre]);

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n¡El contacto no existe!");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        Console.Write("Contacto a eliminar: ");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            contactos.Remove(nombre);

                            Console.WriteLine("\n({0}) ha sido eliminado con exito", nombre);

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n¡El contacto no existe!");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Contactos en tu agenda: \n");

                        foreach (KeyValuePair<string, long> elemento in contactos)
                        {
                            Console.WriteLine("{0}: {1}", elemento.Key, elemento.Value);
                        }

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Actualizar tu agenda: \n");
                        Console.WriteLine("\nNombre a actualizar");
                        nombre = Console.ReadLine();

                        Console.WriteLine("Nuevo valor");
                        numero = Convert.ToInt64(Console.ReadLine());
                        if (contactos.ContainsKey(nombre))
                        {
                            contactos[nombre] = numero;
                        }
                        else
                        {
                            Console.WriteLine("Elemento {0} no encontrado", nombre);
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar: \n");
                        Console.ReadLine();
                        break;
                    case 0:
                        continuar = false;
                        break;
                }

                //} while (opcion >= 1 && opcion <= 4);
            } while (continuar);
        }
    }
}
