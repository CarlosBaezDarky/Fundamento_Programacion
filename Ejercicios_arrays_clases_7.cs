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

            Console.Write(color);

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

            Console.WriteLine("A continuacion se le solicitara ingresar su nomnbre.");

            Console.Write("\nIngrese su nombre: ");

            string nombre = Console.ReadLine();

            //Ese WriteLine cumple el papel de espacio

            Console.WriteLine();

            for (int i = 0; i < nombre.Length; ++i)
            {

                ColorMorado(nombre[i] + " ");

            }

            //Ese WriteLine cumple el papel de espacio

            Console.WriteLine();

            Pausa.PausaFinPrograma();

        }
    }
}