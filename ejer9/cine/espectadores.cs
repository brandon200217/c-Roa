using System;
using System.Collections.Generic;
using System.Text;

namespace cine
{
    class espectadores
    {

        string nombre;
        double dinero;
        bool isSentado = false;
        int edad;

        public espectadores(double dinero, int edad)
        {
            this.dinero = dinero;
            this.edad = edad;
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public double Dinero
        {
            get
            {
                return this.dinero;
            }
        }

        public bool IsSentado
        {
            get{

                return this.isSentado;
            }
            set
            {
                this.isSentado = value;
            }
        }


        public bool tieneDinero(int costoEntrada)
        {
            if (this.dinero > costoEntrada)
            {
                return true;
            }
            return false;
        }

        public bool tieneEdad(int edadNecesaria)
        {
            if (this.edad > edadNecesaria)
            {
                return true;
            }
            return false;
        }

        public void Sentado()
        {
            if (this.isSentado == true)
            {
                Console.WriteLine("ya esta sentado");
            }
            else
            {
                this.isSentado = true;
                //llamar metodo sentar

            }

        }

    }
}
