namespace seccion07_clases_cuentabancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double montoAr=0, saldoInicialAr=0;
            int opcion;
            string nombreAr = ""; 
            string apellidosAr="", direccionAr = "", rfcAr = "";

            ////Aviso de nueva cuenta
            //Console.Write("Está a punto de crear una cuenta nueva, por favor presione cualquier tecla para continuar: ");
            //Console.ReadKey();

            //Console.WriteLine("\nIngrese la información que se le solicita a continuación: ");

            //Console.Write("\nNombre: ");
            //nombreAr = Console.ReadLine();

            //Console.Write("Apellidos: ");
            //apellidosAr = Console.ReadLine();

            //Console.Write("Dirección: ");
            //direccionAr = Console.ReadLine();

            //Console.Write("RFC: ");
            //rfcAr = Console.ReadLine();

            //Console.Write("Ingrese su deposito inicial: $");
            //saldoInicialAr = Convert.ToDouble(Console.ReadLine());

            //Instanciamos a la clase
            CuentaBancaria cliente1 = new CuentaBancaria(nombreAr, apellidosAr, saldoInicialAr, direccionAr, rfcAr);

            ////Mensaje de creación de cuenta
            //Console.WriteLine("Felicidades, su cuenta ha sido creada con exito, presione  cualquier tecla para continuar");
            //Console.ReadKey();

            //Menú
            do
            {
                Console.WriteLine("\n0. Crear Cuenta");
                Console.WriteLine("1. Deposito");
                Console.WriteLine("2. Retiro");
                Console.WriteLine("3. Consultar Saldo");
                Console.WriteLine("4. Mostrar Información de la cuenta");
                Console.WriteLine("5. Salir");

                Console.Write("\nElija una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("CREACION CUENTA BANCARA");                      
                        Console.WriteLine("Ingrese la información que se le solicita a continuación: ");

                        Console.Write("\nNombre: ");
                        nombreAr = Console.ReadLine().ToString();

                        Console.Write("Apellidos: ");
                        apellidosAr = Console.ReadLine().ToString();

                        Console.Write("Dirección: ");
                        direccionAr = Console.ReadLine().ToString();

                        Console.Write("RFC: ");
                        rfcAr = Console.ReadLine().ToString();

                        Console.Write("Ingrese su deposito inicial: $");
                        saldoInicialAr = Convert.ToDouble(Console.ReadLine());

                        //Asignar los valores ingresados
                        cliente1.Recrear(nombreAr, apellidosAr, saldoInicialAr, direccionAr, rfcAr);

                        // para usar estas instrucciones, los campos deben estar como public en la clase CuentaBancaria
                        //cliente1.rfc = rfcAr;
                        //cliente1.direccion = direccionAr;
                        //cliente1.nombre = nombreAr;
                        //cliente1.apellidos = apellidosAr;
                        //cliente1.saldo = saldoInicialAr;

                        Console.Clear();
                        ////Mensaje de creación de cuenta
                        Console.WriteLine("Felicidades, su cuenta ha sido creada con éxito");
                        Console.WriteLine(cliente1.ToString());
                        Console.WriteLine("\n\n\n");
                        break;
                    case 1:
                        Console.Write("Ingrese el monto a depositar: $");
                        montoAr = Convert.ToDouble(Console.ReadLine());

                        cliente1.Deposito(montoAr);
                        break;
                    case 2:
                        Console.Write("Ingrese el monto a retirar: $");
                        montoAr = Convert.ToDouble(Console.ReadLine());

                        cliente1.Retiro(montoAr);
                        break;
                    case 3:
                        cliente1.ConsultaSaldo();
                        break;
                    case 4:
                        Console.WriteLine(cliente1.ToString());
                        break;
                }


            } while (opcion >= 0 && opcion <= 4);
        }
    }

    class CuentaBancaria
    {
        //Campos
        private string nombre, apellidos, direccion, rfc;
        private double saldo;

        //Constructor
        public CuentaBancaria(string nombrePa, string apellidosPa, double saldoPa, string direccionPa, string rfcPa)
        {
            nombre = nombrePa;
            apellidos = apellidosPa;
            saldo = saldoPa;
            direccion = direccionPa;
            rfc = rfcPa;
        }

        public void Recrear(string nombrePa, string apellidosPa, double saldoPa, string direccionPa, string rfcPa)
        {
            nombre = nombrePa;
            apellidos = apellidosPa;
            saldo = saldoPa;
            direccion = direccionPa;
            rfc = rfcPa;
        }

        //Métodos
        public double Deposito(double montoPa)
        {
            saldo += montoPa;
            return saldo;
        }

        public double Retiro(double montoPa)
        {
            if (saldo >= montoPa)
            {
                saldo -= montoPa;
            }
            else
            {
                Console.WriteLine("¡Saldo insuficiente!");
            }
            return saldo;
        }

        public void ConsultaSaldo()
        {
            Console.WriteLine("Su saldo es: ${0}", saldo);
        }

        public override string ToString()
        {
            Console.WriteLine("Información de la cuenta");
            string mensaje;
            mensaje = "\nTitular: " + nombre + " " + apellidos + "\nRFC:" + rfc + "\nDirección: " + direccion + "\nSaldo: $" + saldo;

            return mensaje;
        }

    }
}
