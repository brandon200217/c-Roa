using System;

namespace baraja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            barajaEspañola b = new barajaEspañola(true);
            Console.WriteLine("Escoja el tipo de baraja las Opciones son: Española/Francesa");
            
            string baraja =Console.ReadLine();
            
            b.mostrarBaraja(baraja);

        }
    }
}
