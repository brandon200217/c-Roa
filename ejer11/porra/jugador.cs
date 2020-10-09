using System;
using System.Collections.Generic;
using System.Text;

namespace porra
{
    class jugador
    {
        private double dinero;
        private string nombre;
        private int porrasGanadas = 0;

        public jugador(double dinero,string nombre)
        {
            this.dinero = dinero;
            this.nombre = nombre;
        }

        public double Dinero
        {
            get{

                return this.dinero;
            }
        }
        public string Nombre
        {
            get
            {

                return this.nombre;
            }
        }

        public int PorrasGanadas
        {
            get
            {

                return this.porrasGanadas;
            }
            set
            {
                this.porrasGanadas = value;
            }
        }

        public double darDinero()
        {
            if (this.dinero >= 2)
            {
                //Console.WriteLine("dinero ante de la apuesta"+this.dinero);

                this.dinero = this.dinero - 2;
                //Console.WriteLine("dinero despues de la apuesta" + this.dinero);

                return 2;
            }
            else
            {
                return 0;
            }

        }

        public int apuesta()
        {
            Random numRandom = new Random();
            return numRandom.Next(0, 10);

        }

        public void sumarVictoria(bool victoria)
        {
            if (victoria == true)
            {

                this.porrasGanadas = this.porrasGanadas + 1;
                Console.WriteLine("----------------------------");
                Console.WriteLine("victorias "+this.porrasGanadas);
                Console.WriteLine("----------------------------");
               
            }

        }


        public void ganarPorra(double dineroPorra)
        {
            this.dinero = this.dinero + dineroPorra;
        }

        public new virtual string ToString()
        {
            return "el jugador " + this.nombre + " tiene " + this.dinero+"$"; 
        }
        
    }

}
