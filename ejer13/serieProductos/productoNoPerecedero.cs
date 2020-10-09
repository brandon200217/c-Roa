using System;
using System.Collections.Generic;
using System.Text;

namespace serieProductos
{
    class productoNoPerecedero : producto
    {
        string tipo;

        public productoNoPerecedero(string tipo, string nombre, double precio)
           : base(nombre, precio)
        {
            this.tipo = tipo;
        }

        public override double calcular(int cantidad)
        {
            return this.precio * cantidad;
        }
    }
}
