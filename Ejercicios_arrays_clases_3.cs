using System;

namespace PRACTICAR
{
    class Program
    {
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

        static void TablaDeMeses() 
        {

            bool condicionBucle = true;

            while (condicionBucle == true)
            {

                Console.WriteLine(" __________________________ ");
                Console.WriteLine("|                          |");
                Console.WriteLine("|    < Meses del año >     |");
                Console.WriteLine("|__________________________|");
                Console.WriteLine("|                          |");
                Console.WriteLine("|1-> Enero                 |");
                Console.WriteLine("|2-> Febrero               |");
                Console.WriteLine("|3-> Marzo                 |");
                Console.WriteLine("|4-> Abril                 |");
                Console.WriteLine("|5-> Mayo                  |");
                Console.WriteLine("|6-> Junio                 |");
                Console.WriteLine("|7-> Julio                 |");
                Console.WriteLine("|8-> Agosto                |");
                Console.WriteLine("|9-> Septiembre            |");
                Console.WriteLine("|10-> Octubre              |");
                Console.WriteLine("|11-> Noviembre            |");
                Console.WriteLine("|12-> Diciembre            |");
                Console.WriteLine("|13-> Salir                |");
                Console.WriteLine("|__________________________|");

                condicionBucle = false;

            }

        }

        static void ColorRojo(string color)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(color);

            Console.ForegroundColor = ConsoleColor.Magenta;

        }

        static void PersonalizarVentana()
        {

            Console.SetWindowSize(80, 25);

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Clear();

        }
        static void Main(string[] args)
        {
            PersonalizarVentana();

            int mes = 0;

            bool condicionWhile = true;

            bool condicionBucle = true;

            string[] meses = new string[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            int[] cantidadDeDiasPorMes = new int[13];

            cantidadDeDiasPorMes[0] = 0;

            for (int i = 1; i <= 12; i++) 
            {

                if (i <= 7)
                {

                    if (i == 2)
                    {

                        cantidadDeDiasPorMes[i] = 28;

                    }

                    else if ((i % 2) == 0)
                    { 

                            cantidadDeDiasPorMes[i] = 30;

                    }

                    else 
                    {

                        cantidadDeDiasPorMes[i] = 31;
                    
                    }


                }

                else 
                {

                    if ((i % 2) == 1)
                    {

                        cantidadDeDiasPorMes[i] = 30;

                    }

                    else 
                    {

                        cantidadDeDiasPorMes[i] = 31;

                    }

                }

            }

            while (condicionWhile == true)
            {

                TablaDeMeses();

                condicionBucle = true;

                while (condicionBucle == true)
                {

                    Console.Write("\nSeleccione un mes: ");

                    try
                    {

                        mes = int.Parse(Console.ReadLine());

                        condicionBucle = false;

                    }
                    catch (FormatException e)
                    {

                        mes = 0;

                    }
                    catch (OverflowException e)
                    {

                        mes = 0;

                    }
                }

                switch (mes)
                {

                    case 1:

                        ColorRojo("\nEl mes de " + meses[0] + " tiene " + cantidadDeDiasPorMes[1] + " dias.");

                        break;

                    case 2:

                        ColorRojo("\nEl mes de " + meses[1] + " tiene " + cantidadDeDiasPorMes[2] + " dias.");

                        break;

                    case 3:

                        ColorRojo("\nEl mes de " + meses[2] + " tiene " + cantidadDeDiasPorMes[3] + " dias.");

                        break;

                    case 4:

                        ColorRojo("\nEl mes de " + meses[3] + " tiene " + cantidadDeDiasPorMes[4] + " dias.");

                        break;

                    case 5:

                        ColorRojo("\nEl mes de " + meses[4] + " tiene " + cantidadDeDiasPorMes[5] + " dias.");

                        break;

                    case 6:

                        ColorRojo("\nEl mes de " + meses[5] + " tiene " + cantidadDeDiasPorMes[6] + " dias.");

                        break;

                    case 7:

                        ColorRojo("\nEl mes de " + meses[6] + " tiene " + cantidadDeDiasPorMes[7] + " dias.");

                        break;

                    case 8:

                        ColorRojo("\nEl mes de " + meses[7] + " tiene " + cantidadDeDiasPorMes[8] + " dias.");

                        break;

                    case 9:

                        ColorRojo("\nEl mes de " + meses[8] + " tiene " + cantidadDeDiasPorMes[9] + " dias.");

                        break;

                    case 10:

                        ColorRojo("\nEl mes de " + meses[9] + " tiene " + cantidadDeDiasPorMes[10] + " dias.");

                        break;

                    case 11:

                        ColorRojo("\nEl mes de " + meses[10] + " tiene " + cantidadDeDiasPorMes[11] + " dias.");

                        break;

                    case 12:

                        ColorRojo("\nEl mes de " + meses[11] + " tiene " + cantidadDeDiasPorMes[12] + " dias.");

                        break;

                    case 13:

                        condicionWhile = false;

                        break;
						
					default :
						 
                        break;

                }

                if (mes != 13)
                {

                    Pausa.PausaLimpiarPantalla();

                }

            }

            Pausa.PausaFinPrograma();

        }
    }
}