﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class ClienteCorporativo : Cliente
    {
        //Descuento especial en pedidos y pueden tener varios vehiculos asociados
        public ClienteCorporativo(int Id, string nombre, string correo, string direccion) : base(Id, nombre, correo, direccion)
        {
        }
    }
}
