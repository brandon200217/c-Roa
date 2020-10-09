using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace password
{
    class cliente
    {
        static void Main(string[] args)
        {
            Password password = new Password();
            Console.WriteLine(password.generarPassword());
            
            Console.WriteLine("Cantidad de posiciones del arreglo.");
            string respuesta = Console.ReadLine();
            Console.WriteLine("longitud del password");
            string longitud = Console.ReadLine();

            Password[] array = new Password[Convert.ToInt32(respuesta)];
            bool[] arrayBool = new bool[Convert.ToInt32(respuesta)];


            for (int i = 0 ; i < Convert.ToInt32(respuesta) ; i++)
            {
                password = new Password(Convert.ToInt32(longitud));
                array[i] = password;

                string val = password.generarPassword();
                
                if (val == "este password no es fuerte")
                {
                    arrayBool[i] = false;
                    Console.WriteLine(password.generarPassword()+" "+ i +" " + arrayBool[i] +" "+ i);
                    Console.WriteLine("prueba");
                }
                else
                {
                    arrayBool[i] = true;
                    Console.WriteLine(password.generarPassword() + " " + i + " " + arrayBool[i] + " " + i);

                }
            }

            

        }
    }

    class Password
    {
        private int longitud = 8;
        private string password;

        public Password() { }
        public Password(int longitud)
        {
            this.longitud = longitud;
        }

        public int Longitud
        {
            get
            {
                return this.longitud;
            }
            set
            {
                this.longitud = value;
            }
        }
        public string Pass
        {
            get
            {
                return this.password;
            }

        }


        public string generarPassword()
        {
            Random aleatorio = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int longitud = caracteres.Length;
            char letra;
            this.password = string.Empty;


            for (int i = 0; i < this.longitud; i++)
            {
                letra = caracteres[aleatorio.Next(longitud)];
                this.password += letra.ToString();
            }
            //Console.WriteLine(this.password);
            bool resp = this.esFuerte(this.password);

            if(resp == true)
            {
                return "Este es mi password:" + this.password;
            }
            else
            {
                return "este password no es fuerte";
            }
        }

        public bool esFuerte(string password)
        {
            Regex regex = new Regex("(?!^[a-z]*$)(?!^[A-Z]*$)^(.{8,15})$");
           
            if(regex.IsMatch(password) && password.Length > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
