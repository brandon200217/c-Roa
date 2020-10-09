using System;
using System.Collections.Generic;

namespace agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            contacto[] contactos = new contacto[10];
            
            agenda agendas = new agenda(contactos);
            string nombres;
            string telefonos;
            contacto contactosAgendas;

            /*....................................
             aniadirContacto
            ...................................*/

            for (int i = 0 ; i < 2 ; i++){

                Console.WriteLine("nombre agenda");
                nombres = Console.ReadLine();

                Console.WriteLine("numero telefonico agenda");
                telefonos = Console.ReadLine();

                contactosAgendas = new contacto(nombres,  Convert.ToInt32(telefonos));
                bool valor = agendas.aniadirContacto(contactosAgendas);

                if (valor == true)
                {
                    Console.WriteLine("Se guardo exitosamente el contacto");
                }
                else
                {
                    Console.WriteLine("Dicho contacto ya existe");
                }

            }
            Console.WriteLine("");
            Console.ReadLine();
            /*....................................
            existeContacto
            ...................................*/
            Console.WriteLine("nombre agenda");
            nombres = Console.ReadLine();

            Console.WriteLine("numero telefonico agenda");
            telefonos = Console.ReadLine();

            contactosAgendas = new contacto(nombres, Convert.ToInt32(telefonos));

            bool existe = agendas.existeContacto(contactosAgendas);
            if (existe == true)
            {
                Console.WriteLine("El contacto existe en la agenda");
            }
            else
            {
                Console.WriteLine("El contacto no existe");
            }
            Console.WriteLine("");
            Console.ReadLine();

            /*....................................
            listarContactos
            ...................................*/

            agendas.listarContactos();
            Console.WriteLine("");
            Console.ReadLine();
            /*....................................
            buscaContacto
            ...................................*/

            Console.WriteLine("nombre agenda");
            nombres = Console.ReadLine();

            agendas.buscaContacto(nombres);

            Console.WriteLine("");
            Console.ReadLine();
            /*....................................
            Eliminarcontacto
            ...................................*/


            Console.WriteLine("nombre agenda");
            nombres = Console.ReadLine();

            Console.WriteLine("numero telefonico agenda");
            telefonos = Console.ReadLine();

            contactosAgendas = new contacto(nombres, Convert.ToInt32(telefonos));

            bool EliminarContacto = agendas.eliminarContacto(contactosAgendas);

            if (EliminarContacto == true)
            {
                Console.WriteLine("Contacto Eliminado");
            }
            else
            {
                Console.WriteLine("No se consiguio coincidencias");
            }

            Console.WriteLine("");
            Console.ReadLine();
            /*....................................
            agendaLlena
            ...................................*/
            bool isAgendaLlena = agendas.agendaLlena();

            if(isAgendaLlena == true){
                
                Console.WriteLine("La agenda esta llena");
            }
            else
            {
                Console.WriteLine("La agenda no esta llena");
            }
            Console.WriteLine("");
            Console.ReadLine();
            /*....................................
            huecosLibres
            ...................................*/

            double espaciosLibres=agendas.huecosLibres();
            Console.WriteLine("hay " + espaciosLibres + " espacios libres");
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}
