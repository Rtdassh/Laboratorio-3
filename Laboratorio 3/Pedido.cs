using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class Pedido
    {
        public int contadorPedidos = 0;
        public List<Pedido> listadoPedidos = new List<Pedido>();
        public int NumeroPedido { get; set; }
        public DateTime FechaPedido { get; set; }

        public List<Producto> ListadoProductos { get; set; }

        public void AgregarPedido()
        {           
            ListadoProductos.Clear();
            contadorPedidos++;
            Console.WriteLine("Menú para registrar pedidos");
            Console.WriteLine("¿Cuántos productos desea agregar?");
            int cantidadProductos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidadProductos; i++) 
            {
                Console.Write("Ingrese el nombre del producto{0}: ", i+1);
                string nombre = Console.ReadLine() ?? "";

                Console.Write("Ingrese el precio del producto{0}: ", i + 1);
                double precio = Convert.ToDouble(Console.ReadLine() ?? "");

                Producto productoAgregado = new Producto(nombre, precio);
                ListadoProductos.Add(productoAgregado);
            }
            Pedido nuevoPedido = new Pedido(contadorPedidos, DateTime.Now, ListadoProductos);
            listadoPedidos.Add(nuevoPedido);
        }

        public Pedido(int numeroPedido, DateTime fechaPedido, List<Producto> listadoProductos)
        {
            NumeroPedido = numeroPedido;
            FechaPedido = fechaPedido;
            ListadoProductos = listadoProductos;
        }
    }
}
