using System;
using System.Collections.Generic;
using System.Text;

namespace cine
{
    class asientos
    {
        char letra;
        int columna;
        espectadores espectador = null; 

        public asientos(char letra,int columna)
        {
            this.letra = letra;
            this.columna = columna;
        }

        public char Letra
        {
            get
            {
                return this.letra;
            }
            set
            {
                this.letra = value;
            }

        }

        public int Columna
        {
            get
            {
                return this.columna;
            }
            set
            {
                this.columna = value;
            }

        }


        public espectadores getespectador
        {
            get{
                return this.espectador;
            }
            set
            {
                this.espectador = value;
            }
            
        }
    }
}
