using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ETS
{
    class Datos
    {
        public struct Fechas
        {
            public DateTime Fecha;
            public bool AC;
        }
        public static void MontarStruct(Datos.Fechas[] newFechas)
        {
            const int MAXFECHAS = 2;
            for (int meterFechas = 0; meterFechas < MAXFECHAS; meterFechas++)
            {
                newFechas[meterFechas].AC = Datos.ObtenerAC();
                int[] fechaInt = Datos.ObtenerFecha();
                DateTime fecha = Datos.crearDateTime(fechaInt);
                newFechas[meterFechas].Fecha = fecha;
                Console.Clear();
            }
        }
        /// <summary>
        /// Función que recoge las funciones necesarias para generar un array int con una fecha válida (solo DC)
        /// </summary>
        /// <returns>Array Int con dia mes y año</returns>
        public static int[] ObtenerFecha()
        {
            bool bisiesto = false;
            int ano = Datos.ObtenerAno(ref bisiesto);
            int mes = Datos.ObtenerMes();
            int dia = Datos.ObtenerDia(mes, bisiesto);
            int[] fecha = Datos.MontarFecha(ano, mes, dia);
            return (fecha);
        }
        /// <summary>
        /// Pide al usuario que introduzca un número entero para almacenarlo como año
        /// </summary>
        /// <param name="bisiesto"> booleano que informara si el año es bisiesto o no</param>
        /// <returns>Int con la información atribuida a año, asi como si el año es bisiesto o no</returns>
        public static int ObtenerAno(ref bool bisiesto)
        {
            int ano;
            bool siguiente = false;
            do
            {
                Console.WriteLine("Introduzca el año a tratar (en número)");
                if (Int32.TryParse(Console.ReadLine(), out ano))
                {
                    if (ano > 0)
                    {
                        if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0)
                        {
                            bisiesto = true;
                        }
                        siguiente = true;
                    }
                    else
                    {
                        Console.WriteLine("el año no puede ser negativo o 0");
                    }                    
                }
                else
                {
                    Console.WriteLine("El año introducido no es un número válido");
                }
            } while (!siguiente);
            return ano;
        }
        /// <summary>
        /// Pide al usuario que introduzca un número entero para almacenarlo como mes
        /// </summary>
        /// <returns>Int que almacenara el mes introducido por el usuario, por referencia si el año es bisiesto o no</returns>
        public static int ObtenerMes()
        {
            int mes;
            bool siguiente = false;
            do
            {
                Console.WriteLine("Introduzca el mes a tratar (en número)");
                if (Int32.TryParse(Console.ReadLine(), out mes))
                {
                    if (mes > 0)
                    {
                        if (mes < 13)
                        {
                            siguiente = true;
                        }
                        else
                        {
                            Console.WriteLine("El mes no puede ser mayor de 12.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El mes no puede ser menor de 0.");
                    }
                }
                else
                {
                    Console.WriteLine("No ha introducido un dato numérico.");
                }
            } while (!siguiente);
            return mes;
        }
        /// <summary>
        /// Funcion que obtiene el dia, comprobando si es válido
        /// </summary>
        /// <param name="mes">Int que almacena el mes introducido por el usuario</param>
        /// <param name="bisiesto"> booleano que informara si el año es bisiesto o no</param>
        /// <returns>Int que almacena el dia introducido por el usuario</returns>
        public static int ObtenerDia(int mes, bool bisiesto)
        {
            int dia;
            bool siguiente = false;
            string errordia = "El día introducido se sale de los rangos válidos";
            do
            {
                Console.WriteLine("Introduzca el día a tratar");
                if (Int32.TryParse(Console.ReadLine(), out dia))
                {
                    if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                    {
                        if (dia >= 1 && dia <= 31)
                        {
                            siguiente = true;
                        }
                        else
                        {
                            Console.WriteLine(errordia);
                        }
                    }
                    else
                    {
                        if (mes != 2)
                        {
                            if (dia >= 1 && dia <= 30)
                            {
                                siguiente = true;
                            }
                            else
                            {
                                Console.WriteLine(errordia);
                            }
                        }
                        else
                        {
                            if (bisiesto)
                            {
                                if (dia >= 1 && dia <= 29)
                                {
                                    siguiente = true;
                                }
                                else
                                {
                                    Console.WriteLine(errordia);
                                }
                            }
                            else
                            {
                                if (dia >= 1 && dia <= 28)
                                {
                                    siguiente = true;
                                }
                                else
                                {
                                    Console.WriteLine(errordia);
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No ha introducido un dato numérico");
                }
            } while (!siguiente);
            return dia;
        }
        /// <summary>
        /// Construye un array de int para montar el Datetime
        /// </summary>
        /// <param name="ano">Int donde almacenamos el año</param>
        /// <param name="mes">Int donde se almacena el mes</param>
        /// <param name="dia">Int donde se almacena el día</param>
        /// <returns>Array de int con los datos necesarios para generar un DateTime</returns>
        public static int[] MontarFecha(int ano, int mes, int dia)
        {
            int[] fecha = new int[3];
            fecha[0] = dia;
            fecha[1] = mes;
            fecha[2] = ano;
            return fecha;

        }
        /// <summary>
        /// Convierte el array de int "fecha" en un DateTime
        /// </summary>
        /// <param name="fecha">Array de int con los datos necesarios para generar un DateTime</param>
        /// <returns>DateTime que se almacenará en struct</returns>
        public static DateTime crearDateTime(int[] fecha)
        {
            DateTime modFecha = new DateTime(fecha[2], fecha[1], fecha[0]);
            return modFecha;
        }
        /// <summary>
        /// Método que pregunta al usuario si la fecha es antes o despues de cristo
        /// </summary>
        /// <returns>Booleano que si es true la fecha sera Antes de Cristo</returns>
        public static bool ObtenerAC()
        {
            bool siguiente = false;
            bool AC = false;
            int numIntrod;
            do
            {
                Console.WriteLine("Pulse 1 para año antes de Cristo, pulse 2 para despues de Cristo");
                if (int.TryParse(Console.ReadLine(), out numIntrod))
                {
                    if (numIntrod == 1)
                    {
                        AC = true;
                        siguiente = true;
                    }
                    else
                    {
                        if (numIntrod == 2)
                        {
                            AC = false;
                            siguiente = true;
                        }
                        else
                        {
                            Console.WriteLine("Ha introducido un número diferente");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ha introducido un dato en formato no válido");
                }
            } while (!siguiente);
            return AC;
        }
    }
}
