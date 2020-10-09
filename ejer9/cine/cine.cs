using System;
using System.Collections.Generic;
using System.Text;

namespace cine
{
    class cine
    {
        List<espectadores> espectadores = new List<espectadores>();
        pelicula pelicula;
        asientos[,] sala = new asientos[8,9];

        public cine(pelicula pelicula, asientos[,] sala)
        {
            this.pelicula = pelicula;
            this.sala = sala;

            this.generarButacas();
        }


        public void generarButacas() {

            for ( int i = 0; i < this.sala.GetLength(0); i++)
            {

                for(int l = 0 ; l < sala.GetLength(1); l++)
                {
                    this.sala[i, l] = new asientos((char)(l + 65), l) ;
                }
            }
            //dibujarButacas();
        }

        public void dibujarButacas()
        {
            for (int i = 0; i < this.sala.GetLength(0); i++)
            {
                for (int l = 0; l < sala.GetLength(1); l++)
                {
                    Console.SetCursorPosition(i, l);
                    Console.Write("*");
                }
                Console.Write("");
            }
        }

        public void espectadoresTotales()
        {
            Random rdn = new Random();
            Console.WriteLine("Espectadores en la sala de espera:");
            int c_espectadores = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (int i = 0; i < c_espectadores; i++)
            {
                this.espectadores.Add(new espectadores(rdn.Next(90, 200), rdn.Next(10, 60)));
            }
        }


        public void sentarEspectadores()
        {
            Random rdn = new Random();
            this.espectadoresTotales();
            for (int i = 0; i < this.espectadores.Count ; i++) {
                
                if(this.espectadores[i].tieneDinero(100) && this.espectadores[i].tieneEdad(14))
                {
                    asientos asiento = this.sala[rdn.Next(1, 9), rdn.Next(1, 8)];

                    if (asiento.getespectador == null)
                    {
                        asiento.getespectador = this.espectadores[i];
                        Console.Write("Conseguimos un puesto para: ");
                        pelicula.toString();
                    }
                    else
                    {
                        bool tienePuesto = this.hayLugar(this.espectadores[i]);

                        if (tienePuesto == true)
                        {
                            Console.Write("Conseguimos un puesto para: ");
                            pelicula.toString();
                        }
                        else
                        {
                            Console.Write("no hay puesto disponible");
                        }
                    
                    }
                }
                else
                {
                    Console.WriteLine("no cumple los requisitos para ver la pelicula");
                    Console.WriteLine("el espectador tiene "+ this.espectadores[i].Edad+" años y tiene "+ this.espectadores[i].Dinero+"$");

                }
            }

        }

        public bool hayLugar(espectadores espectador)
        {
            Console.WriteLine("Estamos buscando algun lugar disponible...");
            for (int i = sala.GetLength(0); i >= 1; i--)
            {
                for (int l = sala.GetLength(0); l >= 1; l--)
                {
                    try
                    {
                        if (this.sala[i, l].getespectador == null)
                        {

                            this.sala[i, l].getespectador = espectador;
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    catch (Exception e)
                    {
                        Exception exepcion = e;
                    }
                    
                }
            }
            return false;
        }
       

        /*public asientos[,] asientosDisponibles()
        {

        }*/


    }
}
