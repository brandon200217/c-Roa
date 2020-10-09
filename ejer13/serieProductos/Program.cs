using System;
using System.Collections.Generic;

namespace serieProductos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<producto> productos = new List<producto>();

            producto producto = new producto("leche",50);
            productos.Add(producto);
            producto producto2 = new productoPerecedero(2,"harina",60);
            productos.Add(producto2);
            producto producto3 = new productoNoPerecedero("integral", "harina", 60);
            productos.Add(producto3);


            for (int i = 0; i < productos.Count ; i++)
            {

                double valorCompra = productos[i].calcular(2);
                Console.WriteLine(valorCompra+" es el total de su compra");
            }

            
        }
    }
}
