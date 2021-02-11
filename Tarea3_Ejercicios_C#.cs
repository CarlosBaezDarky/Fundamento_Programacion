/*Saludos

Nombre: Carlos Eduardo Báez Méndez

Matricula: 202010160

Materia: Fundamento de programación

Grupo: #10

Ejercicios en C#*/

/*Crear un programa que pida números positivos al usuario, y vaya calculando la suma de todos ellos (
terminará cuando se teclea un número negativo o cero).*/

using System;
using System.Threading;

namespace PRACTICA_1_
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

                Console.Write("Fin programa.");

                Thread.Sleep(1500);

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

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Clear();
        
        }

        static void Main(string[] args)
        {

            PersonalizarVentana();

            double variableNumero = 0;

            int contador1 = 0;

            int contador2 = 0;

            bool condicionWhile = true;

            bool evaluacionVariableNumero = true;

            double suma = 0;

            Console.WriteLine("A continuacion se le solicitara insertar numeros positivos. En caso de querer finalizar el programa inserte un numero igual o menor a 0.");

            Console.WriteLine("\nNota: si introduce un numero muy elevado o muy pequeñito el programa le dara el resultado en notacion E. Donde E es igual a multiplicar un numero por 10 elevado a un numero. " +
                "\n\nEj: (6 x 10^ 23 = 6E+23.)");

            while (condicionWhile == true) 
            {
                evaluacionVariableNumero = true;

                while (evaluacionVariableNumero == true)
                {

                    Console.Write("\nIngrese un numero positivo: ");

                    try
                    {

                        variableNumero = double.Parse(Console.ReadLine());

                        evaluacionVariableNumero = false;

                    }
                    catch (FormatException e)
                    {

                        variableNumero = 0;

                    }
                    catch (OverflowException e)
                    {

                        variableNumero = 0;

                    }

                    contador1++;

                    if (contador1 == 5)
                    {

                        Console.Clear();

                        Console.WriteLine("A continuacion se le solicitara insertar numeros positivos. En caso de querer finalizar el programa inserte un numero igual o menor a 0.");

                        Console.WriteLine("\nNota: si introduce un numero muy elevado o muy pequeñito el programa le dara el resultado en notacion E. Donde E es igual a multiplicar un numero por 10 elevado a un numero. " +
                        "\n\nEj: (6 x 10^ 23 = 6E+23.)");

                        contador1 = 0;

                    }

                }

                if (variableNumero <= 0) 
                {

                    condicionWhile = false;
                
                }

                if (variableNumero > 0) 
                {

                    suma = (suma + variableNumero);

                    Console.WriteLine("\nLa suma de los numeros ingresados es: " + suma);

                }

                contador2++;

                if (contador2 == 5)
                {

                    Console.Clear();

                    Console.WriteLine("A continuacion se le solicitara insertar numeros positivos. En caso de querer finalizar el programa inserte un numero igual o menor a 0.");

                    Console.WriteLine("\nNota: si introduce un numero muy elevado o muy pequeñito el programa le dara el resultado en notacion E. Donde E es igual a multiplicar un numero por 10 elevado a un numero. " +
                        "\n\nEj: (6 x 10^ 23 = 6E+23.)");

                    Console.WriteLine("\nLa suma de los numeros ingresados es: " + suma);

                    contador2 = 0;

                }

            }

            Pausa.PausaLimpiarPantalla();

            Console.WriteLine("La suma de los numeros ingresados es: " + suma);

            Pausa.PausaFinPrograma();

        }
    }
}

/*Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while".*/

using System;
using System.Threading;

namespace PRACTICA_1_
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

                Console.Write("Fin programa.");

                Thread.Sleep(1500);

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

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Clear();
        
        }

        static void Main(string[] args)
        {

            PersonalizarVentana();

            byte contador = 0;

            Console.WriteLine("A continuacion este programa mostrara los numeros del 1 al 10.");

            do
            {

                if (contador == 0) 
                {

                    Console.Write("\nN = {");

                }

                contador++;

                if (contador == 10)
                {

                    Console.WriteLine(contador + ",..., n-1, n}");

                }
                else 
                {

                    Console.Write(contador + ", ");

                }
            
            } while (contador <= 9);

            Pausa.PausaFinPrograma();

        }
    }
}

/*Crear un programa que muestre los primeros 10 números pares a partir del producto 
de (10 x 10).*/

using System;
using System.Threading;

namespace PRACTICA_1_
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

                Console.Write("Fin programa.");

                Thread.Sleep(1500);

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

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Clear();
        
        }

        static void Main(string[] args)
        {

            PersonalizarVentana();

            byte numerosPares = (10 * 10);

            byte contador = 0;

            Console.WriteLine("A continuacion este programa mostrara los primeros 10 números pares a partir del producto de (10 x 10).");

            do
            {
                

                    if (contador == 0)
                    {

                        Console.Write("\nN = {");

                    }

                    if ((numerosPares % 2) == 0)
                    {

                        Console.Write(numerosPares + ", ");

                        contador++;

                        //Console.WriteLine(contador);

                    }
                

                 if (contador == 10) 
                {

                    Console.WriteLine("..., n-1, n}");

                }

                numerosPares++;

            } while (contador <= 9);

            Pausa.PausaFinPrograma();

        }
    }
}

//Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo).

using System;
using System.Threading;

namespace PRACTICA_1_
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

                Console.Write("Fin programa.");

                Thread.Sleep(1500);

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

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Clear();
        
        }

        static void Main(string[] args)
        {

            PersonalizarVentana();

            byte ascii = 91;

            char letra = 'n';

            bool condicionWhile = true;

            Console.WriteLine("A continuacion este programa mostrara las letras de la Z (mayúscula) a la A (mayúscula, descendiendo).");

            while (condicionWhile == true) 
            {

                if (ascii == 91) 
                {

                    Console.Write("\n" + "{");

                }

                ascii--;

                letra = (char)ascii;

                if (ascii != 65)
                {

                    Console.Write(letra + ", ");

                }
                else 
                {

                    Console.WriteLine(letra + "}");

                    condicionWhile = false;

                }

            }

            Pausa.PausaFinPrograma();

        }
    }
}

