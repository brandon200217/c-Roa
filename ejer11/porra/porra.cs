using System;
using System.Collections.Generic;
using System.Text;

namespace porra
{
    class porra
    {
        public const int partidas = 100;
        private double dineroPorra = 25;
        public porra(double dineroPorra)
        {
            this.dineroPorra = dineroPorra;
        }

        public void apostarPorra(double dineroPorra)
        {
            this.dineroPorra = this.dineroPorra + dineroPorra;
        }

        public double darDineroPorra()
        {
            return this.dineroPorra;
        }

        public void reiniciarPorra(List<jugador> jugadoresPorra)
        {
            for(int i = 0; i < jugadoresPorra.Count;i++)
            {
                jugadoresPorra[i].PorrasGanadas = 0;
            }
        }





    }
}
