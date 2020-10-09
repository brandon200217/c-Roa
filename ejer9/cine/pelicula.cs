using System;
using System.Collections.Generic;
using System.Text;

namespace cine
{
    class pelicula : largometraje
    {
        bool cienciaFiccion;
        
        public pelicula(bool cienciaFiccion,string titulo, int duracion, int edadMin, string director)
            :base(titulo, duracion, edadMin, director)
        {
            this.cienciaFiccion=cienciaFiccion;
        }

        public void toString()
        {
            Console.WriteLine("la pelicula de" + this.titulo + " la duracion es de " + this.duracion+" minutos y el director es "+ this.director ) ;
        }

        public override string reproducir(largometraje Largometraje)
        {

            string mensaje =  "La pelicula " +this.titulo +" a caba de comenzar" + " tiene una duracion de "+ this.duracion+" minutos";
            return mensaje;
        }



        
    }
}
