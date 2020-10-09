using System;
using System.Collections.Generic;

namespace ruletaRusa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<jugador> jugadores = new List<jugador>();
            Random numRandom = new Random();
            
            revolver revolver = new revolver(1,numRandom.Next(1, 7));
            
            jugador p1 = new jugador(1,"brandon",true);
            jugadores.Add(p1);

            jugador p2 = new jugador(2, "daniel", true);
            jugadores.Add(p2);
            
            jugador p3 = new jugador(3, "eduardo", true);
            jugadores.Add(p3);
            
            jugador p4 = new jugador(4, "juan", true);
            jugadores.Add(p4);
            
            jugador p5 = new jugador(5, "francisco", true);
            jugadores.Add(p5);

            jugador p6 = new jugador(6, "Gerardo", true);
            jugadores.Add(p6);


            juego inicioJuego = new juego(jugadores, revolver);

            inicioJuego.ronda();


        }
    }
}
