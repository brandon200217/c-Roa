using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace cd
{

    class Program
    {
        static void Main(string[] args)
        {
            series[] arraySeries = new series[3];
            videojuegos[] arrayVideojuegos = new videojuegos[2];
      
            for (int i = 0; i < arraySeries.Length; i++) {
                Console.WriteLine("Titulo:");
                string titulo = Console.ReadLine();
                Console.WriteLine("Creador:");
                string creador = Console.ReadLine();
                series objSeries = new series(titulo, creador);
                arraySeries[i] = objSeries;
            }
            arraySeries[1].entregar();
            arraySeries[0].entregar();
            arraySeries[2].entregar();

            int contadorSeries = 0;
            
            for (int i = 0; i < arraySeries.Length; i++) {

                bool valor = arraySeries[i].IsEntregado();
                Console.WriteLine(valor);

                if (valor == true)
                {
                    contadorSeries += 1;
                    arraySeries[i].ToString();
                }
            }
            Console.WriteLine("entregados totales " + contadorSeries);






            for (int i = 0; i < arrayVideojuegos.Length; i++)
            {
                Console.WriteLine("Titulo:");
                string titulo = Console.ReadLine();
                Console.WriteLine("horasEstimadas:");
                string horasEstimadas = Console.ReadLine();
                videojuegos objvideojuegos = new videojuegos(titulo,Convert.ToInt32(horasEstimadas));
                arrayVideojuegos[i] = objvideojuegos;
            }
            
            arrayVideojuegos[3].entregar();
            arrayVideojuegos[2].entregar();

            int contadorVideojuegos = 0;
            
            for (int i = 0; i < arrayVideojuegos.Length; i++)
            {
                bool valor = arrayVideojuegos[i].IsEntregado();

                if (valor == true)
                {
                    contadorVideojuegos += 1;
                    arrayVideojuegos[i].ToString();
                }

            }
            Console.WriteLine(contadorVideojuegos);
        }

    }

    class series : Ientregable
    {

        private string titulo;
        private int numeroTemporadas = 3;
        private bool isEntregado = false;
        private string genero;
        private string creador;
       
        public series(){}


        public series(string titulo,string creador) {
            this.titulo=titulo;
            this.creador = creador;
        }

        public series(string titulo, string creador, int numeroTemporadas, string genero)
        {
            this.titulo = titulo;
            this.creador = creador;
            this.numeroTemporadas = numeroTemporadas;
            this.genero = genero;
        }

        public string Titulo
        {
            get
            {
                return this.titulo;
            }
            set
            {
                this.titulo = value;
            }
        }
        public int NumeroTemporadas
        {
            get
            {
                return this.numeroTemporadas;
            }
            set 
            {
                this.numeroTemporadas = value;   
            }
        }
        public string Genero
        {
            get
            {
                return this.genero;
            }
            set
            {
                this.genero = value;
            }
        }
        public string Creador
        {
            get
            {
                return this.creador;
            }
            set
            {
                this.creador = value;
            }
        }
        public new virtual void ToString()
        {
            Console.WriteLine("la serie es: " + this.titulo + ", su numero de temporada es de " + this.numeroTemporadas + ", su genero es " + this.genero + " y su autor es " + this.creador);
        }

        public int compareTo(object cd)
        {
            series objSeries =  (series)(cd);

            if (this.numeroTemporadas < objSeries.NumeroTemporadas)
            {
                return -1;
            }
            else if (this.numeroTemporadas > objSeries.NumeroTemporadas)
            {
                return 1;
            }
            else
            {
                return 0;
            }   

        }

        public bool devolver()
        {
            Console.WriteLine("se debe devolver la serie");
            isEntregado = false;
            return isEntregado;
        }

        public bool entregar()
        {
            Console.WriteLine("se ha devuelto la serie");
            isEntregado = true;
            return isEntregado;
        }

        public bool IsEntregado()
        {
            isEntregado = true;
            return isEntregado;
        }

    }

    class videojuegos : Ientregable
    {
        private string titulo;
        private int horasEstimadas = 10;
        private bool isEntregado = false;
        private string genero;
        private string compañia;
        public videojuegos(){}

        public videojuegos(string titulos, int horasEstimadas) {
            
            this.titulo = titulos;
            this.horasEstimadas = horasEstimadas;
        }

        public videojuegos(string titulos, int horasEstimadas, string genero, string compañia)
        {
            this.titulo = titulos;
            this.horasEstimadas = horasEstimadas;
            this.genero = genero;
            this.compañia = compañia;
        }

        public string Titulo
        {
            get
            {
                return this.titulo;
            }
            set
            {
                this.titulo = value;
            }
        }

        public int HorasEstimadas
        {
            get
            {
                return this.horasEstimadas;
            }
            set
            {
                this.horasEstimadas = value;
            }
        }

        public string Genero
        {
            get
            {
                return this.genero;
            }
            set
            {
                this.genero = value;
            }
        }

        public string Compañia
        {
            get
            {
                return this.compañia;
            }
            set
            {
                this.compañia = value;
            }
        }

        public int compareTo(object cd)
        {
            videojuegos objvideojuegos = (videojuegos)(cd);

            if (this.horasEstimadas < objvideojuegos.horasEstimadas)
            {
                return -1;
            }
            else if (this.horasEstimadas < objvideojuegos.horasEstimadas)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public bool devolver()
        {
            Console.WriteLine("se ha devuelto la serie");
            isEntregado = true;
            return isEntregado;
        }

        public bool entregar()
        {
            Console.WriteLine("se ha llebado el juego");
            isEntregado = false;
            return isEntregado;
        }

        public bool IsEntregado()
        {
            isEntregado = false;
            return isEntregado;
        }

    }



}
