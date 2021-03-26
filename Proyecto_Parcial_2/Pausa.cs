using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Parcial_2
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

        public static void LimpiarPantalla() 
        {

            Console.Clear();
        
        }

    }
}
