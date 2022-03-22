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