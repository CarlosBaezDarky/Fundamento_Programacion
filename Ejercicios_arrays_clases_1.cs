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

            public static void PausaCalquierBoton() 
            {

                Console.WriteLine("\nPresione cualquier tecla para continuar.");

                Console.ReadKey();

            }

        }

        class Color
        {

            public static void ColorRojo(string color)
            {

                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine(color);

                Console.ForegroundColor = ConsoleColor.DarkGreen;

            }

            public static void ColorAmarillo(string color)
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.Write(color);

                Console.ForegroundColor = ConsoleColor.DarkGreen;

            }
        }


        static void PersonalizarVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.Clear();

        }
        static void Main(string[] args)
        {
            PersonalizarVentana();

            double[] almacenDeValores = new double[4] { 0, 0, 0, 0 };

            double acumulador = 0;

            double mediaAritmerica = 0;

            bool condicionWhile = true;

            Color.ColorRojo("A continuacion se le solicitara ingresar cuatro valores numericos y se mostrara la media aritmetica de dichos numeros.");

            Pausa.PausaCalquierBoton();

            for (int i = 0; i <= 3; i++) 
            {

                condicionWhile = true;

                while (condicionWhile == true)
                {
                    Console.Write("\nPosicion" + "[" + i + "]: ");

                    try
                    {

                        almacenDeValores[i] = double.Parse(Console.ReadLine());

                        condicionWhile = false;

                    }
                    catch (FormatException e)
                    { 
                    
                        almacenDeValores[i] = 0;

                    }
                    catch (OverflowException e)
                    {

                        almacenDeValores[i] = 0;

                    }
                }

            }

            for (int i = 0; i <= 3; i++)
            {

                acumulador = (acumulador + almacenDeValores[i]);

                mediaAritmerica = (acumulador / almacenDeValores.Length);

                if (i == 0)
                {

                    Console.Write("\nEstos son los valores introducidos por teclado: { ");

                }

                if (i <= 2)
                {

                    Color.ColorAmarillo(almacenDeValores[i] + ", ");

                }

                else 
                { 

                    Color.ColorAmarillo(almacenDeValores[i] + "");
                
                }

                if (i == 3)
                {

                  Console.WriteLine(" }");

                  Color.ColorRojo("\nLa media aritmetica es: " + mediaAritmerica);

                }

            }

            Pausa.PausaFinPrograma();

        }
    }
}