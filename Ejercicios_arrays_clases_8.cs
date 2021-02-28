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

            float[] almacenDeAlturas = new float[5];

            float altura = 0;

            float suma = 0;

            float promedio = 0;

            int contador = 0;

            int contador2 = 0;

            bool condicionBucle = true;

            Console.WriteLine("A continuacion se le solicitara ingresar X cantidad de alturas en cm.");

            for (int i = 0; i <= 4; i++)
            {

                condicionBucle = true;

                while (condicionBucle == true)
                {

                    Console.Write("\nAltura [" + i + "]: ");

                    try
                    {

                        altura = float.Parse(Console.ReadLine());

                        condicionBucle = false;

                    }
                    catch (FormatException e)
                    {

                        altura = 0;

                    }
                    catch (OverflowException e)
                    {

                        altura = 0;

                    }
                }

                almacenDeAlturas[i] = altura;

                suma += altura;

            }

            promedio = (suma / almacenDeAlturas.Length);

            for (int i = 0; i <= 4; i++)
            {

                if (almacenDeAlturas[i] > promedio)
                {

                    ++contador;

                }

                else
                {

                    ++contador2;

                }

            }

            ColorMorado("\nHay " + contador + " personas con altura por encima del promedio "+ promedio);

            ColorMorado("\nHay " + contador2 + " personas con altura por debajo del promedio " + promedio);

            Pausa.PausaFinPrograma();

        }
    }
}