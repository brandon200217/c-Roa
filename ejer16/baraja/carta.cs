using System;
using System.Collections.Generic;
using System.Text;

namespace baraja
{
    class carta
    {
        private int numero;
        private PalosBarEspañola paloE;
        private PalosBarajaFrancesa paloF;


        public carta(int numero, PalosBarEspañola palo)
        {
            this.numero = numero;
            this.paloE = palo;

        }
        public carta(int numero, PalosBarajaFrancesa palosFrancesa)
        {
            this.numero = numero;
            this.paloF = palosFrancesa;

        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
            
        }

        public PalosBarEspañola PaloE
        {
            get
            {
                return this.paloE;
            }

        }

        public PalosBarajaFrancesa PaloF
        {
            get
            {
                return this.paloF;
            }

        }

        public enum PalosBarEspañola
        {
            oros,
            copas,
            espadas,
            bastos
        }

        public enum PalosBarajaFrancesa
        {
            diamantes,
            picas,
            treboles,
            corazones
        }

        public static Array obtenerPalos()
        {
            
            Array array = Enum.GetValues(typeof(PalosBarEspañola));
            return array;
            
        }
        public static Array obtenerPalos(string palo)
        {
            if (palo == "Palo frances")
            {
                Array array = Enum.GetValues(typeof(PalosBarEspañola));
                return array;
            }
           
            return null;

        }



        public string describirCarta(string tipoBaraja)
        {
            String nombreFigura = "";

            if (tipoBaraja == "Española") {
                

                switch (this.numero)
                {
                    case 1:
                        nombreFigura = "As";
                        break;
                    case 10:
                        nombreFigura = "Sota";
                        break;
                    case 11:
                        nombreFigura = "Caballo";
                        break;
                    case 12:
                        nombreFigura = "Rey";
                        break;
                    default:
                        nombreFigura = Convert.ToString(this.numero);
                        break;
                }

            }
            else if(tipoBaraja == "Francesa")
            {
                switch (this.numero)
                {
                    case 1:
                        nombreFigura = "As";
                        break;
                    case 11:
                        nombreFigura = "Sota";
                        break;
                    case 12:
                        nombreFigura = "Caballo";
                        break;
                    case 13:
                        nombreFigura = "Rey";
                        break;
                    default:
                        nombreFigura = Convert.ToString(this.numero);
                        break;
                }
            }
 
            string valor = nombreFigura + " de " + this.paloE;
            return valor;
        }
    }
}
