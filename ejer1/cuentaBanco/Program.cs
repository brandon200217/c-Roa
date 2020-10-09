using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;



namespace cuentaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta mybanco = new Cuenta("brandon");
            Console.WriteLine(mybanco.titularBanco);
            
            string valor=mybanco.ToString();
            Console.WriteLine(valor);

            double saldoActual = mybanco.ingresar(200);
            string mySaldo = "Su saldo actual es de : " + saldoActual+"$";
            Console.WriteLine(mySaldo);

            double saldoRestante = mybanco.retirar(300);

            Console.WriteLine("Su saldo actual es de "+ saldoRestante+"$");



        }
    }

    class Cuenta
    {
        protected string titular;
        protected double cantidad;

        public Cuenta(string titular)
        {
            this.titular = titular;
        }

        public Cuenta(float cantidad, string titular)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string titularBanco
        {
            get
            {
                return this.titular;
            }
            set
            {
                this.titular = value;
            }
        }

        public virtual string ToString()
        {
            return this.titular + " dueño de esta cuenta, tiene un saldo de " + this.cantidad;
        }


        public double ingresar(double cantidad)
        {
            if(cantidad <= 0)
            {
                Console.WriteLine("usted no puede ingresar dicha cantidad de dinero a la cuenta"); 
            }
            else
            {
                this.cantidad = cantidad;
            }        

            return this.cantidad;
        }

        public double retirar(double cantidad)
        {

            double valorCuenta = this.cantidad - cantidad;

            Console.WriteLine();

            if (valorCuenta <= 0)
            {
                this.cantidad = 0;
                return this.cantidad;
            }
            else
            {
                return valorCuenta;
            }
        
        }




    }
}
