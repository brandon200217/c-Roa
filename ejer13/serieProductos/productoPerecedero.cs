using System;
using System.Collections.Generic;
using System.Text;

namespace serieProductos
{
    class productoPerecedero : producto
    {
        int diasCaducar;

        public productoPerecedero(int diasCaducar, string nombre, double precio)
            : base(nombre, precio)
        {
            this.diasCaducar = diasCaducar;
        }


        public override double calcular(int cantidad)
        {
            if (this.diasCaducar == 1)
            {
                this.precio = this.precio / 4;
            }
            else if (this.diasCaducar == 2)
            {
                this.precio = this.precio / 3;
            }
            else
            {
                this.precio = this.precio / 2;
            }

            return this.precio * cantidad;
        }


    }
}
