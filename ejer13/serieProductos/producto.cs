using System;
using System.Collections.Generic;
using System.Text;

namespace serieProductos
{
    class producto
    {
        protected string nombre;
        protected double precio;
    
    
        public producto(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public virtual double calcular(int cantidad)
        {
            return this.precio * cantidad;
        } 
    
    }
}
