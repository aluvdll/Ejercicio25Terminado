using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio25
{
    internal class Cumpleaños:Fiesta
    {
        private static double PRECIO_TAMAÑO_TARTA_PEQUEÑA = 40;
        private static double PRECIO_TAMAÑO_TARTA_GRANDE = 75;
        private bool textoTarta;
        public static int HASTA_OCHO_PERSONAS = 8;

        

        

        public override double calcularCoste()
        {
           
            if (base.NumPersonas > HASTA_OCHO_PERSONAS)
            {
                return base.calcularCoste()+PRECIO_TAMAÑO_TARTA_GRANDE;
            }
            else
            {
                return base.calcularCoste() + PRECIO_TAMAÑO_TARTA_PEQUEÑA;
            }
        }

    }
}
