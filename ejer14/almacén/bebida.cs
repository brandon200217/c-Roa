using System;
using System.Collections.Generic;
using System.Text;

namespace almacén
{
    abstract class bebida
    {

        protected string identificador;
        protected double cantLitros;
        protected double precio;
        protected string marca;

        public bebida(string identificador, double cantLitros, double precio, string marca)
        {
            this.identificador = identificador;
            this.cantLitros = cantLitros;
            this.precio = precio;
            this.marca = marca;
        }

        public double Precio
        {
            get
            {
                return this.precio;
            }
        }
        public string Marca
        {
            get
            {
                return this.marca;
            }
        }
        public double CantLitros
        {
            get
            {
                return this.cantLitros;
            }
        }

        public string Identificador
        {
            get
            {
                return this.identificador;
            }
        }


        

    }
}
