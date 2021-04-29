using System;

public class calculoPrestamo

{
    //calculo del interes mensual

    public double InteresMes(double tasaAnual)
    {
       double tasa;
       return  tasa = ((tasaAnual/100) / 12);
    }

    //calculo de la cuota mensual fija

    public double CuotaMensual(double monto, double interesMes, double plazoMeses)
    {
        double cuotaMes;
        return cuotaMes = ((monto * interesMes) / (1 - (Math.Pow((1 + interesMes), (-1 * plazoMeses)))));
    }

}
