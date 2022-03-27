using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_ETS;

namespace Pruebas_ETS
{
	[TestClass]
	public class RealizandoPruebas
	{
		//Probando Clase Datos
		//[TestMethod]
		//[DataRow(2012, 2012, false, true)]      //Clear	(n�mero positivo, bisiesto)
		//[DataRow(2011, 2011, false, false)]     //Clear (n�mero positivo, NO bisiesto)
		//[DataRow(-2012, -1, false, false)]    //ERROR (n�mero negativo, bisiesto)
		//[DataRow(-2011, -1, false, false)]   //ERROR (n�mero negativo, NO bisiesto)
		//public void ClaseDatosAnoPrueba(int numero, int resultadoEsperado, bool bisiesto, bool bisiestoEsperado)
		//{
		//	//Act
		//	int numeroEsperado = Datos.ObtenerAnoUnitTest(numero, ref bisiesto);

		//	//Assert
		//	Assert.AreEqual(resultadoEsperado, numeroEsperado);     //Comparando N�mero
		//	Assert.AreEqual(bisiestoEsperado, bisiesto);            //Comparando Bisiesto
		//}


		//[TestMethod]
		//[DataRow(12, 12)]        //Clear (n�mero positivo, DENTRO Rango)
		//[DataRow(-11, -1)]      //Clear (n�mero negativo, DENTRO Rango)
		//[DataRow(2012, -1)]    //ERROR (n�mero positivo, FUERA Rango)
		//[DataRow(-2011, -1)]   //ERROR (n�mero negativo, FUERA Rango)
		//public void ClaseDatosMesPrueba(int numero, int resultadoEsperado)
		//{
		//	//Act
		//	int numeroEsperado = Datos.ObtenerMesUnitTest(numero);

		//	//Assert
		//	Assert.AreEqual(resultadoEsperado, numeroEsperado);     //Comparando N�mero
		//}

		[TestMethod]
		[DataRow(1, 1, false, 1)]      //Clear (n�mero positivo, DENTRO Rango)
		//[DataRow(-11, -1)]     //Clear (n�mero negativo, DENTRO Rango)
		//[DataRow(2012, -1)]    //ERROR (n�mero positivo, FUERA Rango)
		//[DataRow(-2011, -1)]   //ERROR (n�mero negativo, FUERA Rango)
		public void ClaseDatosDiaPrueba(int dia, int mes, bool bisiesto, int resultadoEsperado)
		{
			//Act
			int numeroEsperado = Datos.ObtenerDiaUnitTest(dia, mes, bisiesto);

			//Assert
			Assert.AreEqual(resultadoEsperado, numeroEsperado);     //Comparando N�mero
		}




	}
}
