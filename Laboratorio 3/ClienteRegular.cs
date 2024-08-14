using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class ClienteRegular : Cliente
    {
        public ClienteRegular(int Id, string nombre, string correo, string direccion) : base(Id, nombre, correo, direccion)
        {
        }
    }
}
