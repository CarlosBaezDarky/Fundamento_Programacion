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

            double[] almacenDeValores = new double[5] { 0, 0, 0, 0, 0 };

            int contador = 6;

            bool condicionWhile = true;

            Color.ColorRojo("A continuacion se le solicitara ingresar cuatro valores numericos y se mostrara la media aritmetica de dichos numeros.");

            Pausa.PausaCalquierBoton();

            for (int i = 0; i <= 4; i++) 
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

            for (int i = 0; i <= 5; i++)
            {
                contador = (contador - 1);

                if (i == 0)
                {

                    Console.Write("\nEstos son los valores introducidos por teclado con el orden invertido: { ");

                }

                else if (i <= 4)
                {

                    Color.ColorAmarillo(almacenDeValores[contador] + ", ");

                }

                else if (i == 5) 
                { 

                    Color.ColorAmarillo(almacenDeValores[contador] + "");

                    Console.WriteLine(" }");

                }

            }

            Pausa.PausaFinPrograma();

        }
    }
}