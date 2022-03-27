using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ETS
{
	class Calculo
	{
		public static TimeSpan ObtenerDiaDiferencia(Datos.Fechas[] fechas)
		{
			DateTime fechaUno = fechas[0].Fecha;
			DateTime fechaDos = fechas[1].Fecha;
			TimeSpan dia = fechaDos.Subtract(fechaUno);

			if (fechaUno > fechaDos)
			{
				dia = fechaUno.Subtract(fechaDos);
			}

			return dia;
		}

		public static int ObtenerAnioDiferencia(int fechaUno, int fechaDos, bool primerAC, bool segundoAC)
		{
			int anio = -1;
			int MAXANO = Convert.ToInt32(DateTime.MaxValue.Year);
			int MINANO = 1;

			//Comprobación Numérica + Dentro de Rangos
			if ((Int32.TryParse(fechaUno.ToString(), out int primerAno)) && (Int32.TryParse(fechaDos.ToString(), out int segundoAno)))
			{
				if (((primerAno > MINANO) && (primerAno < MAXANO)) && ((segundoAno > MINANO) && (segundoAno < MAXANO)))
				{
					if (primerAC)
					{
						primerAno *= -1;
					}
					if (segundoAC)
					{
						segundoAno *= -1;
					}

					anio = Math.Abs(primerAno - segundoAno);
				}
			}

			return anio;
		}
		public static double[] CalculoDiferencia(Datos.Fechas[] newFechas)
        {
			double[] diffAnos = new double[2];
			DateTime ano0 = new DateTime(0001, 01, 01);
			DateTime fecha1 = newFechas[0].Fecha;
			DateTime fecha2 = newFechas[1].Fecha;
			TimeSpan diff1 = fecha1.Subtract(ano0);
			double days1= Math.Abs(diff1.TotalDays);
			int Ac1=1;
			if (newFechas[0].AC)
            {
				Ac1 = -1;
            }
			TimeSpan diff2 = fecha2.Subtract(ano0);
			double days2= Math.Abs(diff2.TotalDays); ;
			int Ac2 = 1;
			if (newFechas[1].AC)
			{
				Ac2 = -1;
			}
			double diffdays = Math.Abs(days1*Ac1-days2*Ac2);
			int anos = 0;
            if (days1 >= days2)
            {
				for (int vueltas = fecha2.Year; vueltas < fecha1.Year; vueltas++)
				{
					if (diffdays > 365)
					{
						if (!DateTime.IsLeapYear(vueltas))
						{
							diffdays -= 365;
							anos++;
						}
						else
						{
							diffdays -= 366;
							anos++;
						}
					}

				}
			}
            if (days2>days1)
            {
				for (int vueltas = fecha1.Year; vueltas < fecha2.Year; vueltas++)
				{
					if (diffdays > 365)
					{
						if (!DateTime.IsLeapYear(vueltas))
						{
							diffdays -= 365;
							anos++;
						}
						else
						{
							diffdays -= 366;
							anos++;
						}
					}
				}
			}
			diffAnos[0] = anos;
			diffAnos[1] = diffdays;
			return diffAnos;
		}
		public static double[] CalculoDiferenciaActualFecha(Datos.Fechas newFechas)
        {
			double[] diffActual1 = new double[2];
			DateTime ano0 = new DateTime(0001, 01, 01);
			DateTime fecha = DateTime.Now;
			DateTime Actual = newFechas.Fecha;
			TimeSpan diff1 = fecha.Subtract(ano0);
			double days1 = Math.Abs(diff1.TotalDays);
			int Ac1 = 1;
			if (newFechas.AC)
			{
				Ac1 = -1;
			}
			TimeSpan diffActual = Actual.Subtract(ano0);
			double daysActual = Math.Abs(diffActual.TotalDays); ;
			double diffdays = Math.Abs(days1 * Ac1 - daysActual);
			int anos = 0;
			if (days1 >= daysActual)
			{
				for (int vueltas = Actual.Year; vueltas < fecha.Year; vueltas++)
				{
					if (diffdays > 365)
					{
						if (!DateTime.IsLeapYear(vueltas))
						{
							diffdays -= 365;
							anos++;
						}
						else
						{
							diffdays -= 366;
							anos++;
						}
					}

				}
			}
			if (daysActual > days1)
			{
				for (int vueltas = fecha.Year; vueltas < Actual.Year; vueltas++)
				{
					if (diffdays > 365)
					{
						if (!DateTime.IsLeapYear(vueltas))
						{
							diffdays -= 365;
							anos++;
						}
						else
						{
							diffdays -= 366;
							anos++;
						}
					}

				}
			}
			diffActual1[0] = anos;
			diffActual1[1] = (int)Math.Floor(diffdays);
			return diffActual1;
		}

		//Calcula la edad en años correspondiente a cada fecha para la fecha actual, en años y en días.	
	}
}



//public static int ObtenerAnioDiferencia(int fechaUno, int fechaDos, bool primerAC, bool segundoAC)
//{
//	int anio = -1;
//	int MAXANO = Convert.ToInt32(DateTime.MaxValue.Year);
//	int MINANO = 1;

//	//Comprobación Numérica + Dentro de Rangos
//	if ((Int32.TryParse(fechaUno.ToString(), out int primerAno)) && (Int32.TryParse(fechaDos.ToString(), out int segundoAno)))
//	{
//		if (((primerAno > MINANO) && (primerAno < MAXANO)) && ((segundoAno > MINANO) && (segundoAno < MAXANO)))
//		{
//			if (primerAC)
//			{
//				primerAno *= -1;
//			}
//			if (segundoAC)
//			{
//				segundoAno *= -1;
//			}

//			anio = Math.Abs(primerAno - segundoAno);
//		}
//	}

//	return anio;
//}