using System;
using System.Collections.Generic;
using System.Text;

namespace almacén
{
    class almacen
    {
        bebida bebidas;
        bebida[,] estante = new bebida[3, 3];

        public almacen(bebida bebidas, bebida[,] estante)
        {
            this.bebidas = bebidas;
            this.estante = estante;
        }

        public bebida[,] Bebidas
        {
            get
            {
                return this.estante;
            }
        }


        public void almacenar() {

            for (int i = 0; i < this.estante.GetLength(0); i++)
            {
                for (int l = 0; l < this.estante.GetLength(1); l++)
                {
                    Console.WriteLine("Si quieres guardar una bebida azucarada escriba A si no Escriba B (bebida mineral)");
                    string respuesta = Console.ReadLine();

                    if (respuesta == "A")
                    {
                        this.bebidas = fabricaBebidas.obtenerBebidas(respuesta);
                        this.estante[i, l] = this.bebidas;
                    }
                    else if(respuesta == "B")
                    {
                        this.bebidas = fabricaBebidas.obtenerBebidas(respuesta);
                        this.estante[i, l] = this.bebidas;
                    }
                    else
                    {
                        fabricaBebidas.obtenerBebidas(null);
                    }
                }
            }
        }


        public double precioBebidas()
        {
            double precioFinal = 0;

            for (int i = 0; i < this.estante.GetLength(0); i++)
            {

                for (int l = 0; l < this.estante.GetLength(1); l++) {

                    precioFinal = precioFinal + this.estante[i, l].Precio;
                }
            }

            return precioFinal;
        }
        
        public double precioBebidasMarca()
        {
            double precioFinal = 0;

            for (int i = 0; i < this.estante.GetLength(0); i++)
            {

                for (int l = 0; l < this.estante.GetLength(1); l++)
                {
                    if (this.estante[i, l].Marca == "polar")
                    {
                        precioFinal = precioFinal + this.estante[i, l].Precio;
                    }

                    
                }
            }

            return precioFinal;
        }
  
        public double precioProductos()
        {
             double precioFinal = 0;

            for (int l = 0; l < this.estante.GetLength(1); l++) {

                precioFinal = precioFinal + this.estante[1, l].Precio;
            }
           
            return precioFinal;
        }


        
        public void agregarProducto()
        {
            
            for (int i = 0; i < this.estante.GetLength(0); i++)
            {
                for (int l = 0; l < this.estante.GetLength(1); l++)
                {
                    if (this.estante[i, l] == null)
                    {
                        Console.WriteLine("Si quieres agregar una bebida azucarada escriba A si no Escriba B (bebida mineral)");
                        string respuesta = Console.ReadLine();
                        this.bebidas = fabricaBebidas.obtenerBebidas(respuesta);

                        bool resp  = verificarIdentificador(this.bebidas);
                        
                        if (resp)
                        {
                            Console.WriteLine("no se puede agregar una bebida con el mismo identifiacador");
                        }
                        else
                        {
                            Console.WriteLine("Se agrego la bebida exitosamente ");
                            this.estante[i, l] = this.bebidas;
                        }
                       

                    }
                }
            }
        }

        public bool verificarIdentificador(bebida bebidaNueva)
        {

            for (int i = 0; i < this.estante.GetLength(0); i++)
            {

                for (int l = 0; l < this.estante.GetLength(1); l++)
                {
                    if(this.estante[i, l] != null) { 

                        if (this.estante[i, l].Identificador == bebidaNueva.Identificador)
                        {
                            return true;
                        }
                    }
                    
                }
            }
            return false;
        }

        public bool eliminarProducto(string id)
        {

            for (int i = 0; i < this.estante.GetLength(0); i++)
            {

                for (int l = 0; l < this.estante.GetLength(1); l++)
                {
                    if (this.estante[i, l].Identificador == id)
                    {
                        this.estante[i, l] = null;
                        return true;
                    }
                }
            }

            return false;
        }

        public void Tostring()
        {
            string datosBebida = "";

            for (int i = 0; i < this.estante.GetLength(0); i++)
            {

                for (int l = 0; l < this.estante.GetLength(1); l++)
                {
                    datosBebida = "la marca de la bebida es: " + this.estante[i, l].Marca + " su identificador es:" + this.estante[i, l].Identificador + " su precio es de " + this.estante[i, l].Precio + " y tiene " + this.estante[i, l].CantLitros +" Litros";
                    Console.WriteLine(datosBebida);
                    Console.WriteLine("");
                }
            }

        }

    }
}
