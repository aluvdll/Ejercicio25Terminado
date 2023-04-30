using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
    internal class Cenas: Fiesta
    {
        private bool opcionSaludable;
        private int costeBebidaPersona;
        
        public bool OpcionSaludable { get => opcionSaludable; set => opcionSaludable = value; }

        public override double calcularCoste()
        {
            double totalCoste = base.calcularCoste();
            
            if(opcionSaludable==true)
            {
                costeBebidaPersona = 5;
                totalCoste=base.NumPersonas * costeBebidaPersona+base.calcularCoste();
                totalCoste -= ((totalCoste * 5/*5%dto.*/) / 100);
                return totalCoste;
            }
            else 
            {
                costeBebidaPersona = 20;
                totalCoste = base.NumPersonas * costeBebidaPersona + base.calcularCoste(); ;
                return totalCoste;
            }

            
          
        }
        

    }
}
