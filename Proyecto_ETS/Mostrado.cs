using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ETS
{
    class Mostrado
    {
        public static void MostradoDiff(Datos.Fechas[] newFechas, double[] diff)
        {
            string Ac1 = "";
            if (newFechas[0].AC)
            {
                Ac1 = "AC";
            }
            else
            {
                Ac1 = "DC";
            }
            string Ac2 = "";
            if (newFechas[1].AC)
            {
                Ac2 = "AC";
            }
            else
            {
                Ac2 = "DC";
            }
            Console.WriteLine("La diferencia entre {0} {1} y {2} {3} es {4} años y {5} días.",(newFechas[0].Fecha).ToShortDateString(),Ac1,
                (newFechas[1].Fecha).ToShortDateString(),Ac2,diff[0],diff[1]);
        }
        public static void MostradoDiffOrigen(Datos.Fechas newFechas, double[] diff)
        {
            string Ac = "";
            if (newFechas.AC)
            {
                Ac = "AC";
            }
            else
            {
                Ac = "DC";
            }
            
            Console.WriteLine("La diferencia entre {0} {1} y {2} DC es {3} años y {4} días.", (newFechas.Fecha).ToShortDateString(), Ac,
                DateTime.Now.ToShortDateString(), diff[0], diff[1]);
        }
    }
}
