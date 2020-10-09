using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class comercial : empleados
    {
        double comision;
        public comercial(double comision, string nombre, int edad, double salario)
        : base(nombre, edad, salario)
        {
            this.comision = comision;
        }

        public override bool plusSueldo()
        {
            if (this.edad > 30 && this.comision > 200)
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
