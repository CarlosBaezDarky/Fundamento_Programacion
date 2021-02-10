/*Saludos

Nombre: Carlos Eduardo Báez Méndez

Matricula: 202010160

Materia: Fundamento de programación

Grupo: #10

Ejercicios en C#*/

//1- Almacenar en una variable el nombre de una persona y al final muestre en consola el mensaje: 
//“Bienvenido [NOMBRE COMPLETO]”.

using System;

namespace PRACTICA_1_
{
    class Program
    {
        static void PausaLimpiarPantalla()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar.\n");

            Console.ReadKey();

            Console.Clear();
        }

        static void PausaFinPrograma()
        {
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.\n");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Fin del programa.");
        }

        static void PersonalizacionVentana() 
        {

            Console.SetWindowSize(80, 20);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;

        }


        static void Main(string[] args)
        {

            PersonalizacionVentana();

            string[] variableNombre = new string[3] { "None", "None", "None" };

            string[] textoNombreApellido = new string[3] {"None", "nombre: ", "apellido: " };

            int contador = 0;

            Console.WriteLine("A continuacion se le solicitara su nombre y luego su apellido.\n");

            Console.Write("Ingrese su " + textoNombreApellido[1]);

            variableNombre[1] = Console.ReadLine();

            Console.Write("\nIngrese su " + textoNombreApellido[2]);

            variableNombre[2] = Console.ReadLine();

            for (int i = 0; i <=1; i++ )
            {

                bool condicionWhile = true;

                contador++;

                while (condicionWhile == true)
                {
                    string valor = variableNombre[contador];

                    int valorNumerico;

                    bool existo = int.TryParse(valor, out valorNumerico);

                    if (existo)
                    {

                        Console.WriteLine("\nEsto no es un " + textoNombreApellido[contador] + valor + "\n");

                        Console.Write("Ingrese su " + textoNombreApellido[contador]);

                        variableNombre[contador] = Console.ReadLine();

                    }
                    else
                    {

                        condicionWhile = false;

                    }

                }
            }

            Console.WriteLine("\nBienvenido " + variableNombre[1] + " " + variableNombre[2]);

            PausaFinPrograma();
        }
    }
}

//2- Evalué si un número es PAR o IMPAR y muestre en consola el mensaje.

using System;

namespace PRACTICA_1_
{
    class Program
    {
        static void ParImpar(int comparacion)
        {

            if (comparacion % 2 == 1)
            {

                Console.WriteLine("\nEl numero ingresado es impar.");

            }

            else
            {

                Console.WriteLine("\nEl numero ingresado es Par");

            }

        }

        static void PausaFinPrograma()
        {
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.\n");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Fin del programa.");
        }

        static void PersonalizacionVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;

        }
        static void Main(string[] args)
        {
            PersonalizacionVentana();

            int variableNumero;

            bool condicionWhile;

            condicionWhile = true;

            variableNumero = 0;

            Console.WriteLine("A continuacion se le solicitara un numero para saber si es [Par] o [Impar].\n");

            Console.Write("Ingrese un numero por favor: ");

            while (condicionWhile == true)
            {
                try
                {

                    variableNumero = int.Parse(Console.ReadLine());

                    condicionWhile = false;

                }
                catch (FormatException e)
                {

                    Console.Write("\nIngrese un numero por favor: ");

                }
                catch (OverflowException e) 
                {

                    Console.Write("\nIngrese un numero por favor: ");

                }

            }

            ParImpar(variableNumero);

            PausaFinPrograma();
        }
    }
}

//3- Almacené dos números y evalué si el primero es mayor que el segundo. El resultado debe mostrarlo 
//por consola.

using System;

namespace PRACTICA_1_
{
    class Program
    {
        static void Tricotomia(int A, int B)
        {

            if (A > B)
            {

                Console.WriteLine("\nX = " + A + ".");

                Console.WriteLine("\nY = " + B + ".");

                Console.WriteLine("\nEl valor de X es mayor que el valor de Y.");

            }

            else if (A == B)
            {

                Console.WriteLine("\nX = " + A + ".");

                Console.WriteLine("\nY = " + B + ".");

                Console.WriteLine("\nEl valor de X es igual que el valor de Y.");

            }

            else
            {
                Console.WriteLine("\nX = " + A + ".");

                Console.WriteLine("\nY = " + B + ".");

                Console.WriteLine("\nEl valor de X es menor que el valor de Y.");
            }

        }

        static void PausaFinPrograma()
        {
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.\n");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Fin del programa.");
        }

        static void PersonalizacionVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;

        }
        static void Main(string[] args)
        {
            PersonalizacionVentana();

            int variableA, variableB;

            bool condicionWhile = true;

            variableA = 0;

            variableB = 0;

            Console.WriteLine("A continuacion se le solicitara los valores de [X] y [Y] para compararlos.");

            Console.Write("\nIngrese un numero para X: ");

            while (condicionWhile == true)
            {
                try
                {

                    variableA = int.Parse(Console.ReadLine());

                    condicionWhile = false;

                }
                catch (FormatException e)
                {

                    Console.Write("\nIngrese un numero para X: ");

                }
                catch (OverflowException e)
                {

                    Console.Write("\nIngrese un numero para X: ");

                }

            }

            condicionWhile = true;

            Console.Write("\nIngrese un numero para Y: ");

            while (condicionWhile == true)
            {
                try
                {

                    variableB = int.Parse(Console.ReadLine());

                    condicionWhile = false;

                }
                catch (FormatException e)
                {

                    Console.Write("\nIngrese un numero para Y: ");

                }
                catch (OverflowException e)
                {

                    Console.Write("\nIngrese un numero para Y: ");

                }

            }

            Tricotomia(variableA, variableB);

            PausaFinPrograma();
        }
    }
}

//4- Mostrar el tipo de dato que retorna la expresión 23 < 18.

sing System;

namespace PRACTICA_1_
{
    class Program
    {

        static void PausaRespuesta() 
        {

            bool comparacion;

            comparacion = 23 < 18;

            Console.WriteLine("\nPresione cualquier tecla para continuar.");

            Console.ReadKey();

            Console.WriteLine("\nEl tipo de dato es [" + comparacion + "], O sea un dato logico.");

        }
        static void PausaFinPrograma()
        {
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.\n");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Fin del programa.");
        }

        static void PersonalizacionVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;

        }
        static void Main(string[] args)
        {

            PersonalizacionVentana();

            Console.WriteLine("Saludos, a continuacion veremos que tipo de dato arroja la expresion 23 < 18.");

            PausaRespuesta();

            PausaFinPrograma();
        }
    }
}

//5- Convierte dólares a peso con la tasa del banco de reservas (18-01-2021).

using System;

namespace PRACTICA_1_
{
    class Program
    {

        static int dolar;
        static void DolarToPesos(int convercion)
        {

            int pesos;

            pesos = (convercion * 57);

            Console.WriteLine("\n" + dolar + " dolares = " + pesos + " pesos");

        }

        static void PausaFinPrograma()
        {
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.\n");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Fin del programa.");
        }

        static void PersonalizacionVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;

        }

        static void Main(string[] args)
        {

            PersonalizacionVentana();

            dolar = 0;

            Console.WriteLine("Conviertidor de dólares a pesos con una equivalencia de 1 dolar = 57 pesos.");

            Console.Write("\nInserte la cantidad de dolares a convertir: ");

            bool condicionWhile = true;

            while (condicionWhile == true)
            {
                try
                {

                    dolar = int.Parse(Console.ReadLine());

                    condicionWhile = false;

                }
                catch (FormatException e)
                {

                    Console.Write("\nInserte la cantidad de dolares a convertir: ");

                }
                catch (OverflowException e)
                {

                    Console.Write("\nInserte la cantidad de dolares a convertir: ");

                }

            }

            DolarToPesos(dolar);

            PausaFinPrograma();
        }
    }
}

//6- Convierta grados Celsius a Fahrenheit.

using System;

namespace PRACTICA_1_
{
    class Program
    {

        static int celsius;
        static void CelsiusToFahrenheit(int convercion)
        {

            int Fahrenheit;

            Fahrenheit = ((convercion * 9 / 5) + 32);

            Console.WriteLine("\n" + celsius + " °C = " + Fahrenheit + " °F");

        }

        static void PausaFinPrograma()
        {
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.\n");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Fin del programa.");
        }

        static void PersonalizacionVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;

        }

        static void Main(string[] args)
        {

            PersonalizacionVentana();

            bool condicionWhile = true;

            celsius = 0;

            Console.WriteLine("Convierta de grados Celsius a Fahrenheit.");

            Console.Write("\nInserte los grados Celsius a convertir: ");

            while (condicionWhile == true)
            {
                try
                {

                    celsius = int.Parse(Console.ReadLine());

                    condicionWhile = false;

                }
                catch (FormatException e)
                {

                    Console.Write("\nInserte los grados Celsius a convertir: ");

                }
                catch (OverflowException e)
                {

                    Console.Write("\nInserte los grados Celsius a convertir: ");

                }

            }

            CelsiusToFahrenheit(celsius);

            PausaFinPrograma();
        }
    }
}

//7- Almacene cuatro notas 90, 95, 77, 92 y las promedie. Al final debe decir su calificación 
//en letras A, B, C, D o F.

using System;

namespace PRACTICA_1_
{
    class Program
    {

        static void PromedioNotas()
        {
            int[] notas = new int[4] { 90, 95, 77, 92 };

            string[] Califiacion = new string[4] { "A", "B", "C", "F" };

            int promedio;

            int sumaNotas;

            promedio = 0;

            sumaNotas = 0;

            for (int i = 0; i <= 3; i++)
            {

                sumaNotas = (sumaNotas + notas[i]);

            }

            promedio = (sumaNotas / 4);

            Console.WriteLine("El promedio de las siguientes notas [90,95,77,92] es: " + promedio);

            Console.WriteLine("\n A = 100-90" +
                "\n B = 89-80" +
                "\n C = 79-70" +
                "\n F = 69 o menos");

            if (promedio >= 90)
            {
                Console.WriteLine("\nSu calificacion es una " + Califiacion[0] + ".");
            }

            else if (promedio >= 80)
            {

                Console.WriteLine("\nSu calificacion es una " + Califiacion[1] + ".");

            }

            else if (promedio >= 70)
            {

                Console.WriteLine("\nSu calificacion es una " + Califiacion[2] + ".");

            }

            else
            {
                Console.WriteLine("\nSu calificacion es una " + Califiacion[3] + ".");
            }
        }

        static void PausaPantalla()
        {

            Console.WriteLine("\nPresione cualquier tecla para continuar.");

            Console.ReadKey();

            Console.Clear();

        }
		
		static void PausaFinPrograma()
        {
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.\n");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Fin del programa.");
        }

        static void PersonalizacionVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;

        }

        static void Main(string[] args)
        {

			PersonalizacionVentana();
			
            Console.WriteLine("A continuacion veremos el promedio de las siguientes notas [90,95,77,92].");

            PausaPantalla();

            PromedioNotas();
			
			PausaFinPrograma();
        }
    }
}

//8- Crear un programa que diga el resultado de restar 92345 y 67890.

using System;

namespace PRACTICA_1_
{
    class Program
    {

        static int Resta(int A, int B)
        {
            int resultado;

            resultado = (A - B);

            return resultado;
        }

        static void PausaPantalla()
        {

            Console.WriteLine("\nPresione cualquier tecla para continuar.");

            Console.ReadKey();

            Console.Clear();

        }

        static void PausaFinPrograma()
        {
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.\n");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Fin del programa.");
        }

        static void PersonalizacionVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;

        }
        static void Main(string[] args)
        {

            PersonalizacionVentana();

            int minuendo, sustraendo, respuesta;

            minuendo = 92345;

            sustraendo = 67890;

            respuesta = Resta(minuendo, sustraendo);

            Console.WriteLine("A continuacion vera el resultado de restar 92345 y 67890.");

            PausaPantalla();

            Console.WriteLine("El resultado de restar 92345 y 67890 es " + respuesta + ".");

            PausaFinPrograma();
        }
    }
}

//9- Crear un programa que calcule el resto de la división de 301 entre 3.

using System;

namespace PRACTICA_1_
{
    class Program
    {

        static int Resto(int A, int B)
        {
            int resultado;

            resultado = (A % B);

            return resultado;
        }

        static void PausaPantalla()
        {

            Console.WriteLine("\nPresione cualquier tecla para continuar.");

            Console.ReadKey();

            Console.Clear();

        }

        static void PausaFinPrograma()
        {
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.\n");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Fin del programa.");
        }

        static void PersonalizacionVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;

        }
        static void Main(string[] args)
        {

            PersonalizacionVentana();

            int dividiendo, divisor, resto;

            dividiendo = 301;

            divisor = 3;

            resto = Resto(dividiendo, divisor);

            Console.WriteLine("A continuacion vera el resto de la division de 301 entre 3.");

            PausaPantalla();

            Console.WriteLine("El resto de la division de 301 entre 3 es " + resto + ".");

            PausaFinPrograma();
        }
    }
}

//10- Calcular el resultado de (20+5) % 6

using System;

namespace PRACTICA_1_
{
    class Program
    {

        static int Formula(int A, int B, int C)
        {
            int resultado;

            resultado = ((A + B) % C);

            return resultado;
        }

        static void PausaPantalla()
        {

            Console.WriteLine("\nPresione cualquier tecla para continuar.");

            Console.ReadKey();

            Console.Clear();

        }

        static void PausaFinPrograma()
        {
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.\n");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Fin del programa.");
        }

        static void PersonalizacionVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;

        }
        static void Main(string[] args)
        {

            PersonalizacionVentana();

            int[] valores = new int[3] { 20, 5, 6 };

            int respuesta;

            respuesta = Formula(valores[0], valores[1], valores[2]);

            Console.WriteLine("A continuacion vera el resultado de la siguiente expresion (20+5) % 6.");

            PausaPantalla();

            Console.WriteLine("El resultado de la siguiente expresion (20+5) % 6 es " + respuesta + ".");

            PausaFinPrograma();
        }
    }
}

//11- Calcular el resultado de 2 + 10 / 5 * 2 - 7 % 1

using System;

namespace PRACTICA_1_
{
    class Program
    {

        static double Formula(double A, double B, double C, double D, double E, double F)
        {
            double resultado;

            resultado = ((A + B) / (C * D - E % F));

            return resultado;
        }

        static void PausaPantalla()
        {

            Console.WriteLine("\nPresione cualquier tecla para continuar.");

            Console.ReadKey();

            Console.Clear();

        }

        static void PausaFinPrograma()
        {
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.\n");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Fin del programa.");
        }

        static void PersonalizacionVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;

        }
        static void Main(string[] args)
        {

            PersonalizacionVentana();

            int[] valores = new int[5] { 2, 10, 5, 7, 1 };

            double respuesta;

            respuesta = Formula(valores[0], valores[1], valores[2], valores[0], valores[3], valores[4]);

            Console.WriteLine("A continuacion vera el resultado de la siguiente expresion 2 + 10 / 5 * 2 - 7 % 1.");

            PausaPantalla();

            Console.WriteLine("El resultado de la siguiente expresion 2 + 10 / 5 * 2 - 7 % 1 es " + respuesta + ".");

            PausaFinPrograma();
        }
    }
}

//12- Crea un programa que calcule el resto de dividir 3784 entre 16, usando variables.

using System;

namespace PRACTICA_1_
{
    class Program
    {

        static int Resto(int A, int B)
        {
            int resultado;

            resultado = (A % B);

            return resultado;
        }

        static void PausaPantalla()
        {

            Console.WriteLine("\nPresione cualquier tecla para continuar.");

            Console.ReadKey();

            Console.Clear();

        }

        static void PausaFinPrograma()
        {
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.\n");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Fin del programa.");
        }

        static void PersonalizacionVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;

        }
        static void Main(string[] args)
        {

            PersonalizacionVentana();

            int dividiendo, divisor, resto;

            dividiendo = 3784;

            divisor = 16;

            resto = Resto(dividiendo, divisor);

            Console.WriteLine("A continuacion vera el resto de la division de 3784 entre 16.");

            PausaPantalla();

            Console.WriteLine("El resto de la division de 3784 entre 16 es " + resto + ".");

            PausaFinPrograma();
        }
    }
}

//13- Crea un programa que calcule la suma de 285 y 1396, usando variables.

using System;

namespace PRACTICA_1_
{
    class Program
    {

        static int Suma(int A, int B)
        {
            int resultado;

            resultado = (A + B);

            return resultado;
        }

        static void PausaPantalla()
        {

            Console.WriteLine("\nPresione cualquier tecla para continuar.");

            Console.ReadKey();

            Console.Clear();

        }

        static void PausaFinPrograma()
        {
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.\n");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Fin del programa.");
        }

        static void PersonalizacionVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;

        }
        static void Main(string[] args)
        {

            PersonalizacionVentana();

            int sumandoA, sumandoB, respuesta;

            sumandoA = 285;

            sumandoB = 1396;

            respuesta = Suma(sumandoA, sumandoB);

            Console.WriteLine("A continuacion vera el resultado de sumar 285 y 1396.");

            PausaPantalla();

            Console.WriteLine("El resultado de sumar 285 y 1396 es " + respuesta + ".");

            PausaFinPrograma();
        }
    }
}

//14- Crea un programa que calcule el producto de dos números introducidos por el usuario.

using System;

namespace PRACTICA_1_
{
    class Program
    {

        static double Producto(double A, double B)
        {
            double resultado;

            resultado = (A * B);

            return resultado;
        }

        static void PausaPantalla()
        {

            Console.WriteLine("\nPresione cualquier tecla para continuar.");

            Console.ReadKey();

            Console.Clear();

        }

        static void PausaFinPrograma()
        {
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.\n");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Fin del programa.");
        }

        static void PersonalizacionVentana()
        {

            Console.SetWindowSize(80, 20);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;

        }
        static void Main(string[] args)
        {

            PersonalizacionVentana();

            double factorA, factorB, respuesta;

            factorA = 0;

            factorB = 0;

            bool condicionWhile = true;

            Console.WriteLine("A continuacion vera el producto de X por Y.");

            Console.Write("\nIngrese el valor de X: ");

            while (condicionWhile == true)
            {
                try
                {

                    factorA = double.Parse(Console.ReadLine());

                    condicionWhile = false;

                }
                catch (FormatException e)
                {

                    Console.Write("\nIngrese el valor de X: ");

                    factorA = 0;

                }
                catch (OverflowException e)
                {

                    Console.Write("\nIngrese el valor de X: ");

                    factorA = 0;

                }

            }

            condicionWhile = true;

            Console.Write("\nIngrese el valor de Y: ");

            while (condicionWhile == true)
            {
                try
                {

                    factorB = double.Parse(Console.ReadLine());

                    condicionWhile = false;

                }
                catch (FormatException e)
                {

                    Console.Write("\nIngrese el valor de Y: ");

                    factorB = 0;

                }
                catch (OverflowException e)
                {

                    Console.Write("\nIngrese el valor de Y: ");

                    factorB = 0;

                }

            }

            respuesta = Producto(factorA, factorB);

            PausaPantalla();

            Console.WriteLine
                (

                "X = " + factorA + "\n" +

                "Y = " + factorB + "\n" +

                "\nEl producto de X por Y es " + respuesta + "."

                );

            PausaFinPrograma();
        }
    }
}

//Fin...













