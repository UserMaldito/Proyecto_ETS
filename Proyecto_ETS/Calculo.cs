using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ETS
{
	class Calculo
	{
		//La edad en años correspondiente a cada fecha para la fecha actual, en años y en días.				

		

		public static int ObtenerDiaDiferencia(int fechaUno, int fechaDos)
		{
			int dia = Math.Abs(fechaUno - fechaDos);
			
			return dia;
		}

		public static int ObtenerAnioDiferencia(int fechaUno, int fechaDos)
		{
			int anio = Math.Abs(fechaUno - fechaDos);

			return anio;
		}



		//Calcula la edad en años correspondiente a cada fecha para la fecha actual, en años y en días.


		/// <summary>Calcula la diferencia de 2 fechas</summary>
		/// <param name="fechaUno"></param>
		/// <param name="fechaDos"></param>
		/// <returns>Devuelve la diferencia en Días y en Años.</returns>
		//public static int[] Edad(DateTime fechaUno, DateTime fechaDos)
		//{
		//	int[] almacen = new int[2];

		//	//Defino arrays para ordenarlos

		//	int diaDiff = ObtenerDiaDiferencia(fechaUno, fechaDos);
		//	int anioDiff = ObtenerAnioDiferencia(fechaUno, fechaDos);

		//	return almacen;
		//}
	}
}
