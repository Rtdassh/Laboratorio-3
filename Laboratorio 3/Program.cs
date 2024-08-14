//No sé que hacer
using Laboratorio_3;

do
{
    try
    {
        LecturaSwitchGlobal();
    } catch (Exception ex) 
    { 
        Console.WriteLine("a" + ex);
    }
    } while (true) ;

int Menu() 
{
    Console.Clear();
    Console.WriteLine("Has ingresado al menu de usuarios administrativos");
    Console.WriteLine("1. Agregar clientes");
    Console.WriteLine("2. Registrar vehículos");
    Console.WriteLine("3. Registrar pedidos");
    Console.WriteLine("4. Ver todas las listas registradas");
    Console.WriteLine("5. Búsqueda específica");

    Console.Write("Ingrese su respuesta: ");
    int optionSwitch = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    return optionSwitch;
}

void LecturaSwitchGlobal()
{
    switch (Menu())
    {
        case 1:
            User.AgregarCliente();
            break;
        case 2:
            Vehiculo.AgregarVehiculo();
            break;
        case 3:
            Pedido.AgregarPedido();
            break;
        case 4:
            LecturaSwitchListas();
            break;
        case 5:
            break;
        case 6:
            Console.WriteLine("Ciao amigo!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("No se reconoció la opción :(");
            break;
    }
    Console.ReadKey();
}
int MenuListas()
{
    Console.Clear();
    Console.WriteLine("Has ingresado al menu de resumen de listas");
    Console.WriteLine("1. Ver todos los clientes");
    Console.WriteLine("2. Ver todos los vehículos");
    Console.WriteLine("3. Ver todos los pedidos");

    Console.Write("Ingrese su respuesta: ");
    int optionSwitch = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    return optionSwitch;
}
void LecturaSwitchListas()
{
    switch (MenuListas())
    {
        case 1:
            foreach (Cliente cliente in User.listadoUsuarios) 
            {
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine($"Id: {cliente.ID} || Nombre: {cliente.Nombre}|| Correo: {cliente.Correo}");
                Console.WriteLine($"|| Dirección: {cliente.Direccion}");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine();
            }
            break;
        case 2:
            foreach (Vehiculo vehiculo in Vehiculo.listadoVehiculos)
            {
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine($"Matricula: {vehiculo.Matricula} || Modelo: {vehiculo.Modelo}|| Tipo de combustible: {vehiculo.TipoCombustible}");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine();
            }
            break;
        case 3:
            foreach (Pedido pedido in Pedido.listadoPedidos)
            {
                double total = Pedido.CalcularTotal(pedido.IdCliente);
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine($"Número de pedido: {pedido.NumeroPedido} || Fecha: {pedido.FechaPedido}|| ID del Cliente: {pedido.IdCliente}");
                Console.WriteLine($"Cantidad total de pago: {total}");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine();
            }
            break;
        default:
            Console.WriteLine("No se reconoció la opción :(");
            break;
    }
}


