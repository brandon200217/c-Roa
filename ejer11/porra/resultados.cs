using System;
using System.Collections.Generic;
using System.Text;

namespace porra
{
    class resultados 
    {
        porra porra = new porra(600);
        public jugador jugarResultados(List<jugador> jugadoresPorra)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("new partida");
            Console.WriteLine("");
            
            for (int i=0; i < jugadoresPorra.Count;i++)
            {
              
                int equipoLocal = jugadoresPorra[i].apuesta();
                int equipoVisitante = jugadoresPorra[i].apuesta();
                bool resultadosObtenido = this.llamarResultado(equipoLocal, equipoVisitante);
                if (resultadosObtenido == true)
                {
                    jugadoresPorra[i].sumarVictoria(resultadosObtenido);
                    int victorias = jugadoresPorra[i].PorrasGanadas;
                    
                    if (victorias == 2)
                    {
                        double dinero = porra.darDineroPorra();
                        jugadoresPorra[i].ganarPorra(dinero);
                        Console.WriteLine(jugadoresPorra[i].Nombre + " gano la porra");
                        porra.reiniciarPorra(jugadoresPorra);
                        return jugadoresPorra[i];
                    }


                    Console.WriteLine(jugadoresPorra[i].Nombre + " gano la partida");
                    Console.WriteLine("");
                    return jugadoresPorra[i];
                }
                else
                {
                    Console.WriteLine(jugadoresPorra[i].Nombre + " no gano");

                }
            }
            Console.WriteLine("nadie gano lastima");
            return null;
        }

        public bool llamarResultado(int equipoLocal, int equipoVisitante)
        {
            int equipoL = partido.resultadosPartido();
            int equipoV = partido.resultadosPartido();

            if (equipoLocal == equipoL && equipoVisitante == equipoV)
            {
                return true;
            }

            return false;
        }
    }
}
