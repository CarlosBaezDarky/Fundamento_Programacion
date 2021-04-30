using System;

public class tablaAmortizada
{
	private double capital, interes, salddo = 0, totalCapital = 0;
	private int pago;
	private DateTime fechaPago;

	public tablaAmortizada()
	{
		pago = 0;
	}

	//calculo del interes mensual

	public double InteresMes(double tasaAnual)
	{
		double tasa;
		return tasa = ((tasaAnual / 100) / 12);
	}

	//calculo de la cuota mensual fija

	public double CuotaMensual(double monto, double interesMes, double plazoMeses)
	{
		double cuotaMes;
		return cuotaMes = ((monto * interesMes) / (1 - (Math.Pow((1 + interesMes), (-1 * plazoMeses)))));
	}


	//Calcula el interes
	public double Interes(double balance = 0, double interesMes = 0)
	{
		double interes;
		return interes = (balance * interesMes);
	}

	//Calcula el capital
	public double Capital(double cuotaMensual = 0, double interes = 0)
	{
		double capital;
		return capital = (cuotaMensual - interes);
	}

	public void TablaAmortizada(double monto, double tasaAnual, double plazo, double cuota, double interesMes)
	{
		Console.Clear();
		Console.WriteLine("\t\t\t\t\t\tCalculador de Prestamos");

		for (double i = 1; i <= plazo; i++) 
		{
			pago++;

			//Este if se encarga del calculo del saldo correspondiente al plazo 1
			if (i == 1) salddo = monto;

			fechaPago = DateTime.Now.AddDays(29 * pago);
			this.interes = Math.Round(Interes(salddo, interesMes), 2);
			this.capital = Math.Round(Capital(cuota, this.interes), 2);
			totalCapital += this.capital;// Acumulador de capital
			salddo = Math.Round((monto - totalCapital), 2);


			if (i == 1)
			{
				Console.WriteLine("\n\tMonto del prestamo en RD$\t\t\t\t\t\t" + monto);
				Console.WriteLine("\t_____________________________________________________________________________________________");
				Console.WriteLine("\n\tTasa de Porcentaje Anual \t\t\t\t\t\t" + tasaAnual + " %");
				Console.WriteLine("\t_____________________________________________________________________________________________");
				Console.WriteLine("\n\tPLazo                    \t\t\t\t\t\t" + plazo);
				Console.WriteLine("\t_____________________________________________________________________________________________");
				Console.WriteLine("\n\tValor Cuota              \t\t\t\t\t\t" + Math.Round(cuota, 2));
				Console.WriteLine("\t_____________________________________________________________________________________________");
				Console.WriteLine("\n\t\t\t\t\t\tTabla de Amortizacion");

				//Espacio vertical
				Console.WriteLine();
				Console.WriteLine();
			}

			if (i == plazo) salddo = 0;

			if (i == 1)
			{
				Console.WriteLine("\tPago\t\tFecha de Pago\t\tCuota\t\tCapital\t\tInteres\t\tBalance");
				Console.WriteLine("\t_____________________________________________________________________________________________________");
			}

			Console.WriteLine("\n\t{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}", pago, fechaPago.ToString("d-MMM-yyy"), Math.Round(cuota, 2),this.capital,this.interes, salddo);

		}

	}
}
