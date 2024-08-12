//No sé que hacer

do
{
    try
    {
        Console.WriteLine("Bienvenido a Toyota");
        Console.WriteLine("1. Menú para usuarios administrativos");
        Console.WriteLine("2. Menú para clientes");
        Console.Write("Ingrese su respuesta: ");
        int menuType = Convert.ToInt32(Console.ReadLine());

        switch (menuType) 
        {
            case 1:              
                break;
            case 2:
                break;
        }
        do
        {

        } while (true);
    } catch (Exception ex) 
    { 
        Console.WriteLine("a" + ex);
    }
    } while (true) ;

int MenuUser() 
{
    Console.WriteLine("Has ingresado al menu de usuarios");
    Console.WriteLine("1. Agregar clientes");
    Console.WriteLine("2. Registrar pedidos para clientes");
    Console.WriteLine("3. Ver todos los clientes registrados");
    Console.WriteLine("4. Ver todos los vehículos registrados");
    Console.WriteLine("5. Ver todos los pedidos registrados");
    Console.WriteLine("6. Búsqueda específica");

    Console.Write("Ingrese su respuesta: ");
    int optionSwitch = Convert.ToInt32(Console.ReadLine());
    return optionSwitch;
}

int MenuClient()
{
    Console.WriteLine("Has ingresado al menu de clientes");
    Console.WriteLine("1. Registrar vehículos");
    Console.WriteLine("2. Registrar pedidos para clientes");
    Console.WriteLine("3. Ver todos los clientes registrados");
    Console.WriteLine("4. Búsqueda específica");

    Console.Write("Ingrese su respuesta: ");
    int optionSwitch = Convert.ToInt32(Console.ReadLine());
    return optionSwitch;
}

