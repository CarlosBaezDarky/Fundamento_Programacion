using System;

namespace Proyecto_Parcial_2_Empleados
{
    class Program
    {
        static void PersonalizarVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.Clear();

        }
        class Empleados
        {
            private string[] nombre = new string[5];

            private int[] salario = new int[5];

            private int salarioFijo = 0;

            public void Cargar()
            {
                string nombres = "none";

                int contador = -1;

                bool condicionWhile = true;

                bool condicioWhile_2 = true;

                Console.WriteLine("A continuacion se le solicitara ingresar 5 nombres y los sueldos de dichas personas.");

                for (int i = 0; i <= 4; i++)
                {

                    ++contador;

                    Console.Write("\nNombre" + "[" + i + "]: ");

                    nombre[i] = Console.ReadLine();

                    condicionWhile = true;

                    while (condicionWhile == true)
                    {
                        nombres = nombre[i];

                        int valorNumerico;

                        bool existo = int.TryParse(nombres, out valorNumerico);

                        if (existo)
                        {

                            Console.WriteLine("\nEsto no es un nombre " + nombres);

                            Console.Write("\nNombre" + "[" + i + "]: ");

                            nombre[i] = Console.ReadLine();

                        }
                        else
                        {

                            condicionWhile = false;

                        }

                    }

                    condicioWhile_2 = true;

                    while (condicioWhile_2 == true)
                    {

                        Console.Write("\nSalario" + "[" + i + "]: ");

                        try
                        {

                            salario[i] = int.Parse(Console.ReadLine());

                            condicioWhile_2 = false;

                        }
                        catch
                        {

                            salario[i] = 0;

                        }

                    }

                }

            }

            public void SalarioMayor()
            {

                for (int i = 0; i <= 4; i++)
                {

                    if (salario[salarioFijo] < salario[i])
                    {

                        salarioFijo = i;

                    }

                    else
                    {

                    }

                }

                Console.WriteLine("\nEl empleado con el salario mayor es {0}", nombre[salarioFijo]);

                Console.WriteLine("\nTiene un salario de {0}", salario[salarioFijo]);

            }

        }
        static void Main(string[] args)
        {

            PersonalizarVentana();

            Empleados em = new Empleados();

            em.Cargar();

            em.SalarioMayor();

            Pausa.PausaFinPrograma();

        }

    }
}
