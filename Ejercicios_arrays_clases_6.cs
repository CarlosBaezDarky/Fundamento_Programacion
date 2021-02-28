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

        static void FicheroDeImagenes() 
        {
            bool condicionBucle = true;

            while (condicionBucle == true)
            {

                Console.WriteLine(" __________________________ ");
                Console.WriteLine("|                          |");
                Console.WriteLine("|   < Fichero/Imagenes >   |");
                Console.WriteLine("|__________________________|");
                Console.WriteLine("|                          |");
                Console.WriteLine("|1-> Añadir ficha          |");
                Console.WriteLine("|2-> Buscar ficha          |");
                Console.WriteLine("|3-> Ver todas las fichas  |");
                Console.WriteLine("|4-> Salir                 |");
                Console.WriteLine("|__________________________|");

                condicionBucle = false;

            }

        }

        static void ColorRojo(string color)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(color);

            Console.ForegroundColor = ConsoleColor.DarkGreen;

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

            string[] nombre = new string[700];

            int[] ancho = new int[700];

            int[] alto = new int[700];

            float[] tamano = new float[700];

            string buscar = "none";

            bool condicionWhile = true;

            bool condicionBucle = true;

            int seleccionDeOpciones = 0;

            int contador = -1;

            while (condicionWhile == true) 
            {

                FicheroDeImagenes();

                condicionBucle = true;

                while (condicionBucle == true)
                {

                    Console.Write("\n¿Que desea hacer? ");

                    try
                    {

                        seleccionDeOpciones = int.Parse(Console.ReadLine());

                        condicionBucle = false;

                    }
                    catch (FormatException e)
                    {

                        seleccionDeOpciones = 0;

                    }
                    catch (OverflowException e)
                    {

                        seleccionDeOpciones = 0;

                    }
                }

                switch (seleccionDeOpciones) 
                {

                    case 1:

                        ++contador;

                        if (contador != 699)
                        {
                            Console.Write("\nIngrese el nombre de la imagen: ");

                            nombre[contador] = Console.ReadLine();

                            Console.Write("\nIngrese el ancho de la imagen en pixeles: ");

                            try
                            {
                                ancho[contador] = int.Parse(Console.ReadLine());
                            }
                            catch
                            {

                                ancho[contador] = 0;
                                
                            }
                            Console.Write("\nIngrese el alto de la imagen en pixeles: ");

                            try
                            {
                                alto[contador] = int.Parse(Console.ReadLine());
                            }
                            catch
                            {

                                alto[contador] = 0;

                            }

                            Console.Write("\nIngrese el tamaño de la imagen en Kb: ");

                            try
                            {
                                tamano[contador] = float.Parse(Console.ReadLine());
                            }
                            catch
                            {

                                tamano[contador] = 0;

                            }

                            Pausa.PausaLimpiarPantalla();
                        }
                        else
                        {

                            Console.WriteLine("\nLa aplicacion llego al maximo de almacenamiento.");

                            Pausa.PausaLimpiarPantalla();
                        
                        }
                        break;

                    case 2:

                        bool condicion = true;

                        Console.Write("\nIngrese el nombre de la imagen: ");

                         buscar = Console.ReadLine();

                        for (int i = 0; i <= 699; i++) 
                        {
                            int contador2 = -1;

                            ++contador2;

                            if (nombre[i] == buscar)
                            {

                                ColorRojo("\nEstos son los datos de la imagen que buscas:");

                                ColorRojo("\nNombre: " + nombre[contador2]);

                                ColorRojo("\nAncho: " + ancho[contador2] + " pixeles " + ", Alto: " + alto[contador2] + " pixeles");

                                ColorRojo("\nTamanño: " + tamano[contador2] + " Kb");

                                condicion = false;

                            }
                            
                        }

                        if (condicion == true)
                        {

                            ColorRojo("\nNo se ha encontrado ninguna imagen llamada " + buscar + ".");
                        
                        }

                        Pausa.PausaLimpiarPantalla();

                        break;

                    case 3:

                        bool condicion2 = true;

                        for (int i = 0; i <= 699; i++)
                        {

                            if (tamano[i] > 0)
                            {
                                ColorRojo("\nEstos son los datos de la imagen " + "[" + i + "] :");

                                ColorRojo("\nNombre: " + nombre[i]);

                                ColorRojo("\nAncho: " + ancho[i] + " pixeles " + ", Alto: " + alto[i] + " pixeles");

                                ColorRojo("\nTamanño: " + tamano[i] + " Kb");

                                condicion2 = false;
                            }

                        }

                        if (condicion2 == true)
                        {

                            ColorRojo("\nNo hay elementos aun.");

                        }

                        Pausa.PausaLimpiarPantalla();

                        break;

                    case 4:

                        condicionWhile = false;

                        break;

                    default :

                        Pausa.PausaLimpiarPantalla();

                        break;

                }

            }

            Pausa.PausaFinPrograma();

        }
    }
}