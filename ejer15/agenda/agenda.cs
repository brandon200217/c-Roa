using System;
using System.Collections.Generic;
using System.Text;

namespace agenda
{
    class agenda
    {

        contacto[] contactos;   
        public agenda(contacto[] contactos)
        {
            this.contactos = contactos;
        }



        public bool aniadirContacto(contacto c)
        {
            
            for (int i = 0; i < this.contactos.GetLength(0); i++)
            {
                if (this.contactos[i] == null)
                {
                    this.contactos[i] = c;
                    return true;
                }
                else
                {
                    if (this.contactos[i].Nombre == c.Nombre)
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        public bool existeContacto(contacto c)
        {
            for (int i = 0; i < contactos.GetLength(0); i++)
            {
                if (this.contactos[i] == null)
                {
                    return false;
                }
                else
                {
                    if (this.contactos[i].Nombre == c.Nombre)
                    {
                        return true;
                    }
                }
            }

            return false;

        }
        public void listarContactos()
        {

            foreach (contacto i in this.contactos)
            {
                if (i == null)
                {
                    Console.WriteLine("no hay contacto");
                }
                else
                {
                    Console.WriteLine(i.Telefono);
                }
            }
        }

        public void buscaContacto(String nombre)
        {
            foreach (contacto i in this.contactos)
            {
                if (i != null)
                {
                    if (i.Nombre == nombre)
                    {
                        Console.WriteLine(i.Telefono);
                    }
                    else
                    {
                        Console.WriteLine("No coincide");
                    }
                }
               
            }
        }

        public bool eliminarContacto(contacto c)
        {
            for (int i = 0; i < contactos.GetLength(0); i++)
            {
                if (c.Nombre == this.contactos[i].Nombre)
                {
                    this.contactos[i] = null;
                    return true;
                }
            }
            return false;

        }

        public bool agendaLlena()
        {
            foreach (contacto i in this.contactos)
            {
                if (i == null)
                {
                    return false;
                }
            }

            return true;
        }

        public double huecosLibres()
        {
            int contador = 0;

            foreach (contacto i in this.contactos)
            {
                if (i == null)
                {
                    contador++;
                }
            }
            Console.WriteLine("suma prueba ..."+ contador);
            return contador;
        }
    }
}
