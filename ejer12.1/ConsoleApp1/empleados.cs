using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class empleados
    {
        protected string nombre;
        protected int edad;
        protected double salario;
        protected const int plus = 300;

        public empleados(string nombre, int edad, double salario)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;
        }

        public string Name
        {
            get
            {
                return this.nombre;
            }
        }

        public abstract bool plusSueldo();

    }
}
