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

        static void ColorRojo(string color)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(color);

            Console.ForegroundColor = ConsoleColor.Magenta;

        }

        static void PersonalizarVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Clear();

        }
        static void Main(string[] args)
        {
            PersonalizarVentana();

            double[] almacenDeNumeros = new double[10];

            int contadorFijo = 0;

            int contador = -1;

            bool comparacion = true;

            bool condicionBucle = true;

            ColorRojo("A continuacion se le solicitara ingresar diez numeros y se le dira cual es el mayor de todos.");

            for (int i = 0; i <= 9; i++) 
            {

                while (condicionBucle == true)
                {

                    Console.Write("\nPosicion" + "[" + i + "]: ");

                    try
                    {

                        almacenDeNumeros[i] = double.Parse(Console.ReadLine());

                        condicionBucle = false;

                    }
                    catch (FormatException e)
                    {

                        almacenDeNumeros[i] = 0;

                    }
                    catch (OverflowException e)
                    {

                        almacenDeNumeros[i] = 0;

                    }
                }

            }

            while (condicionBucle == true) 
            {

                ++contador;

                comparacion = almacenDeNumeros[contadorFijo] > almacenDeNumeros[contador];

                if (comparacion == false) 
                {

                    contadorFijo = contador;
                
                }

                if (contador == 9) 
                {

                    condicionBucle = false;

                    ColorRojo("\nEl numero mayor es: " + almacenDeNumeros[contadorFijo]);
                
                }
            
            }

            Pausa.PausaFinPrograma();

        }
    }
}