using System;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("edad");
            string edad = Console.ReadLine();
            Console.WriteLine("sexo");
            string sexo = Console.ReadLine();
            
            /*---------------------------------------------------
             Mostrar peso ideal 
             ---------------------------------------------------*/
            Console.WriteLine("peso");
            string peso = Console.ReadLine();
            
            Console.WriteLine("altura");
            string altura = Console.ReadLine();

            Persona obj1 = new Persona();
            Persona obj2 = new Persona(nombre, Convert.ToInt32(edad), sexo);
            Persona obj3 = new Persona(nombre, Convert.ToInt32(edad), sexo, double.Parse(peso), double.Parse(altura),95810947);

            double valorPeso = obj1.CalcularIMC();
            Console.WriteLine(valorPeso);

            valorPeso = obj2.CalcularIMC();
            Console.WriteLine(valorPeso);

            valorPeso = obj3.CalcularIMC();
            Console.WriteLine(valorPeso);
            /*---------------------------------------------------
            Es mayor de edad
            ---------------------------------------------------*/
            bool esMayor = obj1.esMayorEdad();
            Console.WriteLine(esMayor);
            esMayor = obj2.esMayorEdad();
            Console.WriteLine(esMayor);
            esMayor = obj3.esMayorEdad();
            Console.WriteLine(esMayor);
            /*---------------------------------------------------
            Mostrar objeto
            ---------------------------------------------------*/
            obj1.ToString();
            obj2.ToString();
            obj3.ToString();

        }
    }

    class Persona
    {
        protected string nombre="";
        protected int edad = 0;
        protected double dni;
        protected const string sexo = "hombre";
        protected double peso = 0;
        protected double altura = 0;


        public Persona() { }

        public Persona(string nombre,int edad, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            string sex = sexo;
           
        }
        public Persona(string nombre, int edad, string sexo, double peso, double altura, double dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
            this.altura = altura;
            this.dni = dni;
        }

        public string Nom
        {
            set
            {
                this.nombre = value;
            }

        }

        public int Edad
        {
            set
            {
                this.edad = value;
            }

        }
        public double Peso
        {
            set
            {
                this.peso = value;
            }

        }
        public double Altura
        {
            set
            {
                this.altura = value;
            }

        }
        public double Dni
        {
            set
            {
                this.dni = value;
            }

        }



        public int CalcularIMC() {

            int valor;
            double pesoIdeal = this.peso / (this.altura * this.altura);

            if (pesoIdeal < 20 )
            {
                valor = -1;
                return valor;
            }

            else if( pesoIdeal >= 20 && pesoIdeal <= 25){
                 
                valor = 0;
                return valor;
            }
            
            else {

                valor = 1;
                return valor;
            } 
            
        }

        public bool esMayorEdad()
        {

            if (this.edad < 18 ){
                return false;
            }
            else{
                return true;
            }
            
            
        }

        static char comprobarSexo(char sexoIntroducido)
        {
            if (sexoIntroducido == 'h')
            {
                return 'H';
            }
            else
            {
                return 'M';
            }
        }

        public virtual void ToString() {

            Console.WriteLine("info del objeto " + "nombre: " + this.nombre + " edad: " + this.edad + " dni: " + this.dni + " peso: " + this.peso + " altura: " + this.altura + " sexo: " + sexo);
            
        }

        static public void generarDni()
        {
            double dni = 0;
            Random aleatorio = new Random();
            
            for (int i = 1; i <8; i++)
            {
                dni =+ aleatorio.Next(0,9);    
            }
            Console.WriteLine(dni);
        }


    }
}
