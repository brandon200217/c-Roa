using System;
using System.Collections.Generic;
using System.Text;
using static baraja.carta;

namespace baraja
{
    class barajaEspañola : baraja
    {
        private bool cartas_Sin_8_9;

        public barajaEspañola(bool cartas_Sin_8_9)
        {
            this.cartas_Sin_8_9 = cartas_Sin_8_9;

            this.NumCartas(this.cartas_Sin_8_9);
        
        }

        public void NumCartas(bool cartas_Sin_8_9)
        {
            if (cartas_Sin_8_9 == true)
            {

                this.cartas_X_Palo = 10;
            }
            else
            {
                this.cartas_X_Palo = 12;
            }

            this.crearBarajas(this.cartas, this.cartas_X_Palo);

        }
   
        public override void crearBarajas(List<carta> cartas, int cartas_X_Palo)
        {
            Array palos = obtenerPalos();

            Console.WriteLine((PalosBarEspañola)palos.GetValue(2));

            for (int i = 0; i < palos.Length ; i++)
            {
                for (int l = 1; l <= cartas_X_Palo; l++)
                {
                    if (this.cartas_Sin_8_9 == true)
                    {
                        PalosBarEspañola a = (PalosBarEspañola)palos.GetValue(i);
                        
                        if (l <= 7)
                        {
                            this.cartas.Add(new carta(l, a));
                        }
                        else
                        {
                            this.cartas.Add(new carta((l >= 8) ? l + 2 : l, a));
                        }
                    }
                    else{
                        PalosBarEspañola a = (PalosBarEspañola)palos.GetValue(i);
                        this.cartas.Add(new carta(l, a));
                    }
                }
            }
        }

    }
}
