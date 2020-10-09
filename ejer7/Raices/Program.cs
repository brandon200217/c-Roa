using System;

namespace Raices
{
    class Program
    {
        static void Main(string[] args)
        {
            raices raiz = new raices(1,25,5);
            raiz.obtenerRaices();
        }
    }

    class raices
    {
        private double a;
        private double b;
        private double c;

        public raices(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }


        public void obtenerRaices() {
            
            double pvalor = this.b * this.b - 4 * (this.a) * (this.c);          
            double p1 = Math.Sqrt(pvalor);
           
            if (p1 > 0) {
                double resultPositivo = (-(this.b) + (p1)) / 2 * this.a;
                double resultNegativo = (-(this.b) - (p1)) / 2 * this.a;

                Console.WriteLine("la solucion 1 es:"+resultPositivo+" y la soluciones 2 es:"+resultNegativo);
            }
        
        }

        public void obtenerRaiz()
        {
            double pvalor = this.b * this.b - 4 * (this.a) * (this.c);
            double p1 = Math.Sqrt(pvalor);

            if (p1 == 0)
            {
                double pvalorCero = -(this.b) / 2 * this.a;

            }
            else
            {
                Console.WriteLine("el valor no es el esperado");
            }
        }

        public double getDiscriminante() {
            
            double pvalor = Math.Pow(this.b , 2) - 4 * (this.a) * (this.c);
            double p1 = Math.Sqrt(pvalor);
            return p1;
        }

        public bool tieneRaices()
        {
            double pvalor = this.b * this.b - 4 * (this.a) * (this.c);
            double p1 = Math.Sqrt(pvalor);

            if (p1 >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }    
        public bool tieneRaiz() {

            double pvalor = this.b * this.b - 4 * (this.a) * (this.c);
            double p1 = Math.Sqrt(pvalor);
           
            if (p1 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void calcular() {


            double pvalor = this.b * this.b - 4 * (this.a) * (this.c);
            double p1 = Math.Sqrt(pvalor);

            if (p1 > 0)
            {
                double resultPositivo = (-(this.b) + (p1)) / 2 * this.a;
                double resultNegativo = (-(this.b) - (p1)) / 2 * this.a;

                Console.WriteLine("la solucion 1 es:" + resultPositivo + " y la soluciones 2 es:" + resultNegativo);
            }
            else if (p1 == 0)
            {

                Console.WriteLine("solo hay un resultado");
            }

            else
            {

                Console.WriteLine("sin solucion");
            }


        }

    }
}
