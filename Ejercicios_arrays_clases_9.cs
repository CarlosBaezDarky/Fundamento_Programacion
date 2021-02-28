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

        class ValoresEnteros 
        {

            public static void TablaDeMultiplicar(int factorA) 
            {

                int factorB = 0;


                    for (int i = 1; i <= 12; i++)
                    {

                        factorB = (factorA * i);

                        ColorMorado("\n" + factorA + " por " + i + " es igual a " + factorB);

                    }
            
            }
        
        }

        static void ColorMorado(string color)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine(color);

            Console.ForegroundColor = ConsoleColor.DarkCyan;

        }

        static void PersonalizarVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.Clear();

        }
        static void Main(string[] args)
        {
            PersonalizarVentana();

            bool condicionBucle = true;

            bool condicionWhile = true;

            int numeroX = 0;

            while (condicionWhile == true)
            {
                Console.WriteLine("A continuacion se le solicitara ingresar un numero X del cual le mostraremos la tabla de multiplos (1 al 12).");

                Console.WriteLine("\nNota: Para finalizar el programa ingrese el numero < -1 >.");

                condicionBucle = true;

                while (condicionBucle == true)
                {

                    Console.Write("\nIngrese un numero X: ");

                    try
                    {

                        numeroX = int.Parse(Console.ReadLine());

                        condicionBucle = false;

                    }
                    catch (FormatException e)
                    {

                        numeroX = 0;

                    }
                    catch (OverflowException e)
                    {

                        numeroX = 0;

                    }
                }

                if (numeroX != -1)
                {

                    ValoresEnteros.TablaDeMultiplicar(numeroX);

                    Pausa.PausaLimpiarPantalla();

                }
                else
                {

                    condicionWhile = false;

                }

            }

            Pausa.PausaFinPrograma();

        }
    }
}