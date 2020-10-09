using System;
using System.Collections.Generic;
using System.Text;

namespace porra
{
    class partido
    {

        public static int resultadosPartido()
        {
            Random numRandom = new Random();
            return numRandom.Next(0, 10);
        } 


    }
}
