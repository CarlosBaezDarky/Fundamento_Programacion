using System;

public class Persona
{
        //Atributos de la clase

        private string cedula;
        private string nombre;
        private string apellido;

        //Atributos con los que se calculara la edad de la persona

        private int dia;
        private int mes;
        private int periodo;

        //Constructor de la clase el cual invoca al modificador "setEstructuraEdad"
        public Persona()
        {

            cedula = "001033008001";

            nombre = "Pedro Jacob";

            apellido = "Paredes Molina";

            ajusteFechaNacimiento(11, 10, 2002);

        }

        //Me retorna el valor de la cedula
        private string valorCedula()
        {

            return cedula;

        }

        //Me retorna el valor del nombre
        private string valorNombre()
        {

            return nombre;

        }

        //Me retorna el valor del apellido
        private string valorApellido()
        {

            return apellido;

        }

        //Me retorna el valor del dia
        private int valorDia()
        {

            return dia;

        }

        //Me retorna el valor del mes
        private int valorMes()
        {

            return mes;

        }

        //Me retorna el valor del periodo
        private int valorPeriodo()
        {

            return periodo;

        }

        //Me devuelve la edad actual del usuario

        private int calculoEdad() 
        {

            //Variable que almacena el valor a retornar

            int valorRetorno = 0;
            
            //Almacen de fechas actual y la diferencia de años

            int[] almacenFechaActual = new int[3];

            //Calcula la diferencia del año actual y el del usuario

            string diferenciaPeriodos = DateTime.Now.AddYears(-valorPeriodo()).ToString("yyyy");

            //Almacena el mes actual.

            string mesActual = DateTime.Now.AddMonths(00).ToString("MM");

            //Almacena el dia actual

            string diaActual = DateTime.Now.AddDays(00).ToString("dd");

            //Almacenan las fechas anteriores como valores enteros 

            almacenFechaActual[0] = int.Parse(diferenciaPeriodos);
            almacenFechaActual[1] = int.Parse(mesActual);
            almacenFechaActual[2] = int.Parse(diaActual);

            //Compara el valor del mes del usurio con el mes actual, con el fin de saber si ya su mes de cumpleaños paso o no. De esta manera saber que edad realmente tiene actualmente

            if (valorMes() < almacenFechaActual[1])
            {

                valorRetorno = almacenFechaActual[0];

            }

            else if (valorMes() == almacenFechaActual[1])
            {
                //Verifica si el dia de su cumpleaños ya paso o no

                if (valorDia() <= almacenFechaActual[2])
                {

                    valorRetorno = almacenFechaActual[0];

                }

            }
            else
            {

                valorRetorno = (almacenFechaActual[0] - 1);

            }

        return valorRetorno;

        }

        //Muestra el valor de la  variable cedula
        public void mostrarCedula() 
        {

            Console.WriteLine("\nCedula: " + valorCedula());
    
        }

        //Muestra el valor de la variable nombre
        public void mostrarNombre()
        {

            Console.WriteLine("\nNombre: " + valorNombre());

        }

        //Muestra el valor de la variable apellido
        public void mostrarApellido()
        {

            Console.WriteLine("\nApellido: " + valorApellido());

        }

        //Muestra el valor de la variable edad del usuario
        public void mostrarEdad() 
        {

            Console.WriteLine("\nEdad : " + calculoEdad());
    
        }

        //Muestra la fecha de Nacimiento de la persona

        public void mostrarFechaDeNacimiento() 
        {

            DateTime fecha = new DateTime(valorPeriodo(), valorMes(), valorDia());

            string fechaNacimiento = fecha.ToString("dd-MM-yyyy");

            Console.WriteLine("\nFecha de nacimiento: " + fechaNacimiento);
    
        }

        //Modificador de la edad/fecha de nacimiento
        public void ajusteFechaNacimiento(int a, int b, int c)
        {

            dia = a;
            mes = b;
            periodo = c;

        }

        //Modificador de la variable cedula
        public void ajusteCedula(string a)
        {
            if (a.Length < 11 || a.Length > 11)

            {

                cedula = "00000000000";


            }
            else
            {

                cedula = a;

            }
        }

        //Modificador de la variable nombre
        public void ajusteNombre(string a)
        {

            nombre = a;

        }

        //Modificador de la variable apellido
        public void ajusteApellido(string a)
        {

            apellido = a;

        }

        //Metodo para visualizar todos los atributos de una persona
        public void mostrarInfoPersona()
        {

            mostrarCedula();

            mostrarNombre();

            mostrarApellido();

            mostrarFechaDeNacimiento();

            mostrarEdad();

        }

}
