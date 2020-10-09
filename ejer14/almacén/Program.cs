using System;

namespace almacén
{
    class Program
    {
        static void Main(string[] args)
        {
            almacen almacenBebidas = new almacen(null,new bebida[1, 3]);
            almacenBebidas.almacenar();

            double valor = almacenBebidas.precioBebidas();
            Console.WriteLine(valor + " Es el precio total de las bebidas del estante");

            valor = almacenBebidas.precioBebidasMarca();
            Console.WriteLine(valor + " Es el precio total de las bebidas con la misma marca");

            bool respuesta = almacenBebidas.eliminarProducto("2ac");
            if (respuesta == true)
            {
                Console.WriteLine("Se elimino exitosamente");
            }
            else
            {
                Console.WriteLine("No se pudo eliminar exitosamente");
            }
            

            almacenBebidas.agregarProducto();

            almacenBebidas.Tostring();

        }
    }
}
