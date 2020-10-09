using System;

namespace libro
{
    class Program
    {
        static void Main(string[] args)
        {
            libro obj1 = new libro("Anaya Multimedia", "Codigo Limpio","rober martin",100);
            obj1.ToString();
            libro obj2 = new libro("obelisco", "caballero de la armadura oxidada", "rober fischer", 170);
            obj2.ToString();

            int paginasLibros1 = obj1.NumeroPaginas;
            string nombreLibros1 = obj1.Titulo;

            int paginasLibros2 = obj2.NumeroPaginas;
            string nombreLibros2 = obj2.Titulo;

            if (paginasLibros1 < paginasLibros2)
            {
                Console.WriteLine("el libro 2 " + nombreLibros2 + " tiene " + paginasLibros2);
            }
            else if(paginasLibros1 > paginasLibros2){
                Console.WriteLine("el libro 1 " + nombreLibros1 + " tiene " + paginasLibros1);
            }
            else{
                Console.WriteLine("el libro 2 " + nombreLibros1 + " y el libro1 "+ nombreLibros1 +" tiene las mismas cantidad de hojas " + paginasLibros1+" paginas");
            }
        
        }
    }

    class libro
    {
        private string agencia;
        private string titulo;
        private string autor;
        private int numeroPaginas;
    
        public libro(string agencia,string titulo, string autor, int numeroPaginas)
        {
            this.agencia = agencia;
            this.titulo = titulo;
            this.autor = autor;
            this.numeroPaginas = numeroPaginas;
        }
        public string Agencia
        {
            get
            {
                return this.agencia;
            }
            set
            {
                this.agencia = value;
            }
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

        public string Autor
        {
            get
            {
                return this.autor;
            }
            set
            {
                this.autor = value;
            }
        }

        public int NumeroPaginas
        {
            get
            {
                return this.numeroPaginas;
            }
            set
            {
                this.numeroPaginas = value;
            }
        }

        public new virtual void ToString()
        {
            Console.WriteLine("el libro "+ this.titulo +" de la agencia "+this.agencia+", creado por el autor "+this.autor + " tiene "+this.numeroPaginas+ " paginas");
        }


    }
}
