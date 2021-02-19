/*

Nombre: Carlos Eduardo Baez Mendez

Matricula: 202010160

Grupo: #15

Materia: Fundamento del computador

*/
using System;

namespace PRACTICA_1_
{
    class Program
    {

        class Pausa
        {
            public static void PausaFinPrograma()
            {

                Console.WriteLine("Presione cualquier tecla para finalizar el programa.");

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

        static void PersonalizarVentana() 
        {

            Console.SetWindowSize(80, 20);

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Clear();
        
        }

        class Tablas 
        {

            public static void Menu() 
            {

                bool condicionBucle = true;

                while (condicionBucle == true) 
                {

                    Console.WriteLine(" __________________________ ");
                    Console.WriteLine("|                          |");
                    Console.WriteLine("| < Bienvenido al Cajero > |");
                    Console.WriteLine("|__________________________|");
                    Console.WriteLine("|                          |");
                    Console.WriteLine("|1-> RETIRAR               |");
                    Console.WriteLine("|2-> TRANSCCION            |");
                    Console.WriteLine("|3-> SALIR                 |");
                    Console.WriteLine("|__________________________|");

                    Console.Write("\n¿Qué desea hacer? ");

                    condicionBucle = false;

                }
            
            }

            public static void Bancos()
            {

                bool condicionBucle = true;

                while (condicionBucle == true)
                {

                    Console.WriteLine(" __________________________ ");
                    Console.WriteLine("|                          |");
                    Console.WriteLine("|  < Bancos disponibles >  |");
                    Console.WriteLine("|__________________________|");
                    Console.WriteLine("|                          |");
                    Console.WriteLine("|1-> FDP INVERSMENTS       |");
                    Console.WriteLine("|2-> BANCO POPULAR         |");
                    Console.WriteLine("|3-> SCOTIABANK            |");
                    Console.WriteLine("|(x >= 4)-> RETROCEDER     |");
                    Console.WriteLine("|__________________________|");

                    Console.Write("\nSeleccione un <Banco>: ");

                    condicionBucle = false;

                }

            }

        }

        static void DevueltaBillete(double billete) 
        {

            double a;

            double b;

            int c;

            double d;

            double d1 = 0.09999999999999964;

            double d2 = 0.1999999999999993;

            double d3 = 0.3000000000000007;

            double d4 = 0.40000000000000036;

            double d5 = -0.5;

            double d6 = 0.10000000000000142;

            double d7 = 0.3999999999999986;

            a = (billete / 1000);

            c = Convert.ToInt32(billete / 1000);

            d = (a - c);

            Console.WriteLine(d);

            if (a >= 18.1)
            {

                if (d == 0)
                {

                    if (a == 20)
                    {

                        Console.WriteLine("\nDevuelta: 18 billetes de mil y 4 de 500.");

                    }

                    else
                    {

                        Console.WriteLine("\nDevuelta: 18 billetes de mil y dos de 500.");


                    }

                }

                else if (d <= 0.009)

                {

                    Console.WriteLine("\nNo hay devuelta para ese monto. Retire otro.");


                }

                else if (d <= 0.09)

                {

                    Console.WriteLine("\nNo hay devuelta para ese monto. Retire otro.");


                }

                else if (a >= 16.1)
                {

                    if (d == d6)
                    {

                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil y 1 de 100.");

                    }

                    else if (d == d2)
                    {
                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil y 1 de 200.");

                    }

                    else if (d == d3)
                    {
                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 1 de 100 y 1 de 200.");

                    }

                    else if (d == d7)
                    {
                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil y 2 de 200.");

                    }

                    else if (d == -d5)
                    {
                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil y 1 de 500.");

                    }

                    else if (d == -d7)
                    {
                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 1 de 100 y 1 de 500.");

                    }

                    else if (d == -d3)
                    {
                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 1 de 200 y 1 de 500.");

                    }

                    else if (d == -d2)
                    {
                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 1 de 100, 1 de 200 y 1 de 500.");

                    }

                    else if (d == -d6)
                    {
                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 2 de 200 y 1 de 500.");

                    }

                }


            }

            else if (a >= 1)
            {


                if (d == 0)
                {

                    for (int y = 1; y <= 18; ++y)

                    {

                        if (c == y)
                        {

                            Console.WriteLine("\nDevuelta: " + y + " billetes de mil.");

                        }

                    }

                }

                else if (d <= 0.009)

                {

                    Console.WriteLine("\nNo hay devuelta para ese monto. Retire otro.");


                }

                else if (d <= 0.09)

                {

                    Console.WriteLine("\nNo hay devuelta para ese monto. Retire otro.");


                }

                else if (a >= 16.1)
                {

                    if (d == d1)
                    {

                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil y 1 de 100.");

                    }

                    else if (d == d2)
                    {
                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil y 1 de 200.");

                    }

                    else if (d == d3)
                    {
                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 1 de 100 y 1 de 200.");

                    }

                    else if (d == d7)
                    {
                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil y 2 de 200.");

                    }

                    else if (d == -d5)
                    {
                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil y 1 de 500.");

                    }

                    else if (d == -d7)
                    {
                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 1 de 100 y 1 de 500.");

                    }

                    else if (d == -d3)
                    {
                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 1 de 200 y 1 de 500.");

                    }

                    else if (d == -d2)
                    {
                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 1 de 100, 1 de 200 y 1 de 500.");

                    }

                    else if (d == -d1)
                    {
                        Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 2 de 200 y 1 de 500.");

                    }

                }

            }

            else if (a >= 17.1)
            {

                if (d == d6)
                {

                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil y 1 de 100.");

                }

                else if (d == d2)
                {
                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil y 1 de 200.");

                }

                else if (d == d3)
                {
                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 1 de 100 y 1 de 200.");

                }

                else if (d == d7)
                {
                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil y 2 de 200.");

                }

                else if (d == -d5)
                {
                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil y 1 de 500.");

                }

                else if (d == -d7)
                {
                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 1 de 100 y 1 de 500.");

                }

                else if (d == -d3)
                {
                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 1 de 200 y 1 de 500.");

                }

                else if (d == -d2)
                {
                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 1 de 100, 1 de 200 y 1 de 500.");

                }

                else if (d == -d6)
                {
                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 2 de 200 y 1 de 500.");

                }

            }

            else if (a >= 0)
            {

                if (d == d1)
                {

                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil y 1 de 100.");

                }

                else if (d == d2)
                {
                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil y 1 de 200.");

                }

                else if (d == d3)
                {
                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 1 de 100 y 1 de 200.");

                }

                else if (d == d4)
                {
                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil y 2 de 200.");

                }

                else if (d == d5)
                {
                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil y 1 de 500.");

                }

                else if (d == -d4)
                {
                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 1 de 100 y 1 de 500.");

                }

                else if (d == -d3)
                {
                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 1 de 200 y 1 de 500.");

                }

                else if (d == -d2)
                {
                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 1 de 100, 1 de 200 y 1 de 500.");

                }

                else if (d == -d1)
                {
                    Console.WriteLine("\nDevuelta: " + c + " billetes de mil, 2 de 200 y 1 de 500.");

                }

            }
         

            else
            {

                if (d <= 0.009)

                {

                    Console.WriteLine("\nNo hay devuelta para ese monto. Retire otro.");


                }

                else if (d <= 0.09)

                {

                    Console.WriteLine("\nNo hay devuelta para ese monto. Retire otro.");


                }

                else
                {

                    if (d == 0.1)
                    {
                        Console.WriteLine("\nDevuelta: un billete de 100.");

                    }

                    else if (d == 0.2)
                    {
                        Console.WriteLine("\nDevuelta: un billete de 200.");

                    }

                    else if (d == 0.3)
                    {
                        Console.WriteLine("\nDevuelta: un billete de 100 y uno de 200.");

                    }

                    else if (d == 0.4)
                    {
                        Console.WriteLine("\nDevuelta: dos billetes de 200.");

                    }

                    else if (d == 0.5)
                    {
                        Console.WriteLine("\nDevuelta: un billete de 500.");

                    }

                    else if (d == 0.6)
                    {
                        Console.WriteLine("\nDevuelta: un billete de 100 y uno de 500.");

                    }

                    else if (d == 0.7)
                    {
                        Console.WriteLine("\nDevuelta: un billete de 200 y uno de 500.");

                    }

                    else if (d == 0.8)
                    {
                        Console.WriteLine("\nDevuelta: un billete de 100, uno de 200 y otro de 500.");

                    }

                    else if (d == 0.9)
                    {
                        Console.WriteLine("\nDevuelta: dos billetes de 200 y uno de 500.");

                    }

                }

            }

        }

        static void Retirar() 
        {

            int eleccionBanco = 0;

            double monto = 0;

            double montoMaximo = 20000.00;

            bool condicion = true;

            Tablas.Bancos();

            while (condicion == true)
            {
                try
                {

                    eleccionBanco = int.Parse(Console.ReadLine());

                    condicion = false;

                }
                catch
                {

                    eleccionBanco = 0;

                }

                if (condicion == true)
                {

                    Console.Write("\nSeleccione un <Banco>: ");

                }

            }

            if (eleccionBanco <= 4)
            {
                if (eleccionBanco != 4)
                {

                    if (eleccionBanco == 1)
                    {

                        Console.WriteLine("\nEl monto maximo para retirar es: < " + montoMaximo + " >.");

                    }

                    else
                    {

                        Console.WriteLine("\nEl monto maximo para retirar es: < " + montoMaximo + " >.");

                    }

                    Console.Write("\n¿Qué cantidad desea retirar? ");

                    condicion = true;

                    while (condicion == true)
                    {
                        try
                        {

                            monto = double.Parse(Console.ReadLine());

                            condicion = false;

                        }
                        catch
                        {

                            monto = 0;

                        }

                        if (condicion == true) 
                        {

                            Console.Write("\n¿Qué cantidad desea retirar? ");

                        }

                    }

                    if (monto > montoMaximo)
                    {

                        while (monto > montoMaximo)
                        {
                            Console.Write("\nSu monto excede el monto maximo. Por favor coloque otra cantidad: ");

                            try
                            {

                                monto = double.Parse(Console.ReadLine());


                            }
                            catch
                            {

                                monto = 0;

                            }

                        }

                    }

                    DevueltaBillete(monto);
                }

            }

                Pausa.PausaLimpiarPantalla();
            
        }

        static void Transaccion()
        {

            int eleccionBanco = 0;

            double monto = 0.00;

            double montoMaximo = 10000.00;

            bool condicion = true;

            Tablas.Bancos();

            while (condicion == true)
            {
                try
                {

                    eleccionBanco = int.Parse(Console.ReadLine());

                    condicion = false;

                }
                catch
                {

                    eleccionBanco = 0;

                }

                if (condicion == true)
                {

                    Console.Write("\nSeleccione un <Banco>: ");

                }

            }

            if (eleccionBanco <= 4)
            {
                if (eleccionBanco != 4)
                {

                    if (eleccionBanco == 1)
                    {

                        Console.WriteLine("\nEl monto maximo a transferir es: < " + montoMaximo + " >.");

                    }

                    else
                    {

                        Console.WriteLine("\nEl monto maximo a transferir es: < " + montoMaximo + " >.");

                    }

                    Console.Write("\n¿Qué cantidad desea transferir? ");

                    condicion = true;

                    while (condicion == true)
                    {
                        try
                        {

                            monto = double.Parse(Console.ReadLine());

                            condicion = false;

                        }
                        catch
                        {

                            monto = 0;

                        }

                        if (condicion == true)
                        {

                            Console.Write("\n¿Qué cantidad desea transferir? ");

                        }

                    }

                    if (monto > montoMaximo)
                    {

                        while (monto > montoMaximo)
                        {
                            Console.Write("\nSu monto excede el monto maximo. Por favor coloque otra cantidad: ");

                            try
                            {

                                monto = double.Parse(Console.ReadLine());

                            }
                            catch
                            {

                                monto = 0;

                            }

                        }

                    }

                    Console.WriteLine("\nTransaccion existosa.");

                }

            }

            Pausa.PausaLimpiarPantalla();
        }

        static void Main(string[] args)
        {
       
            PersonalizarVentana();

            int opcion = 0;

            bool condicionWhile = true;

            while (condicionWhile == true) 
            {

                Tablas.Menu();

                try
                {
                    opcion = int.Parse(Console.ReadLine());
                }
                catch
                {

                    opcion = 0;

                }

                Pausa.PausaLimpiarPantalla();

                switch (opcion) 
                {

                    case 1:

                        Retirar();

                        break;

                    case 2:

                        Transaccion();

                        break;

                    case 3:

                        condicionWhile = false;

                        break;

                    default:
                        break;

                }
            
            }

           Pausa.PausaFinPrograma();

        }
    }
}