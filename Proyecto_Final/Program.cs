using System;
using System.Threading;


namespace Consola_Tabla_de_amortizacion
{
    class Program
    {
        static bool FinPrograma() 
        {
            bool condicionBucle = false;
            ConsoleKeyInfo Y;

            Console.Write("\nPresione < Enter > si desea continuar el programa...");
            Y = Console.ReadKey();

            if (Y.Key == ConsoleKey.Enter)
            {
                condicionBucle = true;
                Console.Clear();
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("\nFin del programa...");
                Thread.Sleep(2000);
            }
            return condicionBucle;
        
        }
        static void Main(string[] args)
        {
           
            double montoPrestamo = 0, plazoMeses = 0, tasaAnual = 0, cuota, interesMes;
            bool condicionBucle = true;

            while (condicionBucle == true)
            {

                Console.WriteLine("\t\t\t\t\t\tCalculador de Prestamos");
                Console.Write("\nMonto del prestamo (Debe ser en RD$): ");
                double.TryParse(Console.ReadLine(), out montoPrestamo);
                Console.Write("\nPLazo (Debe ser en meses y menor a 30 años): ");
                double.TryParse(Console.ReadLine(), out plazoMeses);
                Console.Write("\nTasa de Porcentaje Anual (Debe ser en %): ");
                double.TryParse(Console.ReadLine(), out tasaAnual);

                tablaAmortizada tabAmor = new tablaAmortizada();

                if ((montoPrestamo > 0) && (plazoMeses > 0) && (plazoMeses <= 360) && (tasaAnual > 0))
                {
                    cuota = tabAmor.CuotaMensual(montoPrestamo, tabAmor.InteresMes(tasaAnual), plazoMeses);
                    interesMes = tabAmor.InteresMes(tasaAnual);
                    tabAmor.TablaAmortizada(montoPrestamo, tasaAnual, plazoMeses, cuota, interesMes);
                }

                condicionBucle = FinPrograma();
            }
        }    
    }
}
