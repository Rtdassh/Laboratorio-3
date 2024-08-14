using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}
