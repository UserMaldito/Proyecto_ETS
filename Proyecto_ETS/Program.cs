using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ETS
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime primeraFecha = new DateTime(2012, 01, 01);
			DateTime segundaFecha = new DateTime(2013, 01, 01);
			DateTime fechaActual = DateTime.Today;

			TimeSpan prueba = segundaFecha.Subtract(primeraFecha);
			int dias =  prueba.Days;


			
			//Calculo de la Primera Fecha
			//int primerDiaDiff = Calculo.ObtenerDiaDiferencia(primeraFecha.Day, segundaFecha.Day);
			//int primerAnoDiff = Calculo.ObtenerAnioDiferencia(primeraFecha.Year, segundaFecha.Year);

			////Calculo de la Segunda Fecha vs Fecha Actual
			//int segundoDiaDiff = Calculo.ObtenerDiaDiferencia(primeraFecha.Day, fechaActual.Day);
			//int segundoAnoDiff = Calculo.ObtenerAnioDiferencia(primeraFecha.Year, fechaActual.Year);

			////Calculo de la Tercera Fecha vs Fecha Actual
			//int tercerDiaDiff = Calculo.ObtenerDiaDiferencia(segundaFecha.Day, fechaActual.Day);
			//int tercerAnoDiff = Calculo.ObtenerAnioDiferencia(segundaFecha.Year, fechaActual.Year);

		}

		/*
		 * 
		 * Realizar una aplicación con interfaz de línea de comando que:
			 * Lea dos fechas 
			 * Valide las fechas según su formato (1)
			 * Presente en pantalla:
			 * X La edad en años correspondiente a cada fecha para la fecha actual, en años y en días.
			 * X La diferencia entre las dos fechas, en años y en días. (2)
		 
		 * Análisis del proyecto. Hay que tener en cuenta las especificaciones del proyecto:
			 * Utilizaremos el calendario occidental (no el árabe, o el chino)
			 * Se deben tener en cuenta los años bisiestos (posible fase 2)
			 * Se deben tener en cuenta las fechas a.C. y d.C. (antes y después de Cristo) (posible fase 3)		
		 
		 * Subir un único archivo de proyecto .Net por grupo y que funcione en el Visual Studio de la Máquina Virtual utilizada en clase.
		 
		 * Elementos a valorar: Uso de Git y Github, Documentación (3) y buenas prácticas en el código, Uso de las pruebas unitarias (1 y 2) para demostrar que el código compartido esta probado, Aplicación de un ciclo de vida adecuado: prototipos, espiral, cascada..., División del trabajo evitando conflictos de solapamiento, bloqueos mutuos, manteniendo coherencia en el trabajo de cada miembro del grupo, etc.
		 * 
		 */
	}
}