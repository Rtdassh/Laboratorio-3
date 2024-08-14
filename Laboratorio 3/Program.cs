//No sé que hacer
using Laboratorio_3;

do
{
    try
    {
        LecturaSwitch();
    } catch (Exception ex) 
    { 
        Console.WriteLine("a" + ex);
    }
    } while (true) ;

int Menu() 
{
    Console.WriteLine("Has ingresado al menu de usuarios administrativos");
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

void LecturaSwitch()
{
    switch (Menu())
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
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



