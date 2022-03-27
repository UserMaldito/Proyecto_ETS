using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_ETS;

namespace Pruebas_ETS
{
	[TestClass]
	public class RealizandoPruebas
	{
		//Probando Clase Datos
		//[TestMethod]
		//[DataRow(2012, 2012, false, true)]      //Clear	(número positivo, bisiesto)
		//[DataRow(2011, 2011, false, false)]     //Clear (número positivo, NO bisiesto)
		//[DataRow(-2012, -1, false, false)]    //ERROR (número negativo, bisiesto)
		//[DataRow(-2011, -1, false, false)]   //ERROR (número negativo, NO bisiesto)
		//public void ClaseDatosAnoPrueba(int numero, int resultadoEsperado, bool bisiesto, bool bisiestoEsperado)
		//{
		//	//Act
		//	int numeroEsperado = Datos.ObtenerAnoUnitTest(numero, ref bisiesto);

		//	//Assert
		//	Assert.AreEqual(resultadoEsperado, numeroEsperado);     //Comparando Número
		//	Assert.AreEqual(bisiestoEsperado, bisiesto);            //Comparando Bisiesto
		//}


		//[TestMethod]
		//[DataRow(12, 12)]        //Clear (número positivo, DENTRO Rango)
		//[DataRow(-11, -1)]      //Clear (número negativo, DENTRO Rango)
		//[DataRow(2012, -1)]    //ERROR (número positivo, FUERA Rango)
		//[DataRow(-2011, -1)]   //ERROR (número negativo, FUERA Rango)
		//public void ClaseDatosMesPrueba(int numero, int resultadoEsperado)
		//{
		//	//Act
		//	int numeroEsperado = Datos.ObtenerMesUnitTest(numero);

		//	//Assert
		//	Assert.AreEqual(resultadoEsperado, numeroEsperado);     //Comparando Número
		//}

		[TestMethod]
		[DataRow(1, 1, false, 1)]      //Clear (número positivo, DENTRO Rango)
		//[DataRow(-11, -1)]     //Clear (número negativo, DENTRO Rango)
		//[DataRow(2012, -1)]    //ERROR (número positivo, FUERA Rango)
		//[DataRow(-2011, -1)]   //ERROR (número negativo, FUERA Rango)
		public void ClaseDatosDiaPrueba(int dia, int mes, bool bisiesto, int resultadoEsperado)
		{
			//Act
			int numeroEsperado = Datos.ObtenerDiaUnitTest(dia, mes, bisiesto);

			//Assert
			Assert.AreEqual(resultadoEsperado, numeroEsperado);     //Comparando Número
		}




	}
}
