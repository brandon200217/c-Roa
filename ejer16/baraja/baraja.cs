using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baraja
{
    abstract class baraja
    {
        protected int cartasTotal;
        protected List<carta> cartas = new List<carta>();
        protected List<carta> cartasDadas = new List<carta>();
        protected int cartas_X_Palo;

        public abstract void crearBarajas(List<carta> cartas, int cartas_X_Palo);

        public void barajar()
        {
            List<carta> cartasDesorganizadas = new List<carta>();
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

        public carta siguienteCarta()
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

        public List<carta> darCartas(int cant)
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

        public void cartasDisponibles()
        {
            Console.WriteLine(this.cartas.Count + " son las cartas que aun se pueden repartir");
        }


        public  virtual void mostrarBaraja(string tipoBaraja)
        {
            if (this.cartas.Count == 0)
            {
                Console.WriteLine("No hay cartas que mostrar");
            }
            else
            {
                foreach (carta carta in this.cartas)
                {
                    string respuesta = carta.describirCarta(tipoBaraja);
                    
                    if (respuesta != "") { 
                        Console.WriteLine(respuesta);
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Esas cartas no estan disponibles");
                        Console.WriteLine("");
                    }

                }

            }

        }

    }
}
