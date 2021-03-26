using System;

namespace Proyecto_Parcial_2
{
    class Program
    {
        static void PersonalizarVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.Clear();

        }
        static void MaquinaDispensadora()
        {

            bool condicionBucle = true;

            while (condicionBucle == true)
            {

                Console.WriteLine(" __________________________ ");
                Console.WriteLine("|                          |");
                Console.WriteLine("| < Maquina Dispensadora > |");
                Console.WriteLine("|__________________________|");
                Console.WriteLine("|                          |");
                Console.WriteLine("|1-> COMPRAR               |");
                Console.WriteLine("|2-> SALIR                 |");
                Console.WriteLine("|__________________________|");

                condicionBucle = false;

            }

        }
        static void Main(string[] args)
        {
            PersonalizarVentana();

            int seleccion = 0;

            bool condicionWhile = true;

            while (condicionWhile == true) 
            {

                Pausa.LimpiarPantalla();

                MaquinaDispensadora();

                Console.Write("\n¿Qué desea hacer? ");

                try
                {

                    seleccion = int.Parse(Console.ReadLine());

                }
                catch 
                {

                    seleccion = 0;
                
                }

                switch (seleccion) 
                {

                    case 1:

                        Producto pro = new Producto();

                        bool condicionCompra = true;

                        int cualto = 0; 

                        Pausa.LimpiarPantalla();

                        pro.getProductosPrecios();


                        while (condicionCompra == true)
                        {

                            Console.Write("\nProducto a comprar: ");

                            try
                            {
                                 cualto = int.Parse(Console.ReadLine());

                                if (cualto > 0 && cualto < 11) 
                                {

                                    condicionCompra = false;
                                
                                }
                            }
                            catch 
                            {
                                cualto = 0;
                            }

                        }

                        pro.ProductoCompra(cualto);

                        Console.ReadKey();

                        break;

                    case 2:

                        condicionWhile = false;

                        Producto finDia = new Producto();

                        finDia.FinDelDia();

                        Pausa.PausaFinPrograma();

                        break;
                
                }
            
            }

        }
    }
}
