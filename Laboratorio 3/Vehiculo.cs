using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class Vehiculo
    {
       //Clase padre
        public static List<Vehiculo> listadoVehiculos = new List<Vehiculo>();
        public string Matricula { get; set; }
        public string Modelo { get; set; }
        public string TipoCombustible { get; set; }

        public static void AgregarVehiculo()
        {
            Console.WriteLine("Menú para registrar vehículos");
            Console.WriteLine("1. Vehículo Personal");
            Console.WriteLine("2. Vehículo Corporativo");
            Console.Write("Ingrese el tipo de vehículo que ingresará: ");
            int tipoVehiculo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            bool numeroRepetido = true;
            string matricula = "";
            while (numeroRepetido)
            {
                Console.Write("Ingrese la matrícula del vehículo: ");
                matricula = Console.ReadLine() ?? "";
                Vehiculo? consulta = listadoVehiculos.Find(n => n.Matricula == matricula);
                if (consulta == null) { Console.WriteLine("Enhorabuena, la matricula es nueva"); break; }
                else { Console.WriteLine("Desgraciadamente, la matricula ya existe"); Console.ReadKey(); }
            }
            Console.WriteLine();
            Console.Write("Ingrese el modelo: ");
            string modelo = Console.ReadLine() ?? "";
            Console.WriteLine();
            Console.Write("Ingrese el tipo de combustible: ");
            string combustible = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (tipoVehiculo)
            {
                case 1:
                    VehiculoPersonal vehiculoPersonalAgregado = new VehiculoPersonal(matricula, modelo, combustible);
                    listadoVehiculos.Add(vehiculoPersonalAgregado);
                    break;
                case 2:
                    VehiculoCorporativo vehiculoCorporativoAgregado = new VehiculoCorporativo(matricula, modelo, combustible);
                    listadoVehiculos.Add(vehiculoCorporativoAgregado);
                    break;
                default:
                    Console.WriteLine("Debes ingresar un numero del 1 al 2");
                    break;
            }
            Console.WriteLine("¡Tu vehículo ha ingresado con éxito!");
        }

        public Vehiculo(string matricula, string modelo, string tipoCombustible)
        {
            Matricula = matricula;
            Modelo = modelo;
            TipoCombustible = tipoCombustible;
        }
    }
}
