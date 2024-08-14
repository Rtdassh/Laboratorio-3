using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class Pedido
    {
        public static int contadorPedidos = 0;
        public static List<Pedido> listadoPedidos = new List<Pedido>();
        public static List<Producto> listadoTemporal = new List<Producto>();

        public int NumeroPedido { get; set; }
        public DateTime FechaPedido { get; set; }

        public List<Producto> ListadoProductos { get; set; }
        public int IdCliente { get; set; }

        public static void AgregarPedido()
        {
            listadoTemporal.Clear();
            contadorPedidos++;
            bool evaluacion = true;
            int IDCliente = 0;
            Console.WriteLine("Menú para registrar pedidos");
            while (evaluacion)
            {
                Console.Write("Ingrese el ID del cliente: ");
                 IDCliente = Convert.ToInt32(Console.ReadLine() ?? "");
                User? consulta = User.listadoUsuarios.Find(n => n.ID == IDCliente);
                if (consulta != null) { Console.WriteLine("El ID es válido"); break; }
                else { Console.WriteLine("Ingreso un ID inválido"); }
            }
            Console.WriteLine("¿Cuántos productos desea agregar?");
            int cantidadProductos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidadProductos; i++) 
            {
                Console.Write("Ingrese el nombre del producto{0}: ", i+1);
                string nombre = Console.ReadLine() ?? "";

                Console.Write("Ingrese el precio del producto{0}: ", i + 1);
                double precio = Convert.ToDouble(Console.ReadLine() ?? "");

                Producto productoAgregado = new Producto(nombre, precio);
                listadoTemporal.Add(productoAgregado);
            }
            Pedido nuevoPedido = new Pedido(contadorPedidos, DateTime.Now, listadoTemporal, IDCliente);
            listadoPedidos.Add(nuevoPedido);
            Console.WriteLine("¡Tu pedido ha ingresado con éxito!");
        }

        public static double CalcularTotal(int IDCliente) 
        {
            User? consulta = User.listadoUsuarios.Find(n => n.ID == IDCliente)!;

            double total = 0;
            foreach (var item in ) 
            {
                total += item.Precio;
            }
            total = total - consulta.Descuento(total);
            return total;
        }
        public Pedido(int numeroPedido, DateTime fechaPedido, List<Producto> listadoProductos, int idCliente)
        {
            NumeroPedido = numeroPedido;
            FechaPedido = fechaPedido;
            ListadoProductos = listadoProductos;
            IdCliente = idCliente;
        }
    }
}
