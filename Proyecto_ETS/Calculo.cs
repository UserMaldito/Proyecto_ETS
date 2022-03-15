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

		/// <summary>Calcula la diferencia de 2 fechas</summary>
		/// <param name="fechaUno"></param>
		/// <param name="fechaDos"></param>
		/// <returns>Devuelve la diferencia en Días y en Años.</returns>
		public static int[] Edad(DateTime fechaUno, DateTime fechaDos)
		{
			int[] almacen = new int[2];

			//Defino arrays para ordenarlos
			int[] auxDia = { fechaUno.Day, fechaDos.Day };
			int[] auxYear = { fechaUno.Year, fechaDos.Year };

			Array.Sort(auxDia);
			Array.Sort(auxYear);

			almacen[0] = Math.Abs(auxDia[0] - auxDia[1]);		//DiaDiff
			almacen[1] = Math.Abs(auxYear[0] - auxYear[1]);		//AñoDiff

			return almacen;
		}

		//Calcula la edad en años correspondiente a cada fecha para la fecha actual, en años y en días.





	}
}
