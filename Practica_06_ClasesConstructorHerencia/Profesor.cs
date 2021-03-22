using System;

public class Profesor
{
	Persona profesor = new Persona();

	//Atributo particular de la clase profesor

	private double sueldo;

	//Constructor de la clase profesor
	public Profesor()
	{

		profesor.ajusteNombre("Jean Carlos");

		profesor.ajusteApellido("D. Alembert");

		profesor.ajusteCedula("80881736281");

		profesor.ajusteFechaNacimiento(1, 12, 1998);

		ajusteSueldo(33000.00);

	}

	//Retorna el valor del sueldo
	public double valorSueldo() 
	{

		return sueldo;
	
	}

	//Muestra el valor la variable sueldo
	public void mostrarSueldo() 
	{

        Console.WriteLine("\nSueldo: " +  valorSueldo());
	
	}

	//Muestra ajusta la fecha de nacimiento permitendo el calculo de la edad
	public void ajusteFechaNacimiento(int a, int b, int c)
	{

		profesor.ajusteFechaNacimiento(a, b, c);

	}

	//Muestra el valor de la  variable cedula
	public void mostrarCedulaProfesor()
	{

		profesor.mostrarCedula();

	}

	//Muestra el valor de la variable nombre
	public void mostrarNombreProfesor()
	{

		profesor.mostrarNombre();

	}

	//Muestra el valor de la variable apellido
	public void mostrarApellidoProfesor()
	{

		profesor.mostrarApellido();

	}

	//Muestra el valor de la variable edad del usuario
	public void mostrarEdad()
	{

		profesor.mostrarEdad();

	}

	//Muestra el la fecha de nacimiento 
	public void mostrarFechaDeNacimiento()
	{

		profesor.mostrarFechaDeNacimiento();

	}

	//Modificador de la variable sueldo
	public void ajusteSueldo(double a)
	{

		sueldo = a;

	}

	//Modifica el valor de la variable cedula
	public void ajusteCedulaProfesor(string a)
	{

		profesor.ajusteCedula(a);

	}

	//Modifica el valor de la variable nombre
	public void ajusteNombreProfesor(string a)
	{

		profesor.ajusteNombre(a);

	}

	//Modifica el valor de la variable apellido
	public void ajusteApellidoProfesor(string a)
	{

		profesor.ajusteApellido(a);

	}

	//Muestra toda la informacion del obejto de la clase Profesor
	public void mostrarInfoProfesor() 
	{

		profesor.mostrarInfoPersona();

		mostrarSueldo();
	
	}

}
