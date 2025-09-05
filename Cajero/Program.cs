using System;

class Program
{
    static void Main(string[] args)
    {
        decimal saldo = 1000000; 
        int opcion = 0;

        do
        {
            Console.WriteLine("Cajero Automático");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Consignar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Tu saldo actual es: {saldo}");
                    break;

                case 2:
                    Console.Write("Ingresa el monto a depositar: ");
                    decimal deposito = decimal.Parse(Console.ReadLine());
                    saldo += deposito;
                    Console.WriteLine($"Depósito exitoso. Nuevo saldo: {saldo}");
                    break;

                case 3:
                    Console.Write("Ingresa el monto a retirar: ");
                    decimal retiro = decimal.Parse(Console.ReadLine());
                    if (retiro <= saldo)
                    {
                        saldo -= retiro;
                        Console.WriteLine($"Retiro exitoso. Nuevo saldo: {saldo}");
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Gracias por usar el cajero");
                    break;

                default:
                    Console.WriteLine("Opción no válida, intenta de nuevo.");
                    break;
            }

        } while (opcion != 4);
    }
}
