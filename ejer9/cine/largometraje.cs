using System;
using System.Collections.Generic;
using System.Text;

namespace cine
{
    abstract class largometraje
    {
        protected string titulo;
        protected int duracion;
        protected int edadMin;
        protected string director;


        public largometraje(string titulo, int duracion, int edadMin, string director)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.edadMin = edadMin;
            this.director = director;
        }

        public abstract string reproducir(largometraje Largometraje);

    }

}
