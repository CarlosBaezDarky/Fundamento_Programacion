using System;

namespace Practica_06_ClasesConstructorHerencia_3_
{
    class Program
    {
        //Ajusta el ancho y el alto de la ventana de la consola y cambia el color del texto a Cyan
        static void personalizarVentana() 
        {

            Console.SetWindowSize(80, 25);

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.Clear();
        
        }

        //Imprime el texto en color morado
        static void colorMorado(string morado) 
        {

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine(morado);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
        
        }

        class ClaseA
        {

            public ClaseA() 
            {

                colorMorado("\nConstructor de la ClaseA.");

            }
        
        }

        class ClaseB 
        {

            ClaseA B = new ClaseA();

            public ClaseB() 
            {

                colorMorado("\nConstructor de la ClaseB.");
            
            }

        }

        class ClaseC 
        {

            ClaseB C = new ClaseB();

            public ClaseC() 
            {

                colorMorado("\nConstructor de la ClaseC.");
            
            }
        
        }
        static void Main(string[] args)
        {

            personalizarVentana();

            Console.WriteLine("A continuacion veremos una cadaena de herencias.");

            ClaseC BC= new ClaseC();

            Console.WriteLine("\nFin del programa...");

            Console.ReadKey();
        }
    }
}
