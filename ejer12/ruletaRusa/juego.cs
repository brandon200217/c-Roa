using System;
using System.Collections.Generic;
using System.Text;

namespace ruletaRusa
{
    class juego
    {

        List<jugador> jugador;
        revolver revolver;

        public juego(List<jugador> jugadores, revolver revolver)
        {
            this.jugador = jugadores;
            this.revolver = revolver;
        }

        public bool finJuego() { 
            Console.WriteLine("");
            Console.WriteLine("Termino el juego");
            return true;
        }

        public void ronda()
        {
            for(int i = 0 ; i < this.jugador.Count; i++)
            {
                bool isBala = this.revolver.disparar();

                if (isBala == true){
                    bool isMuerto = this.jugador[i].disparar();
                    Console.WriteLine(this.jugador[i].Name + " esta muerto la bala ha impactado");
                    bool isFinJuego = this.finJuego();
                    
                    if (isFinJuego == true)
                    {
                        break;
                    }
                }
                else{
                    Console.WriteLine(this.jugador[i].Name + " no esta muerto");
                    revolver.toString();
                    revolver.siguienteBala();
                    

                }
            }
        }
    }
}
