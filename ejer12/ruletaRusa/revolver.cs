using System;
using System.Collections.Generic;
using System.Text;

namespace ruletaRusa
{
    class revolver
    {
        private double posicionActual;
        private double posicionBala;

        public revolver(double posicionActual, double posicionBala)
        {
            this.posicionActual = posicionActual;
            this.posicionBala = posicionBala;
        }

        public bool disparar()
        {
            if(this.posicionActual == this.posicionBala)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void siguienteBala()
        {
            this.posicionActual = this.posicionActual + 1;
        }

        public virtual void toString()
        {
            Console.WriteLine("La posicion actual de la bala es desconocida: y la posicion actual esta en: " +this.posicionActual);

        }


    }
}
