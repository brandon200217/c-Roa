using System;
using System.Collections.Generic;
using System.Text;

namespace almacén
{
    abstract class bebidaAzucarada : bebida
    {
        protected int porcentajeAzucar;
        protected bool promocion;

        public bebidaAzucarada(int porcentajeAzucar, bool promocion, string identificador, double cantLitros, double precio, string marca)
            :base(identificador, cantLitros, precio, marca)
        {
            this.porcentajeAzucar = porcentajeAzucar;
            this.promocion = promocion;
        }
    }
}
