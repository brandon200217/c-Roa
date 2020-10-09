using System;
using System.Collections.Generic;
using System.Text;

namespace almacén
{
    class bebidaMineral : bebida
    {
        protected string origen;
        
        public bebidaMineral(string origen , string identificador, double cantLitros, double precio, string marca)
            :base(identificador, cantLitros, precio, marca)
        {
            this.origen = origen;
        }

    }
}
