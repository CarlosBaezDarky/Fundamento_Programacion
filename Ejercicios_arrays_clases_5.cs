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

        static void ColorAmarillo(string color)
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine(color);

            Console.ForegroundColor = ConsoleColor.Gray;

        }

        static void PersonalizarVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Clear();

        }
        static void Main(string[] args)
        {
            PersonalizarVentana();

            string[] almacenDeNombres = new string[100];

            string nombres = "none";

            int contador = -1;

            bool condicionWhile = true;

            ColorAmarillo("A continuacion se le solicitara ingresar X cantidad de nombres.");

            ColorAmarillo("\nCuando ya no quiera ingresar nombres, solo pulse <Enter> sin teclear nada.");

            for (int i = 0; i <= 99; i++) 
            {

                ++contador;

                Console.Write("\nNombre" + "[" + i + "]: ");

                almacenDeNombres[i] = Console.ReadLine();

                condicionWhile = true;

                while (condicionWhile == true)
                {
                    nombres = almacenDeNombres[i];

                    int valorNumerico;

                    bool existo = int.TryParse(nombres, out valorNumerico);

                    if (existo)
                    {

                        Console.WriteLine("\nEsto no es un nombre " + nombres);

                        Console.Write("\nNombre" + "[" + i + "]: ");

                        almacenDeNombres[i] = Console.ReadLine();

                    }
                    else
                    {

                        condicionWhile = false;

                    }

                }

                if (almacenDeNombres[i] == "") 
                {

                    i = 100;
                
                }
            
            }

            for (int i = 0; i <= contador; i++) 
            {
                if (almacenDeNombres[i] == "")
                {


                }
                else
                {

                    ColorAmarillo("\nEstos son los nombres almacenados: " + almacenDeNombres[i]);

                }
            
            }

            Pausa.PausaFinPrograma();

        }
    }
}