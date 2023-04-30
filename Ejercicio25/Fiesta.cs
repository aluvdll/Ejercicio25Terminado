using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio25
{
    public class Fiesta 
    {
        private int numPersonas;
        private double costeDecoracion;
        private bool decoracionLujo;
        protected int costeFijoPersona;

        public int NumPersonas { get => numPersonas; set => numPersonas = value; }
        public bool DecoracionLujo { get => decoracionLujo; set => decoracionLujo = value; }

        public double CosteDecoracion { get; set; }

        public virtual double CalcularCosteDecoracion() 
        {
            if (numPersonas > 0)
            {


                if (decoracionLujo == true)
                {
                    costeDecoracion = 15;
                    costeDecoracion *= NumPersonas;
                    costeDecoracion += 50;
                    return costeDecoracion;
                }

                else
                {
                    costeDecoracion = 7.50;
                    costeDecoracion *= NumPersonas;
                    costeDecoracion += 30;
                    return costeDecoracion;
                }
            }
            else
            {
                return costeDecoracion = 0;
            }
        }

        public virtual double calcularCoste() 
        { 
            costeFijoPersona= 25;
            double totalCoste = costeFijoPersona * NumPersonas;
            totalCoste+=CalcularCosteDecoracion();

            return totalCoste;
        }
    }
}
