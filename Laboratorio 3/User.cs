using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class User
    {
        public static List<User> listadoUsuarios = new List<User>();
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public virtual double Descuento(double sumatoria) { return sumatoria; }


        public static void AgregarCliente()
        {
            Console.WriteLine("Menú para registrar clientes");
            Console.WriteLine("1. Cliente Regular");
            Console.WriteLine("2. Cliente VIP");
            Console.WriteLine("3. Cliente Corporativo");
            Console.Write("Ingrese el tipo de cliente que ingresará: ");
            int tipoCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Ingrese el ID del cliente: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            bool numeroRepetido = true;

            while (numeroRepetido)
            {
                User? consulta = listadoUsuarios.Find(n => n.ID == ID);
                if (consulta == null) { Console.WriteLine("Enhorabuena, el ID es nuevo"); break; }
                else { Console.WriteLine("Desgraciadamente, el ID se repite"); Console.ReadKey(); }
            }
            Console.WriteLine();
            Console.Write("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine() ?? "";
            Console.WriteLine();
            Console.Write("Ingrese el correo del cliente: ");
            string mail = Console.ReadLine()??"";
            Console.WriteLine();
            Console.Write("Ingrese la direccion del cliente: ");
            string direccion = Console.ReadLine() ?? "";

            switch (tipoCliente)
            {
                case 1:
                   ClienteRegular clienteRegularAgregado = new ClienteRegular(ID,nombre, mail, direccion);
                    listadoUsuarios.Add(clienteRegularAgregado);
                    break;
                case 2:
                    ClienteVip clienteVipAgregado = new ClienteVip(ID, nombre, mail, direccion);
                    listadoUsuarios.Add(clienteVipAgregado);
                    break;
                case 3:
                    ClienteCorporativo clienteCorporativoAgregado = new ClienteCorporativo(ID, nombre, mail, direccion);
                    listadoUsuarios.Add(clienteCorporativoAgregado);

                    break;
                default:
                    Console.WriteLine("Debes ingresar un numero del 1 al 3");
                    break;
            }
            Console.WriteLine("¡Tu cliente ha ingresado con éxito!");
        }


        public User(int Id,string nombre, string correo, string direccion)
        {
            ID = Id;
            Nombre = nombre;
            Correo = correo;
            Direccion = direccion;
        }
    }
}
