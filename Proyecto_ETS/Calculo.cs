using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ETS
{
	public class Calculo
	{
		public static double[] CalculoDiferencia(Datos.Fechas[] newFechas)
		{
			double[] diffAnos = new double[2];

			DateTime ano0 = new DateTime(0001, 01, 01);
			DateTime fecha1 = newFechas[0].Fecha;
			DateTime fecha2 = newFechas[1].Fecha;
			TimeSpan diff1 = fecha1.Subtract(ano0);

			double days1 = Math.Abs(diff1.Days);
			int Ac1 = 1;
			if (newFechas[0].AC)
			{
				Ac1 = -1;
			}
			TimeSpan diff2 = fecha2.Subtract(ano0);
			double days2 = Math.Abs(diff2.Days);
			int Ac2 = 1;
			if (newFechas[1].AC)
			{
				Ac2 = -1;
			}
			double diffdays = Math.Abs(days1 * Ac1 - days2 * Ac2);

			int anoMayor = fecha2.Year;
			int anoMenor = fecha1.Year;
			if (fecha1.Year > fecha2.Year)
			{
				anoMayor = fecha1.Year;
				anoMenor = fecha2.Year;
			}

			int anos = 0;
			for (int vueltas = anoMenor; vueltas < anoMayor; vueltas++)
			{
				if (diffdays > 364)
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
				if (diffdays < 0)
				{
					diffdays = 0;
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

			double days1 = Math.Abs(diff1.Days);
			int Ac1 = 1;
			if (newFechas.AC)
			{
				Ac1 = -1;
			}
			TimeSpan diffActual = Actual.Subtract(ano0);
			double daysActual = Math.Abs(diffActual.Days);
			double diffdays = Math.Abs(days1 * Ac1 - daysActual);

			int anoMayor = fecha.Year;
			int anoMenor = newFechas.Fecha.Year;
			if (newFechas.Fecha.Year > fecha.Year)
			{
				anoMayor = newFechas.Fecha.Year;
				anoMenor = fecha.Year;
			}

			int anos = 0;
			for (int vueltas = anoMenor; vueltas < anoMayor; vueltas++)
			{
				if (diffdays > 364)
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
			diffActual1[0] = anos;
			diffActual1[1] = (int)Math.Floor(diffdays);

			return diffActual1;
		}

		//Funciones Iguales Para Hacer Pruebas Unitarias
		public static double[] CalculoDiferenciaUnitTest(Datos.Fechas[] newFechas)
		{
			double[] diffAnos = new double[2];

			DateTime ano0 = new DateTime(0001, 01, 01);
			DateTime fecha1 = newFechas[0].Fecha;
			DateTime fecha2 = newFechas[1].Fecha;
			TimeSpan diff1 = fecha1.Subtract(ano0);

			double days1 = Math.Abs(diff1.TotalDays);
			int Ac1 = 1;
			if (newFechas[0].AC)
			{
				Ac1 = -1;
			}
			TimeSpan diff2 = fecha2.Subtract(ano0);
			double days2 = Math.Abs(diff2.TotalDays);
			int Ac2 = 1;
			if (newFechas[1].AC)
			{
				Ac2 = -1;
			}
			double diffdays = Math.Abs(days1 * Ac1 - days2 * Ac2);

			int anoMayor = fecha2.Year;
			int anoMenor = fecha1.Year;
			if (fecha1.Year > fecha2.Year)
			{
				anoMayor = fecha1.Year;
				anoMenor = fecha2.Year;
			}

			int anos = 0;
			for (int vueltas = anoMenor; vueltas < anoMayor; vueltas++)
			{
				if (diffdays > 364)
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
			diffAnos[0] = anos;
			diffAnos[1] = diffdays;

			return diffAnos;
		}
		public static double[] CalculoDiferenciaActualFechaUnitTest(Datos.Fechas newFechas)
		{
			double[] diffActual1 = new double[2];

			DateTime ano0 = new DateTime(0001, 01, 01);
			DateTime fecha = DateTime.Now;
			DateTime Actual = newFechas.Fecha;
			TimeSpan diff1 = fecha.Subtract(ano0);

			double days1 = Math.Abs(diff1.Days);
			int Ac1 = 1;
			if (newFechas.AC)
			{
				Ac1 = -1;
			}
			TimeSpan diffActual = Actual.Subtract(ano0);
			double daysActual = Math.Abs(diffActual.Days);
			double diffdays = Math.Abs(days1 * Ac1 - daysActual);

			int anoMayor = fecha.Year;
			int anoMenor = newFechas.Fecha.Year;
			if (newFechas.Fecha.Year > fecha.Year)
			{
				anoMayor = newFechas.Fecha.Year;
				anoMenor = fecha.Year;
			}

			int anos = 0;
			for (int vueltas = anoMenor; vueltas < anoMayor; vueltas++)
			{
				if (diffdays > 364)
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
			diffActual1[0] = anos;
			diffActual1[1] = (int)Math.Floor(diffdays);

			return diffActual1;
		}




	}
}