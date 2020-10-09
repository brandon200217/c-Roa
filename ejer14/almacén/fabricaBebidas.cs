using System;
using System.Collections.Generic;
using System.Text;

namespace almacén
{
    class fabricaBebidas
    {
        public static bebida obtenerBebidas(string bebida)
        {

            switch (bebida)
            {
                case "A":

                    Console.WriteLine("material de la bebida");
                    string material = Console.ReadLine();
                    Console.WriteLine("porcentaje de Azucar de la bebida");
                    string porcentajeAzucar = Console.ReadLine();

                    Console.WriteLine("tiene promosion Y/N");
                    string promo = Console.ReadLine();
                    bool promocion;
                    if (promo == "Y")
                    {
                        promocion = true;
                    }
                    else if(promo == "N"){
                        promocion = false;
                    }
                    else
                    {
                        promocion = false;
                    }

                    Console.WriteLine("identificador de la bebida");
                    string identificador = Console.ReadLine();


                    Console.WriteLine("cantidad de Litros de la bebida");
                    string cantLitros = Console.ReadLine();


                    Console.WriteLine("precios de la bebida");
                    string precio = Console.ReadLine();

                    Console.WriteLine("marca de la bebida");
                    string marca = Console.ReadLine();

                    cocacola bebidaAzucarada = new cocacola(material, Convert.ToInt32(porcentajeAzucar), promocion, identificador, Convert.ToDouble(cantLitros), Convert.ToDouble(precio), marca);
                    return bebidaAzucarada;

                case "B":

                    Console.WriteLine("cantidad de Litros de la bebida");
                    string origen = Console.ReadLine();

                    Console.WriteLine("identificador de la bebida");
                    identificador = Console.ReadLine();
                    
                    Console.WriteLine("cantidad de Litros de la bebida");
                    cantLitros = Console.ReadLine();
                    
                    Console.WriteLine("precios de la bebida");
                    precio = Console.ReadLine();

                    Console.WriteLine("marca de la bebida");
                    marca = Console.ReadLine();

                    bebidaMineral Mineral = new bebidaMineral(origen, identificador, Convert.ToDouble(cantLitros), Convert.ToDouble(precio), marca);
                    return Mineral;

                default:

                    return null;
            }
        }
    }
}
