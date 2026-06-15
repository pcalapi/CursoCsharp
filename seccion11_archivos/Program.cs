using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using File = System.IO.File;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Forms;

namespace seccion11_archivos
{
    class Program
    {
        [STAThread] // IMPORTANTE
        static void Main(string[] args)
        {
            bool continuar = true;
            string opcion, nombre_archivo, texto_agregar;
            string ruta_y_archivo = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Operaciones con Archivos");
                Console.WriteLine("1.- Crear Archivo");
                Console.WriteLine("2.- Agregar Texto Al Archivo");
                Console.WriteLine("3.- Revisar el Archivo");
                Console.WriteLine("4.- Ruta Del Archivo");
                Console.WriteLine("5.- Copiar El Archivo");
                Console.WriteLine("6.- Borrar El Archivo");
                Console.WriteLine("7.- Seleccionar El Archivo");
                Console.WriteLine("X.- Salir");

                Console.WriteLine("Seleccione una Opción");
                opcion = Console.ReadLine().ToUpper();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Crear Archivos");
                        Console.WriteLine("Ingrese Nombre de Archivo a Crear");
                        nombre_archivo = Console.ReadLine();
                        nombre_archivo = nombre_archivo + ".txt";
                        FileStream fs = new FileStream(nombre_archivo, FileMode.Create);  // crea el archivo
                        
                        Console.WriteLine("Archivo creado en C:\\pedrocalapi\\VScursoUdemy\\seccion11_archivos\\bin\\Debug\\net10.0\\{0}", nombre_archivo);

                        fs.Close();
                        //ruta_y_archivo = @"C:\pedrocalapi\VScursoUdemy\seccion11_archivos\bin\Debug\net10.0\" + nombre_archivo;
                        ruta_y_archivo = Path.Combine(Directory.GetCurrentDirectory(), nombre_archivo);
                        

                        Console.ReadLine();
                        break;

                    case "2":
                        if (File.Exists(ruta_y_archivo))
                        {
                            Console.WriteLine("Agregar Contenido Al Archivo");
                            Console.WriteLine("Ingrese el Texto A Agregar");

                            texto_agregar = Console.ReadLine();
                            //File.AppendAllText(@"C:\pedrocalapi\VScursoUdemy\seccion11_archivos\bin\Debug\net10.0\peter_textos.txt",texto_agregar + DateTime.Now + "\n");
                            File.AppendAllText(ruta_y_archivo, $"{texto_agregar} {DateTime.Now}\n");

                        }
                        {
                            Console.WriteLine("Archivo no existe");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Revisar Contenido Al Archivo");
                        Console.WriteLine("Primera Línea");
                        string texto;
                        //StreamReader st = new StreamReader("peter_textos.txt");
                        StreamReader st = new StreamReader(ruta_y_archivo);
                        texto = st.ReadLine();       // solo la primera línea
                        Console.WriteLine($"Primera Línea Readline: {texto}");
                        Console.ReadLine();
                        //texto = st.ReadLine();       // lea todo
                        texto = File.ReadAllText(ruta_y_archivo);   // lea todo
                        Console.WriteLine($"TODO el archivo\n {texto}");
                        st.Close();

                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Ruta de Trabajo");
                        if (File.Exists(ruta_y_archivo))
                        {
                            string rutaCompleta = Path.GetFullPath(ruta_y_archivo);
                            Console.WriteLine("Ruta completa: " + rutaCompleta);
                            Console.ReadLine();
                        }
                        break;
                    case "5":
                        Console.WriteLine("Copiar archivo");
                        if (File.Exists(ruta_y_archivo))
                        {
                            string rutaCompleta = Path.GetFullPath(ruta_y_archivo);
                            Console.WriteLine("Ruta completa: " + rutaCompleta);
                            string copiar = "";
                            Console.WriteLine("Ingrese el nuevo nombre para su archivo {0}", ruta_y_archivo);
                            copiar = Console.ReadLine().ToUpper() + ".txt";
                            Console.ReadLine();

                            File.Copy(ruta_y_archivo, copiar,true); // origen, destino, sobreescribir
                            Console.WriteLine("archivo copiado {0} ", copiar);
                            Console.ReadLine();
                        }
                        break;
                    case "6":
                        Console.WriteLine("Borrar el Archivo");
                        if (File.Exists(ruta_y_archivo))
                        {
                            string rutaCompleta = Path.GetFullPath(ruta_y_archivo);
                            string borrar = "";
                            Console.WriteLine("Desea borrar SI o NO " + rutaCompleta);
                            borrar = Console.ReadLine().ToUpper();

                            switch (borrar)
                            {
                                case "SI":
                                    File.Delete(ruta_y_archivo);
                                    break;
                                case "NO":
                                    break;
                                default:
                                    Console.WriteLine("Opción no Válida, Presione cualquier tecla");
                                    Console.ReadLine();
                                    break;
                            }
                        }


                        break;
                    case "7":
                        Console.WriteLine("Buscar Archivo, para que funcione se modificó el archivo .csproj en la raiz del proyecto usando el file explorer");

                        OpenFileDialog ofd = new OpenFileDialog();

                        ofd.Title = "Selecciona un archivo";
                        ofd.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            ruta_y_archivo = ofd.FileName;

                            Console.WriteLine("Archivo seleccionado:");
                            Console.WriteLine(ruta_y_archivo);

                            // Leer contenido
                            string contenido = File.ReadAllText(ruta_y_archivo);
                            Console.WriteLine("\nContenido:\n" + contenido);
                        }
                        else
                        {
                            Console.WriteLine("No se seleccionó ningún archivo");
                        }

                        Console.ReadKey();



                        break;
                    case "X":
                        continuar = false;
                        break;
                }

            }
            while (continuar);
        
        }


        // este es un recuerdo de todo lo aprendido antes de ordenar el programa con un Switch
        // a veces sube a veces no sube

        static void sumas2()
        { }

        static void pruebas_de_todo()
        {
            if (!File.Exists("primer_archivo.txt"))     // busca en la ruta predeterminada del proyecto
            {
                //crea el archivo
                FileStream fs = new FileStream("primer_archivo.txt", FileMode.Create);  // crea el archivo
                Console.WriteLine("Archivo creado en C:\\pedrocalapi\\VScursoUdemy\\seccion11_archivos\\bin\\Debug\\net10.0\\primer_archivo.txt");
                fs.Close();
            }
            else
            {
                Console.WriteLine("Arhivo primer_archivo.txt ya existe en la ruta predeterminada, este es su contenido\n");
                Console.WriteLine(File.ReadAllText("primer_archivo.txt"));

                Console.WriteLine("Le agregaremos contenido\n Presione una tecla para continuar");
                Console.ReadLine();

                File.AppendAllText("primer_archivo.txt", "\nContenido agregado con FileAppendAllText..." + DateTime.Now);

                StreamWriter sw = new StreamWriter("primer_archivo.txt", true);    //true es para Append
                string texto_agregado = "\nNuevo texto agregado con StreamWriter sw.WriteLine(texto_agregado)...";
                sw.WriteLine(texto_agregado);
                sw.Close();
                Console.WriteLine("Nuevo contenido es");
                Console.WriteLine(File.ReadAllText("primer_archivo.txt"));

                Console.WriteLine("Ahora almacenamos su contenido en una variable");
                Console.ReadLine();
                string texto;
                StreamReader st = new StreamReader("primer_archivo.txt");
                texto = st.ReadLine();       // solo la primera línea
                Console.WriteLine($"el archivo contiene Readline: {texto}");
                Console.ReadLine();
                texto = st.ReadToEnd();       // lea todo
                Console.WriteLine($"el archivo contiene todo: {texto}");
                Console.ReadLine();
            }


            Console.WriteLine("Presione cualquier tecla para crear archivo_escritorio.txt en el escitorio");

            string contenido_archivo = "Mi Nombre Es Pedro";
            byte[] contenido_bytes = Encoding.UTF8.GetBytes(contenido_archivo);

            string ruta = @"C:\Users\pcalapi\OneDrive - Growflowers\Desktop\archivo_escritorio.txt";

            // crea el archivo con el contenido
            File.WriteAllBytes(ruta, contenido_bytes);

            Console.WriteLine("Archivo guardado correctamente, su contenido es");

            string lectura_archivo = File.ReadAllText(ruta, Encoding.UTF8);

            // Mostrar en consola
            Console.WriteLine(lectura_archivo);
            Console.ReadKey();

            // agregar contenido a un archivo
            string nuevo_contenido = "\nContenido agregado";
            File.AppendAllText(ruta, nuevo_contenido);
            lectura_archivo = File.ReadAllText(ruta, Encoding.UTF8);

            Console.WriteLine("Nuevo contenido");
            // Mostrar en consola
            Console.WriteLine(lectura_archivo);
            Console.ReadKey();
        }   // fin pruebas
    }   // program
}   // name space
