using System;

namespace cine
{
    class Program
    {
        static void Main(string[] args)
        {
            asientos[,] sala = new asientos[9, 8];
            pelicula peli =new pelicula(true,"harry potter",98,14,"adssad");
            cine Cine = new cine(peli, sala);
            Cine.sentarEspectadores();

        }
    }
}
