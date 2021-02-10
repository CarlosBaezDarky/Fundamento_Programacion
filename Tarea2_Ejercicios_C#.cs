/*Saludos

Nombre: Carlos Eduardo Báez Méndez

Matricula: 202010160

Materia: Fundamento de programación

Grupo: #10

Ejercicios en C#*/

/*1. Crear un programa que solicite al usuario un número indeterminado de números 
(mientras se tecleen números que no sean cero). Al salir el programa  debe dar en pantalla 
el total de números ingresados y la suma de ellos*/

using System;
using System.Threading;

namespace PRACTICA_1_
{
    class Program
    {
         class Limipiar

        {
            public static void LimpiarPantalla()
            {

                Console.Clear();

            }

            public static void LimpiarPantallaBucle(int a) 
            {
                if (a > 0)
                {
                    int b = (a % 10);

                    if (b == 0)
                    {

                        Console.Clear();

                        Console.WriteLine("Continue ingresando numeros.");

                    }
                }
            
            }

        }

        static void PausaFinPrograma() 
        {

            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa.");

            Console.ReadKey();

            Console.Clear();

            Console.Write("Fin programa." );

            Thread.Sleep(1500);

        }

        static void PersonalizarVentana() 
        {

            Console.SetWindowSize(80, 20);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();
        
        }
        static void Main(string[] args)
        {

            PersonalizarVentana();

            double numeroIndefinido = 0;

            int contadorLimpiarPantallaBucle = 1;

            int contadorNumeroIngresado = 1;

            bool condicionWhile = true;

            double sumaValoresIngresados = 0;

            Console.WriteLine("A continuacion se le solicitara ingresar X cantidad de numeros. Cuando ya no quiera ingresar mas numeros introduzca el numero <0> y finalizara el programa.");

            Console.WriteLine("\nNota: si introduce un numero muy elevado o muy pequeñito el programa le dara el resultado en notacion E. Donde E es igual a multiplicar un numero por 10 elevado a un numero. " +
                "\n\nEj: (6 x 10^ 23 = 6E+23.)");

            Console.Write("\nIngrese un numero: ");

            bool comprobacion = double.TryParse(Console.ReadLine(), out numeroIndefinido);

            if (comprobacion == true)
            {

                contadorNumeroIngresado++;

                if (numeroIndefinido == 0)
                {

                    condicionWhile = false;

                }

            }
            else 
            {
                numeroIndefinido = 0;
            }

            sumaValoresIngresados = (sumaValoresIngresados + numeroIndefinido);

            while (condicionWhile == true) 
            {

                Console.Write("\nIngrese un numero: ");

                comprobacion = double.TryParse(Console.ReadLine(), out numeroIndefinido);

                if (comprobacion == true) 
                {

                    contadorNumeroIngresado++;

                    if (numeroIndefinido == 0) 
                    {

                        condicionWhile = false;
                    
                    }

                }

                contadorLimpiarPantallaBucle++;

                sumaValoresIngresados = (sumaValoresIngresados + numeroIndefinido);

                Limipiar.LimpiarPantallaBucle(contadorLimpiarPantallaBucle);

            }

            Limipiar.LimpiarPantalla();

            Console.WriteLine("La cantidad de valores ingresados es: " + --contadorNumeroIngresado);

            Console.WriteLine("\nLa suma de los valores ingresados es: " + sumaValoresIngresados);

            PausaFinPrograma();

        }
    }
}

/*2.Crear un programa que presente un menú con las siguientes opciones 

o	Convertir grados a Celsius a Fahrenheit 
o	Convertir dólar a pesos.
o	Convertir metros a pies.
o	Salir 

Cada vez que finalice una de estas acciones debe regresar al menú. El programa  solo finalizará cuando 
el usuario elija la opción salir.*/

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

                Console.WriteLine("\nPresione cualquier tecla para volver al Menu.");

                Console.ReadKey();

                Console.Clear();

            }
        }

        static void PersonalizarVentana() 
        {

            Console.SetWindowSize(80, 20);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();
        
        }

        static void Menu() 
        {

            bool condicionWhile = true;

            while (condicionWhile == true) 
            {

                Console.WriteLine("\n __________________________________________ ");

                Console.WriteLine("|                                          |");

                Console.WriteLine("|                 < Menu >                 |");

                Console.WriteLine("|__________________________________________|");

                Console.WriteLine("|                                          |");

                Console.WriteLine("|1- Convertir grados a Celsius a Fahrenheit|");

                Console.WriteLine("|2- Convertir dólar a pesos                |");

                Console.WriteLine("|3- Convertir metros a pies                |");

                Console.WriteLine("|4- Salir                                  |");

                Console.WriteLine("|__________________________________________|");

                break;

            }
        
        }

        class Opciones
        {
            //Convertidor grados a Celsius a Fahrenheit
            public static void Opcion1(int convercion)
            {

                int celsius = convercion;

                int fahrenheit = ((convercion * 9 / 5) + 32);

                Console.WriteLine("\n" + celsius + " °C = " + fahrenheit + " °F");

            }

            //Convertidor dólar a pesos.
            public static void Opcion2(int convercion)
            {

                int dolar = convercion;

                int pesos = (convercion * 57);

                Console.WriteLine("\n" + dolar + " dolares = " + pesos + " pesos");

            }

            //Convertidor metros a pies.
            public static void Opcion3(double convercion)
            {

                double metro = convercion;

                double pies = (convercion * 3.281);

                Console.WriteLine("\n" + metro + " mestros = " + pies + " pies");

            }

            //Salir ( vuelve falso la condicion del while en el main )
            public static bool Opcion4(bool devuelta) 
            {

                devuelta = !devuelta;

                return devuelta;
            
            }

        }

        static void Main(string[] args)
        {

            PersonalizarVentana();

            bool condicionBucle = true;

            int condicionSwitch = 0;

            bool condicionWhile;

            while (condicionBucle == true) 
            {

                Menu();

                Console.Write("\nSeleccione una de las opciones del Menu: ");

                condicionWhile = true;

                while (condicionWhile == true)
                {
                    try
                    {

                        condicionSwitch = int.Parse(Console.ReadLine());

                        condicionWhile = false;

                    }
                    catch (FormatException e)
                    {

                        Console.Write("\nSeleccione una de las opciones del Menu: ");

                        condicionSwitch = 0;

                    }
                    catch (OverflowException e)
                    {

                        Console.Write("\nSeleccione una de las opciones del Menu: ");

                        condicionSwitch = 0;

                    }

                }

                switch (condicionSwitch) 
                {

                    case 1:

                        condicionWhile = true;

                        int celsius = 0;

                        Console.WriteLine("\nConvertir grados Celsius a Fahrenheit.");

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

                        Opciones.Opcion1(celsius);

                        Pausa.PausaLimpiarPantalla();

                        break;

                    case 2:

                        int dolar = 0;

                        Console.WriteLine("\nConviertir dólar a pesos con una equivalencia de 1 dolar = 57 pesos.");

                        Console.Write("\nInserte la cantidad de dolares a convertir: ");

                        condicionWhile = true;

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

                        Opciones.Opcion2(dolar);

                        Pausa.PausaLimpiarPantalla();

                        break;

                    case 3:

                        double metro = 0;

                        Console.WriteLine("\nConviertir metros a pies con una equivalencia de 1 metro = 3.281 pies.");

                        Console.Write("\nInserte los metros a convertir: ");

                        condicionWhile = true;

                        while (condicionWhile == true)
                        {
                            try
                            {

                                metro = double.Parse(Console.ReadLine());

                                condicionWhile = false;

                            }
                            catch (FormatException e)
                            {

                                Console.Write("\nInserte los metros a convertir: ");

                            }
                            catch (OverflowException e)
                            {

                                Console.Write("\nInserte los metros a convertir: ");

                            }

                        }

                        Opciones.Opcion3(metro);

                        Pausa.PausaLimpiarPantalla();

                        break;

                    case 4:

                        condicionBucle = Opciones.Opcion4(condicionBucle);

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

//3. Hacer un programa que genere las tablas de multiplicar de los números  múltiplos de 5 que hay 
//entre 1 y 500.

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

                Console.WriteLine("\nPresione cualquier tecla para volver al Menu.");

                Console.ReadKey();

                Console.Clear();

            }
        }

        static void PersonalizarVentana() 
        {

            Console.SetWindowSize(80, 20);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();
        
        }

        static void Multiplos() 
        {

            int contadorNumero = 0;

            int multiplicador = 0;

            int tablaMultiplicar = 0;

            int multiplo = 0;

            for (int i = 1; i <= 500; i++) 
            {

                contadorNumero = i;

                multiplo = (i % 5);

                if (multiplo == 0) 
                {

                    Console.WriteLine("Tabla del " + contadorNumero);

                    for (int e = 0; e <= 10; e++) 
                    {

                        multiplicador = e;

                        tablaMultiplicar = (contadorNumero * multiplicador);

                        Console.WriteLine("(" + contadorNumero + ")" + "(" + multiplicador + ")" + " = " + tablaMultiplicar);
                    
                    }

                    //Como un salto de linea entre tablas de multiplicar

                    Console.WriteLine();
                }

            }
        
        }

        static void Main(string[] args)
        {

            PersonalizarVentana();

            Console.WriteLine("A continuacion vera la tabla de multiplicar de los multiplos de 5 que hay entre 1 y 500");

            Pausa.PausaLimpiarPantalla();

            Multiplos();

            Pausa.PausaFinPrograma();

        }
    }
}

//4. Realizar un programa que reciba por teclado el sueldo de un empleado y le  aplique los cálculos 
//de ISR (ver tabla DGII), ARS, y AFP (investigar porcentajes).

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

                Console.WriteLine("\nPresione cualquier tecla para volver al Menu.");

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

        static void Impuestos(double descuento) 
        {

            double ars = 0;

            double afp = 0;

            double isr = 0;

            double anual = 0;

            double sueldo = 0;

            ars = (descuento * 0.0304);

            afp = (descuento * 0.0287);

            sueldo = ((descuento - ars) - afp);

            anual = (((descuento - ars) - afp) * 12);

            if (anual <= 416220.00) 
            {

                Console.WriteLine("\nARS mensual a pagar " + ars);

                Console.WriteLine("\nAFP mensual a pagar " + afp);

                Console.WriteLine("\nISR mensual a pagar "+ "[Exento]");

                Console.WriteLine("\nTu sueldo aplicando los calculos de ISR, ARS y AFP sera de: " + Math.Round(sueldo));

                Console.WriteLine("\nAl año sera de: " + Math.Round(anual));
            
            }

            else if (anual <= 624329.00)
            {

                isr = (((anual - 416220.00) * 0.15) / 12);

                Console.WriteLine("\nARS mensual a pagar " + ars);

                Console.WriteLine("\nAFP mensual a pagar " + afp);

                Console.WriteLine("\nISR mensual a pagar " + isr);

                Console.WriteLine("\nTu sueldo aplicando los calculos de ISR, ARS y AFP sera de: " + Math.Round((sueldo - isr)) );

                Console.WriteLine("\nAl año sera de: " + Math.Round(((sueldo - isr) * 12)));

            }

            else if (anual <= 867123.00)
            {

                isr = ((((anual - 624329.00) * 0.2) + 31216.00) / 12);

                Console.WriteLine("\nARS mensual a pagar " + ars);

                Console.WriteLine("\nAFP mensual a pagar " + afp);

                Console.WriteLine("\nISR mensual a pagar " + isr);

                Console.WriteLine("\nTu sueldo aplicando los calculos de ISR, ARS y AFP sera de: " + Math.Round((sueldo - isr)));

                Console.WriteLine("\nAl año sera de: " + Math.Round(((sueldo - isr) * 12)));

            }

            else if (anual > 867123.00)
            {

                isr = ((((anual - 867123.00) * 0.25) + 79776.00) / 12);

                Console.WriteLine("\nTu sueldo aplicando los calculos de ISR, ARS y AFP sera de: " + Math.Round((sueldo - isr)));

                Console.WriteLine("\nAl año sera de: " + Math.Round(((sueldo - isr) * 12)));

            }


        }
        static void Main(string[] args)
        {

            PersonalizarVentana();

            double salario = 0;

            bool condicionWhile = true;

            Console.WriteLine("A continuacion se le solicitara que ingrese el salario que recibe para aplicar los calculos de ARS, AFP y ISR.");

            Console.Write("\nIngrese su salario: ");

            condicionWhile = true;

            while (condicionWhile == true)
            {
                try
                {

                    salario = double.Parse(Console.ReadLine());

                    condicionWhile = false;

                }
                catch (FormatException e)
                {

                    Console.Write("\nIngrese su salario: ");

                }
                catch (OverflowException e)
                {

                    Console.Write("\nIngrese su salario: ");

                }

            }

            Impuestos(salario);

            Pausa.PausaFinPrograma();

        }
    }
}

