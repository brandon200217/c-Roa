using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<empleados> empleados = new List<empleados>();

            empleados empleado1 = new comercial(150, "brandon", 17, 300);
            empleados.Add(empleado1);

            empleados empleado2 = new repartidor("zona2", "juan", 60, 700);
            empleados.Add(empleado2);

            empleados empleado3 = new comercial(235, "eduardo", 33, 3000);
            empleados.Add(empleado3);

            empleados empleado4 = new repartidor("zona3", "juan", 20, 700);
            empleados.Add(empleado4);

            for (int i = 0; i < empleados.Count; i++)
            {
                bool tienePlus = empleados[i].plusSueldo();

                if (tienePlus == true)
                {
                    Console.WriteLine("recibio el plus " + empleados[i].Name);

                }
                else
                {
                    Console.WriteLine("no recibio el plus el empleado: " + empleados[i].Name);
                }


            }
        }
    }
}
