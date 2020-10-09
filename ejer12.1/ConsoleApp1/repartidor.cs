using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class repartidor : empleados
    {
        string zona;


        public repartidor(string zona, string nombre, int edad,double salario)
        : base( nombre, edad,salario)
        {
            this.zona = zona;
        }

        public override bool plusSueldo()
        {
            if(this.edad < 25 && this.zona == "zona3")
            {
                this.salario = this.salario + plus;
                return true;
            }
            else
            {
                return false;
            }

           
        }
    }
}
