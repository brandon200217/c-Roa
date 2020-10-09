using System;
using System.Collections.Generic;
using System.Text;

namespace agenda
{
    class contacto
    {
        string nombre;
        int telefono;

        public contacto(string nombre,int telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public int Telefono
        {
            get
            {
                return this.telefono;
            }
        }

    }
}
