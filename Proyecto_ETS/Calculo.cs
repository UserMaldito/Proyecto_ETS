using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ETS
{
	class Calculo
	{
		//La edad en años correspondiente a cada fecha para la fecha actual, en años y en días.				 La diferencia entre las dos fechas, en años y en días.
		public static int[] Edad(DateTime fechaUno, DateTime fechaDos)
		{
			int[] almacen = new int[2];

			//Defino arrays para ordenarlos
			int[] auxDia = { fechaUno.Day, fechaDos.Day };
			int[] auxYear = { fechaUno.Year, fechaDos.Year };

			Array.Sort(auxDia);
			Array.Sort(auxYear);

			almacen[0] = Math.Abs(auxDia[0] - auxDia[1]);
			almacen[1] = Math.Abs(auxYear[0] - auxYear[1]);

			return almacen;
		}






	}
}
