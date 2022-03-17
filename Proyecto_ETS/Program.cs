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
			DateTime primeraFecha = new DateTime(2018, 06, 01);
			DateTime segundaFecha = new DateTime(2022, 03, 13);
			int[] auxilio = Calculo.Edad(primeraFecha, segundaFecha);


			int x = 0;

		}

		/*
		 * 
		 * Realizar una aplicación con interfaz de línea de comando que:
			 * Lea dos fechas 
			 * Valide las fechas según su formato (1)
			 * Presente en pantalla:
			 * La edad en años correspondiente a cada fecha para la fecha actual, en años y en días.
			 * La diferencia entre las dos fechas, en años y en días. (2)
		 
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