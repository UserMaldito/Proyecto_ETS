using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_ETS;

namespace Pruebas_ETS
{
	[TestClass]
	public class UnitTest1
	{
		//Probando Clase Datos
		[TestMethod]
		[DataRow (2012, false, true, 2012)]
		public void ClaseDatosPrueba(int numero, bool bisiesto, bool bisiestoEsperado, int resultadoEsperado)
		{
			//Act
			int numeroEsperado = Datos.ObtenerAno(ref bisiesto);

			//Assert
			Assert.AreEqual(resultadoEsperado, numeroEsperado);
		}
	}
}
