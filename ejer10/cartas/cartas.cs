using System;
using System.Collections.Generic;
using System.Text;

namespace cartas
{
    class cartas
    {
        private int numero;
        private string palo;

        public cartas(int numero, string palo)
        {
            this.numero = numero;
            this.palo = palo;
        }

        public string Palo
        {
            get
            {
                return this.palo;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;

            }
        }

        public string describirCarta()
        {
            return "el numero de la carta es: "+this.numero+ " y el palo es :" + this.palo;
        }
    }
}
