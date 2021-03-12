using System;

namespace PRACTICAR
{
    class Program
    {
        static void PersonalizarVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Clear();

        }
        class Pausa
        {
            public static void PausaFinPrograma()
            {

                Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.");

                Console.ReadKey();

                Console.Clear();

            }

            public static void PausaLimpiarPantalla()
            {

                Console.WriteLine("\nPresione cualquier tecla para continuar.");

                Console.ReadKey();

                Console.Clear();

            }

        }

        class ClienteBanco 
        {

            public static string nombreCliente;

            public static double montoCliente;

            public static double montoBanco = 100000;

            public static void MenuCliente()
            {
                bool condicionBucle = true;

                while (condicionBucle == true)
                {

                    Console.WriteLine(" __________________________ ");
                    Console.WriteLine("|                          |");
                    Console.WriteLine("|       < Clientes >       |");
                    Console.WriteLine("|__________________________|");
                    Console.WriteLine("|                          |");
                    Console.WriteLine("|1-> Pedro Santana         |");
                    Console.WriteLine("|2-> Carlos Mendez         |");
                    Console.WriteLine("|3-> Hector Gonzales       |");
                    Console.WriteLine("|__________________________|");

                    condicionBucle = false;

                }

            }

            public struct DatosClientes
            {

                public string nombre;

                public double monto;

                public int cedula;

            
            }

            public static void MostrarDatosCliente()
            {

                bool condicionBucle = true;

                int seleccionCliente = 0;

                DatosClientes[] clientes = new DatosClientes[4];

                clientes[1].nombre = "Pedro Santana";
                clientes[1].monto = 20000.00;
                clientes[1].cedula = 1;

                clientes[2].nombre = "Carlos Mendez";
                clientes[2].monto = 100000;
                clientes[2].cedula = 2;

                clientes[3].nombre = "Hector Gonzales";
                clientes[3].monto = 50000;
                clientes[3].cedula = 3;


                while (condicionBucle == true)
                {

                    Console.Write("\nSeleccione un cliente: ");

                    try
                    {

                        seleccionCliente = int.Parse(Console.ReadLine());

                    }
                    catch
                    {

                        seleccionCliente = 0;

                    }

                    if (seleccionCliente > 0)
                    {

                        if (seleccionCliente <= 3)
                        {

                            condicionBucle = false;

                        }

                    }
                    

                }

                Console.WriteLine("\nSaludos cliente " + clientes[seleccionCliente].nombre + ", su monto actual es de " + clientes[seleccionCliente].monto + " pesos y el numero de su cedula es " + clientes[seleccionCliente].cedula + ".");

                 nombreCliente = clientes[seleccionCliente].nombre;

                 montoCliente = clientes[seleccionCliente].monto;

            }


            public static void MenuOpcionesBanco()
            {
                bool condicionBucle = true;

                while (condicionBucle == true)
                {

                    Console.WriteLine("\nSeñor " + nombreCliente + ", su monto es de " + montoCliente + " pesos.");

                    Console.WriteLine(" __________________________ ");
                    Console.WriteLine("|                          |");
                    Console.WriteLine("|         < Banco >        |");
                    Console.WriteLine("|__________________________|");
                    Console.WriteLine("|                          |");
                    Console.WriteLine("|1-> Retir                 |");
                    Console.WriteLine("|2-> Depositar             |");
                    Console.WriteLine("|3-> Volver atras          |");
                    Console.WriteLine("|4-> Finalizar Programa    |");
                    Console.WriteLine("|__________________________|");

                    condicionBucle = false;

                }

            }

            public static void Retiar(double retiro)
            {

                if (retiro > montoBanco)
                {

                    Console.WriteLine("\nEl monto a retirar excede la capacidad del Banco.");

                }

                else if (retiro <= montoBanco)
                {

                    Console.WriteLine("\nHa retirado con existo su monto.");

                    montoBanco = montoBanco - retiro;

                    montoCliente = montoCliente + retiro;

                }

            }

            public static void Depositar(double deposito) 
            {

                if (deposito > montoCliente)
                {

                    Console.WriteLine("\nEl monto a depositar excede la capacidad de su monto.");

                }

                else
                {

                    Console.WriteLine("\nHa depositado con existo.");

                    montoBanco = montoBanco + deposito;

                    montoCliente = montoCliente - deposito;

                }

            }

            public static void DepositoBanco() 
            {

                Console.WriteLine("\nEsta es la cantidad de pesos residentes en el Banco al final del día: "+ montoBanco + ".");
            
            }

        }

        static void Main(string[] args)
        {
            PersonalizarVentana();

            bool condicionWhilePrincipal = true;

            bool condicionWhileSecundario = true;

            bool condicionBucle = true;

            bool condicionBucleSwitch = true;

            byte seleccionOpciones = 0;

            double cantidadRetiroDeposito = -1;

            while (condicionWhilePrincipal == true)
            {

                ClienteBanco.MenuCliente();

                ClienteBanco.MostrarDatosCliente();

                Pausa.PausaLimpiarPantalla();

                condicionWhilePrincipal = false;

                condicionWhileSecundario = true;

                while (condicionWhileSecundario == true)
                {

                    condicionBucleSwitch = true;

                    condicionBucle = true;

                    ClienteBanco.MenuOpcionesBanco();

                    while (condicionBucle == true)
                    {

                        Console.Write("\n¿Que desea hacer? ");

                        try
                        {

                            seleccionOpciones = byte.Parse(Console.ReadLine());

                            condicionBucle = false;

                        }

                        catch (FormatException)
                        {

                            seleccionOpciones = 0;

                        }

                        catch (OverflowException)
                        {

                            seleccionOpciones = 0;

                        }


                    }

                    switch (seleccionOpciones)
                    {

                        case 1:

                            while (condicionBucleSwitch == true)
                            {

                                Console.Write("\nColoque la cantidad a retirar: ");

                                try
                                {

                                    cantidadRetiroDeposito = double.Parse(Console.ReadLine());

                                    if (cantidadRetiroDeposito >= 0) 
                                    {

                                        condicionBucleSwitch = false;
                                    
                                    }

                                }

                                catch (FormatException)
                                {

                                    cantidadRetiroDeposito = -1;

                                }

                                catch (OverflowException)
                                {

                                    cantidadRetiroDeposito = -1;

                                }

                            }

                            ClienteBanco.Retiar(cantidadRetiroDeposito);

                            break;

                        case 2:

                            while (condicionBucleSwitch == true)
                            {

                                Console.Write("\nColoque la cantidad a depositar: ");

                                try
                                {

                                    cantidadRetiroDeposito = double.Parse(Console.ReadLine());

                                    if (cantidadRetiroDeposito >= 0)
                                    {

                                        condicionBucleSwitch = false;

                                    }

                                }

                                catch (FormatException)
                                {

                                    cantidadRetiroDeposito = -1;

                                }

                                catch (OverflowException)
                                {

                                    cantidadRetiroDeposito = -1;

                                }

                            }

                            ClienteBanco.Depositar(cantidadRetiroDeposito);

                            break;

                        case 3:

                            condicionWhilePrincipal = true;

                            condicionWhileSecundario = false;

                            break;

                        case 4:

                            condicionWhileSecundario = false;

                            break;

                        default:

                            break;

                    }

                    if (seleccionOpciones != 4)

                    {

                        Pausa.PausaLimpiarPantalla();

                    }

                }

            }

            ClienteBanco.DepositoBanco();

            Pausa.PausaFinPrograma();

        }
    }
}