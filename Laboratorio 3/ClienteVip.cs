using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class ClienteVip : Cliente
    {
        //Descuento especial en pedidos
        public override double Descuento(double sumatoria)
        {
            double descuento = sumatoria * 0.15;
            return descuento;
        }
        public ClienteVip(int Id, string nombre, string correo, string direccion) : base(Id, nombre, correo, direccion)
        {
        }
    }
}
