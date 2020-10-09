using System;
using System.Collections.Generic;
using System.Text;

namespace almacén
{
    class cocacola : bebidaAzucarada
    {
        string material;
        public cocacola(string material,int porcentajeAzucar, bool promocion, string identificador, double cantLitros, double precio, string marca)
            :base(porcentajeAzucar, promocion, identificador, cantLitros, precio, marca)
        {
            this.material = material;

        }

    }
}
