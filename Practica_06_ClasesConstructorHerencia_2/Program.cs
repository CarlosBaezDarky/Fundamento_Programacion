using System;

namespace Practica_06_ClasesConstructorHerencia_2_
{
    class Program
    {
        //Ajusta el ancho y alto de la ventana de la consola y ademas le cambia el color del texto a Cyan
        static void PesonalizarVentana()
        {
            Console.SetWindowSize(80, 20);

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.Clear();

        }
    class Pausa
    {
        //Una pausa para indicar el fin del programa
        public static void PausaFinPrograma()
        {

            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.");

            Console.ReadKey();

            Console.Clear();

        }

        //Una pausa para luego limpiar la pantalla
        public static void PausaLimpiarPantalla()
        {

            Console.WriteLine("\nPresione cualquier tecla para continuar.");

            Console.ReadKey();

            Console.Clear();

        }

    }

    //Imprime el texto de color morado
    static void colorMorado(string morado)
    {

        Console.ForegroundColor = ConsoleColor.Magenta;

        Console.WriteLine(morado);

        Console.ForegroundColor = ConsoleColor.DarkCyan;

    }
    class Contacto 
        {

            private string nombre;
            private string apellido;
            private string telefono;
            private string direccion;

            public void SetContacto(string a, string b, string c, string d) 
            {

                nombre = a;

                apellido = b;

                telefono = c;

                direccion = d;
            
            }

            public string Saludar() 
            {
                string saludo;

                return saludo = ("Hola soy " + nombre + " " + apellido + ", mi direccion es " + direccion + " y mi telefono es " + telefono + ".");
            
            }

        }

        class ProbarContacto 
        {

            public string Main() 
            {

                Contacto contacto_1 = new Contacto();

                Contacto contacto_2 = new Contacto();

                contacto_1.SetContacto("Carlos E.", "Al Monte Santana", "8098769999","Ciudad Modelo Edif. 10");

                contacto_2.SetContacto("Jose A.", "Al Monte Santana", "8298549933", "Ciudad Modelo Edif. 12");

                colorMorado("\n" + contacto_1.Saludar() + "\n\n" + contacto_2.Saludar());

                return "none";
            
            }
        
        }
        static void Main(string[] args)
        {

            PesonalizarVentana();

            Console.WriteLine("A continuacion se le mostrara el metodo Saludar...");

            Console.ReadKey();

            ProbarContacto probarContacto = new ProbarContacto();

            probarContacto.Main();

            Pausa.PausaFinPrograma();

        }
    }
}
