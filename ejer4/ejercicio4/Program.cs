using System;

namespace ejercicio4
{

    class cliente
    {
        static void Main(string[] args)
        {
            Electrodomestico[] arrayTv = new Electrodomestico[2];
            Electrodomestico[] arrayLavadora= new Electrodomestico[2];

            Console.WriteLine(arrayTv.Length);

            for (int i = 0; i <= arrayTv.Length-1; i++)
            {
                Console.WriteLine("precioBase:");
                string precioBase = Console.ReadLine();
                Console.WriteLine("peso:");
                string peso = Console.ReadLine();
                Console.WriteLine("color:");
                string color = Console.ReadLine();
                Console.WriteLine("consumoEnergetico:");
                string consumoEnergetico = Console.ReadLine();
                Console.WriteLine("resolucion:");
                string resolucion = Console.ReadLine();
                Console.WriteLine("sintonizador:");
                string sintonizador = Console.ReadLine();
                
                television objTelevision = new television(Convert.ToDouble(precioBase), Convert.ToInt32(peso), color, Convert.ToChar(consumoEnergetico), Convert.ToDouble(resolucion), Convert.ToBoolean(sintonizador));             
                arrayTv[i] = objTelevision;
 
                arrayTv[i].precioFinal();
                Console.WriteLine("");
            }


            for (int i = 0; i <= arrayLavadora.Length-1; i++)
            {

                Console.WriteLine("precioBase:");
                string precioBase = Console.ReadLine();
                Console.WriteLine("peso:");
                string peso = Console.ReadLine();
                Console.WriteLine("color:");
                string color = Console.ReadLine();
                Console.WriteLine("consumoEnergetico:");
                string consumoEnergetico = Console.ReadLine();
                Console.WriteLine("carga:");
                string carga = Console.ReadLine();

                string resolucion = Console.ReadLine();
                lavadora objLavadora = new lavadora(Convert.ToDouble(precioBase), Convert.ToInt32(peso), color, Convert.ToChar(consumoEnergetico),Convert.ToInt32(carga));
                arrayLavadora[i] = objLavadora;
                arrayTv[i].precioFinal();
                Console.WriteLine("");
            }


        }
    }
    class Electrodomestico
    {
        protected double precioBase = 100;
        protected char consumoEnergetico = 'F';
        protected string color = "blanco";
        protected int peso = 5;

        public Electrodomestico() { }

        public Electrodomestico(double precioBase, int peso)
        {

            this.precioBase = precioBase;
            this.peso = peso;
        }

        public Electrodomestico(double precioBase, int peso, string color, char consumoEnergetico)
        {

            this.precioBase = precioBase;
            this.peso = peso;

            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
            this.comprobarConsumoEnergetico(consumoEnergetico);
            this.comprobarColor(color);

        }

        public double PrecioBase
        {
            get
            {
                return this.precioBase;
            }
        }
        public char ConsumoEnergetico
        {
            get
            {
                return this.consumoEnergetico;
            }
        }
        public string Color
        {
            get
            {
                return this.color;
            }
        }

        public double Peso
        {
            get
            {
                return this.peso;
            }
        }


        private void comprobarConsumoEnergetico(char letra)
        {

            if (letra == 'A' || letra == 'B' || letra == 'C' || letra == 'D' || letra == 'E' || letra == 'F')
            {
                this.consumoEnergetico = letra;
            }
            else
            {
                Console.WriteLine("el consumo energetico es de " + this.consumoEnergetico);
            }
        }
        private void comprobarColor(string color)
        {
            if (color == "blanco" || color == "negro" || color == "azul" || color == "gris")
            {
                this.color = color;
            }
            else
            {
                Console.WriteLine("el color es de " + this.color);
            }
        }

        public virtual void  precioFinal()
        {
            
            switch (this.consumoEnergetico)
            {
                case 'A':
                    this.precioBase += 100;
                    break;

                case 'B':
                    this.precioBase += 80;
                    break;

                case 'C':
                    this.precioBase += 60;
                    break;

                case 'D':
                    this.precioBase += 50;
                    break;

                case 'E':
                    this.precioBase += 30;
                    break;

                case 'F':
                    this.precioBase += 10;
                    break;
            }

            if ((this.peso <= 20) && (this.peso >= 0))
            {
                this.precioBase += 10;
            }
            else if ((this.peso <= 20) && (this.peso >= 49))
            {
                this.precioBase += 50;
            }
            else if ((this.peso <= 50) && (this.peso >= 79))
            {
                this.precioBase += 80;
            }
            else if ((this.peso > 80))
            {
                this.precioBase += 100;
            }
            else
            {
                Console.WriteLine("no se puede meter un peso negativo");
            }

            Console.Write("el precio total " + this.precioBase);

        }

    }

    class lavadora : Electrodomestico
    {
        protected int carga = 5;

        public lavadora()
           : base(){}
        
        public lavadora(double precioBase, int peso, int carga)
           : base(precioBase, peso)
        {
            this.carga = carga;
            this.peso = peso;
            this.precioBase = precioBase;
        }

        public lavadora(double precioBase, int peso, string color, char consumoEnergetico, int carga) 
            :base(precioBase, peso, color, consumoEnergetico)
        { 
            this.precioBase = precioBase;
            this.peso = peso;
            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
            this.carga = carga;
        }

        public int Carga
        {
            get
            {
                return this.carga;
            }
        }

        public new virtual void precioFinal()
        {
            Console.WriteLine(this.precioBase);

            if (this.carga > 30)
            {
                Console.WriteLine(this.precioBase);
                
                this.precioBase += 50;
            }

            Console.Write(this.precioBase);

        }

    }



    class television : Electrodomestico
    {
        protected double resolucion;
        protected bool sintonizador;

        public television()
             : base() { }

        public television(double precioBase, int peso, double resolucion, bool sintonizador)
           : base(precioBase, peso)
        {

            this.peso = peso;
            this.precioBase = precioBase;

            this.resolucion = resolucion;
            this.sintonizador = sintonizador;
        }

        public television(double precioBase, int peso, string color, char consumoEnergetico, double resolucion, bool sintonizador)
            : base(precioBase, peso, color, consumoEnergetico)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
            this.resolucion = resolucion;
            this.sintonizador = sintonizador;

        }


        public double Resolucion
        {
            get
            {
                return this.resolucion;
            }
        }

        public bool Sintonizador
        {
            get
            {
                return this.sintonizador;
            }
        }


        public new virtual void precioFinal()
        {
            Console.WriteLine("entra");
            base.precioFinal();

            if (this.resolucion > 40)
            {
                this.precioBase = precioBase * 0.30;
            }
            
            if (this.sintonizador == true)
            {
                this.precioBase = 50;
            }

            Console.Write(this.precioBase);
        }
    }

}
