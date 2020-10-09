using System;
using System.Collections.Generic;

namespace cartas
{
    class Program
    {
        static void Main(string[] args)
        {
            baraja carta = new baraja();
            carta.barajar();
            Console.WriteLine();
            Console.ReadLine();

            cartas respuesta = carta.siguienteCarta();
            if (respuesta == null)
            {
                Console.WriteLine("no hay mas cartas");
            }
            else
            {
                Console.WriteLine("la carta es: "+ respuesta.Numero+respuesta.Palo);
            }

            Console.WriteLine();
            Console.ReadLine();

            List<cartas> resp = new List<cartas>();
            resp = carta.darCartas(2);
            if (resp == null)
            {
                Console.WriteLine("no hay tantas cartas");
            }
            else
            {
                foreach(cartas i in resp){

                    Console.WriteLine("la carta es: " + respuesta.Numero + respuesta.Palo);

                }
            }

            Console.WriteLine();
            Console.ReadLine();


            
            carta.cartasMonton();
            Console.WriteLine();
            Console.ReadLine();
            
            carta.cartasDisponibles();
            Console.WriteLine();
            Console.ReadLine();
            
            carta.mostrarBaraja();
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
