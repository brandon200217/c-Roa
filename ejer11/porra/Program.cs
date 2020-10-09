using System;
using System.Collections.Generic;

namespace porra
{
    class Program
    {
        static void Main(string[] args)
        {

            List<jugador> jugadores = new List<jugador>();
            porra porra = new porra(200);
            resultados result = new resultados();
            jugador p1 = new jugador(200, "brandon");
            jugador p2 = new jugador(225, "andres");
            jugador p3 = new jugador(50, "juan");
            jugador p4 = new jugador(60, "eduardo");
            jugador p5 = new jugador(21, "daniel");
            int partidasPorra = porra.partidas;

            for (int i = 0; i < partidasPorra; i++) { 

                double apuestaJugador = p1.darDinero();
                if (apuestaJugador != 0)
                {
                    porra.apostarPorra(apuestaJugador);
                    jugadores.Add(p1);
                }
           
                apuestaJugador = p2.darDinero();
                if (apuestaJugador != 0)
                {
                    porra.apostarPorra(apuestaJugador);
                    jugadores.Add(p2);
                }      
            
                apuestaJugador = p3.darDinero();
                if (apuestaJugador != 0)
                {
                    porra.apostarPorra(apuestaJugador);
                    jugadores.Add(p3);
                }
                     
                apuestaJugador = p4.darDinero();
                if (apuestaJugador != 0)
                {
                    porra.apostarPorra(apuestaJugador);
                    jugadores.Add(p4);
                }
  
                apuestaJugador = p5.darDinero();
                if (apuestaJugador != 0)
                {
                    porra.apostarPorra(apuestaJugador);
                    jugadores.Add(p5);
                }

                jugador resultado = result.jugarResultados(jugadores);
         
                if (resultado != null)
                {
                    if (resultado.Dinero >= 500)
                    {
                        Console.WriteLine(resultado.ToString() + " es el ganador de la porra");
                        Console.WriteLine("");
                    }
                   
                }
                jugadores.Clear();
            }
            
            /*Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());
            Console.WriteLine(p4.ToString());
            Console.WriteLine(p5.ToString());*/
        }
    }
}
