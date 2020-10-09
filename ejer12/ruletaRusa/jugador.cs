using System;
using System.Collections.Generic;
using System.Text;

namespace ruletaRusa
{
    class jugador
    {
        private int id;
        private string nombre;
        private bool isVivo;

        public jugador(int id, string nombre, bool isVivo)
        {
            this.id = id;
            this.nombre = nombre;
            this.isVivo = isVivo;
        }

        public string Name
        {
            get
            {
                return this.nombre;
            }
        }


        public bool disparar()
        {
            this.isVivo = false;
            
            return false;
        }
    }
}
