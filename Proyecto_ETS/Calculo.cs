using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ETS
{
	class Calculo
	{
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
	}
}
