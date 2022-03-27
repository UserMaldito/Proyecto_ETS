using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Proyecto_ETS;

namespace Pruebas_ETS
{

	[TestClass]
	public class RealizandoPruebasDatos
	{
		[TestMethod]
		[DataRow(2012, 2012, false, true)]      //Clear	(número positivo, bisiesto)
		[DataRow(2011, 2011, false, false)]     //Clear (número positivo, NO bisiesto)
		[DataRow(-2012, -1, false, false)]    //ERROR (número negativo, bisiesto)
		[DataRow(-2011, -1, false, false)]   //ERROR (número negativo, NO bisiesto)
		public void ClaseDatosAnoPrueba(int numero, int resultadoEsperado, bool bisiesto, bool bisiestoEsperado)
		{
			//Act
			int numeroEsperado = Datos.ObtenerAnoUnitTest(numero, ref bisiesto);

			//Assert
			Assert.AreEqual(resultadoEsperado, numeroEsperado);     //Comparando Número
			Assert.AreEqual(bisiestoEsperado, bisiesto);            //Comparando Bisiesto
		}


		[TestMethod]
		[DataRow(12, 12)]        //Clear (número positivo, DENTRO Rango)
		[DataRow(-11, -1)]      //Clear (número negativo, DENTRO Rango)
		[DataRow(2012, -1)]    //ERROR (número positivo, FUERA Rango)
		[DataRow(-2011, -1)]   //ERROR (número negativo, FUERA Rango)
		public void ClaseDatosMesPrueba(int numero, int resultadoEsperado)
		{
			//Act
			int numeroEsperado = Datos.ObtenerMesUnitTest(numero);

			//Assert
			Assert.AreEqual(resultadoEsperado, numeroEsperado);     //Comparando Número
		}

		[TestMethod]
		[DataRow(1, 1, false, 1)]      //Clear (número positivo, DENTRO Rango, ENERO(31))
		[DataRow(31, 1, false, 31)]    //Clear (número positivo, DENTRO Rango, ENERO)
		[DataRow(32, 1, false, -1)]    //ERROR (número positivo, FUERA  Rango, ENERO)
		[DataRow(-3, 1, false, -1)]    //ERROR (número negativo, ENERO)

		[DataRow(1, 2, false, 1)]      //Clear (número positivo, DENTRO Rango, FEBRERO(28), NO bisiesto)
		[DataRow(28, 2, false, 28)]    //Clear (número positivo, DENTRO Rango, FEBRERO, NO bisiesto)
		[DataRow(29, 2, false, -1)]    //ERROR (número positivo, FUERA  Rango, FEBRERO, NO bisiesto)
		[DataRow(-3, 2, false, -1)]    //ERROR (número negativo, FEBRERO, NO bisiesto)

		[DataRow(1, 2, true, 1)]      //Clear (número positivo, DENTRO Rango, FEBRERO(29), bisiesto)
		[DataRow(29, 2, true, 29)]    //Clear (número positivo, DENTRO Rango, FEBRERO, bisiesto)
		[DataRow(31, 2, true, -1)]    //ERROR (número positivo, FUERA  Rango, FEBRERO, bisiesto)
		[DataRow(-3, 2, true, -1)]    //ERROR (número negativo, FEBRERO, bisiesto)

		[DataRow(1, 3, false, 1)]      //Clear (número positivo, DENTRO Rango, MARZO(31))
		[DataRow(31, 3, false, 31)]    //Clear (número positivo, DENTRO Rango, MARZO)
		[DataRow(32, 3, false, -1)]    //ERROR (número positivo, FUERA  Rango, MARZO)
		[DataRow(-3, 3, false, -1)]    //ERROR (número negativo, MARZO)

		[DataRow(1, 4, false, 1)]      //Clear (número positivo, DENTRO Rango, ABRIL(30))
		[DataRow(30, 4, false, 30)]    //Clear (número positivo, DENTRO Rango, ABRIL)
		[DataRow(31, 4, false, -1)]    //ERROR (número positivo, FUERA  Rango, ABRIL)
		[DataRow(-3, 4, false, -1)]    //ERROR (número negativo, ABRIL)

		[DataRow(1, 5, false, 1)]      //Clear (número positivo, DENTRO Rango, MAYO(31))
		[DataRow(31, 5, false, 31)]    //Clear (número positivo, DENTRO Rango, MAYO)
		[DataRow(32, 5, false, -1)]    //ERROR (número positivo, FUERA  Rango, MAYO)
		[DataRow(-3, 5, false, -1)]    //ERROR (número negativo, MAYO)

		[DataRow(1, 6, false, 1)]      //Clear (número positivo, DENTRO Rango, JUNIO(30))
		[DataRow(30, 6, false, 30)]    //Clear (número positivo, DENTRO Rango, JUNIO)
		[DataRow(31, 6, false, -1)]    //ERROR (número positivo, FUERA  Rango, JUNIO)
		[DataRow(-3, 6, false, -1)]    //ERROR (número negativo, JUNIO)

		[DataRow(1, 7, false, 1)]      //Clear (número positivo, DENTRO Rango, JULIO(31))
		[DataRow(31, 7, false, 31)]    //Clear (número positivo, DENTRO Rango, JULIO)
		[DataRow(32, 7, false, -1)]    //ERROR (número positivo, FUERA  Rango, JULIO)
		[DataRow(-3, 7, false, -1)]    //ERROR (número negativo, JULIO)

		[DataRow(1, 8, false, 1)]      //Clear (número positivo, DENTRO Rango, AGOSTO(31))
		[DataRow(31, 8, false, 31)]    //Clear (número positivo, DENTRO Rango, AGOSTO)
		[DataRow(32, 8, false, -1)]    //ERROR (número positivo, FUERA  Rango, AGOSTO)
		[DataRow(-3, 8, false, -1)]    //ERROR (número negativo, AGOSTO)

		[DataRow(1, 9, false, 1)]      //Clear (número positivo, DENTRO Rango, SEPTIEMBRE(30))
		[DataRow(30, 9, false, 30)]    //Clear (número positivo, DENTRO Rango, SEPTIEMBRE)
		[DataRow(31, 9, false, -1)]    //ERROR (número positivo, FUERA  Rango, SEPTIEMBRE)
		[DataRow(-3, 9, false, -1)]    //ERROR (número negativo, SEPTIEMBRE)

		[DataRow(1, 10, false, 1)]      //Clear (número positivo, DENTRO Rango, OCTUBRE(31))
		[DataRow(31, 10, false, 31)]    //Clear (número positivo, DENTRO Rango, OCTUBRE)
		[DataRow(32, 10, false, -1)]    //ERROR (número positivo, FUERA  Rango, OCTUBRE)
		[DataRow(-3, 10, false, -1)]    //ERROR (número negativo, OCTUBRE)

		[DataRow(1, 11, false, 1)]      //Clear (número positivo, DENTRO Rango, NOVIEMBRE(30))
		[DataRow(30, 11, false, 30)]    //Clear (número positivo, DENTRO Rango, NOVIEMBRE)
		[DataRow(31, 11, false, -1)]    //ERROR (número positivo, FUERA  Rango, NOVIEMBRE)
		[DataRow(-3, 11, false, -1)]    //ERROR (número negativo, NOVIEMBRE)

		[DataRow(1, 12, false, 1)]      //Clear (número positivo, DENTRO Rango, DICEMBRE(31))
		[DataRow(31, 12, false, 31)]    //Clear (número positivo, DENTRO Rango, DICEMBRE)
		[DataRow(32, 12, false, -1)]    //ERROR (número positivo, FUERA  Rango, DICEMBRE)
		[DataRow(-3, 12, false, -1)]    //ERROR (número negativo, DICEMBRE)
		public void ClaseDatosDiaPrueba(int dia, int mes, bool bisiesto, int resultadoEsperado)
		{
			//Act
			int numeroEsperado = Datos.ObtenerDiaUnitTest(dia, mes, bisiesto);

			//Assert
			Assert.AreEqual(resultadoEsperado, numeroEsperado);     //Comparando Número
		}

		[TestMethod]
		[DataRow(1, 1, true)]               //Clear	(DENTRO rango, AntesCristo)
		[DataRow(2, 2, false)]              //Clear (DENTRO rango, AntesCristo)
		[DataRow(-2012, -1, false)]         //ERROR (FUERA  rango)
		public void ClaseDatosACPrueba(int numero, int numeroEsperado, bool esperado)
		{
			//Act
			bool resultado = Datos.ObtenerACUnitTest(ref numero);

			//Assert
			Assert.AreEqual(esperado, resultado);             //Comparando Bool
			Assert.AreEqual(numero, numeroEsperado);          //Comparando Numero
		}


	}
	[TestClass]
	public class RealizandoPruebasCalculo
	{
		public struct Example
		{
			public DateTime Fecha;
			public bool AC;
		}
		[TestMethod]
		//[DataRow(2012, 1, false, true)]      //Clear	(número positivo, bisiesto)
		//[DataRow(2011, 1, false, false)]     //Clear (número positivo, NO bisiesto)
		//[DataRow(-2012, -1, false, false)]    //ERROR (número negativo, bisiesto)
		//[DataRow(-2011, -1, false, false)]   //ERROR (número negativo, NO bisiesto)
		public void ClaseDatosAnoPrueba(int numero, int resultadoEsperado, bool bisiesto, bool bisiestoEsperado)
		{
			Datos.Fechas example = new Datos.Fechas();

			//Act
			double[] numeroEsperado = Calculo.CalculoDiferenciaActualFechaUnitTest(example);

			//Assert
			Assert.AreEqual(resultadoEsperado, numeroEsperado);     //Comparando Número
			Assert.AreEqual(bisiestoEsperado, bisiesto);            //Comparando Bisiesto
		}

	}

}
