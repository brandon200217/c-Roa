using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cartas
{
    class baraja
    {

        private List<cartas> cartas = new List<cartas>();
        private List<cartas> cartasDadas = new List<cartas>();
        
        public baraja()
        {
            
            this.espada(this.cartas);
            this.basto(this.cartas);
            this.basto(this.cartas);
            this.oro(this.cartas);
            this.copa(this.cartas);
        }

        public void espada(List<cartas> cartas)
        {
            for (int i = 1; i <= 12; i++) { 
                if (i <= 7)
                {
                    this.cartas.Add(new cartas(i, "espada"));
                }
                else
                {
                    this.cartas.Add(new cartas((i >= 8) ? i + 2 : i, "espada"));
                }
            }
        }

        public void basto(List<cartas> cartas)
        {
            for (int i = 1; i <= 12; i++)
            {
                if (i <= 7)
                {
                    this.cartas.Add(new cartas(i, "basto"));
                }
                else
                {
                    this.cartas.Add(new cartas((i >= 8) ? i + 2 : i, "basto"));
                }
            }
        }

        public void oro(List<cartas> cartas)
        {
            for (int i = 1; i <= 12; i++)
            {
                if (i <= 7)
                {
                    this.cartas.Add(new cartas(i, "oro"));
                }
                else
                {
                    this.cartas.Add(new cartas((i >= 8) ? i + 2 : i, "oro"));
                }
            }
        }

        public void copa(List<cartas> cartas)
        {
            for (int i = 1; i <= 12; i++)
            {
                if (i <= 7)
                {
                    this.cartas.Add(new cartas(i, "copa"));
                }
                else
                {
                    this.cartas.Add(new cartas((i >= 8) ? i + 2 : i, "copa"));
                }
            }
        }

        public void barajar()
        {
            List<cartas> cartasDesorganizadas = new List<cartas>();
            Random numRandom = new Random();

            int cantCartas = this.cartas.Count;

            for (int i = 0; i < cantCartas; i++)
            {
                int cartas = numRandom.Next(this.cartas.Count);
                cartasDesorganizadas.Add(this.cartas[cartas]);
                this.cartas.RemoveAt(cartas);
            }
            this.cartas = cartasDesorganizadas;
        }


        public cartas siguienteCarta()
        {
            if (this.cartas.Count > 0)
            {
                this.cartasDadas.Add(this.cartas[0]);
                this.cartas.RemoveAt(0);
                return cartasDadas.Last();
            }
            else
            {
                this.cartas = cartasDadas;
            }
            return null;
        }

        /*if (this.cartas.Count >= cant)
            {
            this.cartas_dadas.AddRange(cartas.Take(cant));
            this.cartas.RemoveRange(this.cartas.Count - 1 - cant, cant);
            return cartas_dadas.TakeLast(cant).ToArray();
        }*/


        public List<cartas> darCartas(int cant)
        {
            if (this.cartas.Count <= cant)
            {
                for (int i = 0; i < this.cartas.Count; i++)
                {
                    cartasDadas.Add(this.cartas[i]);
                }
                return cartasDadas;
            }
            else
            {
                return null;
            }       
        }

        
        public void cartasMonton()
        {
            //Console.WriteLine(this.cartasDadas.Count);
            if (this.cartasDadas.Count == 0)
            {
                Console.WriteLine("No hay cartas disponibles");

            }
            else
            {
                foreach (cartas carta in cartasDadas)
                {
                    Console.WriteLine(carta.describirCarta());
                }
            }
           
        }

        public void cartasDisponibles()
        {
            Console.WriteLine(this.cartas.Count+" son las cartas que aun se pueden repartir");
        }

        
        public void mostrarBaraja()
        {
            if (this.cartas.Count == 0)
            {
                Console.WriteLine("No hay cartas que mostrar");
            }
            else
            {
                foreach (cartas carta in this.cartas)
                {
                    Console.WriteLine(carta.describirCarta());
                }

            }

        }
        

    }
}
