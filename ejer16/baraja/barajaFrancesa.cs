using System;
using System.Collections.Generic;
using System.Text;
using static baraja.carta;

namespace baraja
{
    class barajaFrancesa : baraja
    {
        public barajaFrancesa()
        {
            this.NumCartas();
        }

        public void NumCartas()
        {
            this.cartas_X_Palo = 13 ;
            this.crearBarajas(this.cartas, cartas_X_Palo);
        }

        public override void crearBarajas(List<carta> cartas, int cartas_X_Palo)
        {
            
            Array palos = obtenerPalos("Palo frances");
            
            if (palos == null)
            {
                Console.WriteLine("error, ese palo no existe");
            }
            else
            {
                //Console.WriteLine((PalosBarEspañola)palos.GetValue(2));

                for (int i = 0; i < palos.Length; i++)
                {
                    for (int l = 1; l <= cartas_X_Palo; l++)
                    {
                        PalosBarEspañola a = (PalosBarEspañola)palos.GetValue(i);
                        this.cartas.Add(new carta(l, a));
                    }
                }

            }
        }

        
        public bool cartaRoja(carta c)
        {

            Array palos = obtenerPalos("Palo frances");
            PalosBarajaFrancesa a = (PalosBarajaFrancesa)palos.GetValue(0);


            return (c.PaloF == (PalosBarajaFrancesa)palos.GetValue(0) || c.PaloF == (PalosBarajaFrancesa)palos.GetValue(2));
        }
       
        public bool cartaNegra(carta c)
        {
            Array palos = obtenerPalos("Palo frances");
            PalosBarajaFrancesa a = (PalosBarajaFrancesa)palos.GetValue(0);

            return (c.PaloF == (PalosBarajaFrancesa)palos.GetValue(1) || c.PaloF == (PalosBarajaFrancesa)palos.GetValue(3));
        }



    }
}
