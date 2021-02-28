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

        class Persona
        {

            public static void DatosPersonas(string nombre = "none") 
            {

                bool condicionBucle = true;

                byte edad = 0;

                condicionBucle = true;

                while (condicionBucle == true)
                {

                    Console.Write("\nIngrese su edad: ");

                    try
                    {

                        edad = byte.Parse(Console.ReadLine());

                        condicionBucle = false;

                    }
                    catch (FormatException e)
                    {

                        edad = 0;

                    }
                    catch (OverflowException e)
                    {

                        edad = 0;

                    }
                }

                if (edad >= 18)
                {

                    ColorMorado("\nSu nombre es " + nombre + " y tiene " + edad + " años, por lo tanto usted es mayor de edad.");

                }

                else
                {

                    ColorMorado("\nSu nombre es " + nombre + " y tiene " + edad + " años, por lo tanto usted es menor de edad.");

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

            string nombre = "none";

            Console.WriteLine("A continuacion se le solicitara ingresar su nombre y su edad.");

            Console.Write("\nIngrese su nombre: ");

            Persona.DatosPersonas(nombre = Console.ReadLine());

            Pausa.PausaFinPrograma();

        }
    }
}