int contraseña = 12345678;

Console.WriteLine("Ingrese contraseña numérica de 8 dígitos:");
int contraseñaIngresada = int.Parse(Console.ReadLine());

if(contraseña == contraseñaIngresada)
{
    Console.WriteLine("Bienvenido");
}
else
{
    Console.WriteLine("Ingrese contraseña nuevamente");
    contraseñaIngresada = int.Parse(Console.ReadLine());
    if (contraseña == contraseñaIngresada)
    {
        Console.WriteLine("Bienvenido");
    }
    else
    {
        Console.WriteLine("Reiniciar el sistema");
    }
}