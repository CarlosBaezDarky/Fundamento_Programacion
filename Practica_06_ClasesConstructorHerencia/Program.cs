using System;

namespace Practica_06_ClasesConstructorHerencia
{
    class Program
    {
        //Ajusta el ancho y el alto de la ventana de consola y cambia el color del texto a cyan
        static void PersonalizarVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.Clear();

        }
        class Pausa
        {
            //Pausa el programa para indicar su finalizacion
            public static void PausaFinPrograma()
            {

                Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.");

                Console.ReadKey();

                Console.Clear();

            }

            //Pausa el programa y luego procede a limpiar la pantalla
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

        static void Main(string[] args)
        {
            PersonalizarVentana();

            Persona per = new Persona();

            Profesor pro = new Profesor();

            //Metodos y propiedades de la clase Persona.

            colorMorado("A continuacion vera todos los metodos y propiedades de la Clase Persona...");

            Pausa.PausaLimpiarPantalla();

            colorMorado("Este es el metodo [mostrarInfoPersona] y los datos son los del constructor.");

            per.mostrarInfoPersona();

            Console.ReadKey();

            colorMorado("\nA continuacion modificaremos y mostaremos el nombre, cedula, apellido, fecha de Nacimiento y edad.");

            per.ajusteFechaNacimiento(10, 3, 1990);

            per.mostrarFechaDeNacimiento();

            per.mostrarEdad();

            per.ajusteCedula("00000000001");

            per.mostrarCedula();

            per.ajusteNombre("Carlos E.");

            per.mostrarNombre();

            per.ajusteApellido("Paredes Secas");

            per.mostrarApellido();

            Console.ReadKey();

            //Metodos y propiedades de la clase Profesor

            colorMorado("\nA continuacion vera todos los metodos y propiedades de la Clase Profesor...");

            Pausa.PausaLimpiarPantalla();

            colorMorado("Este es el metodo [mostrarInfoProfesor] y los datos son los del constructor.");

            pro.mostrarInfoProfesor();

            Console.ReadKey();

            colorMorado("\nA continuacion modificaremos y mostaremos el nombre, cedula, apellido, fecha de Nacimiento y edad.");

            pro.ajusteFechaNacimiento(1, 3, 2004);

            pro.mostrarFechaDeNacimiento();

            pro.mostrarEdad();

            pro.ajusteCedulaProfesor("11100098719");

            pro.mostrarCedulaProfesor();

            pro.ajusteNombreProfesor("Jose Rafael");

            pro.mostrarNombreProfesor();

            pro.ajusteApellidoProfesor("Montero Reina");

            pro.mostrarApellidoProfesor();

            Console.ReadKey();

            colorMorado("\nGracias por ver el programma.");

            Pausa.PausaFinPrograma();

        }

    }
  
}
