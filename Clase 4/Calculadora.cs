using System;

namespace POE
{
    internal class Calculadora
    {
        public static void Calculator()
        {
            int opcion;
            do
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el primer número: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {a + b}");
                        break;
                    case 2:
                        Console.Write("Ingrese el primer número: ");
                        double x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        double y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {x - y}");
                        break;
                    case 3:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine();

            } while (opcion != 3);
        }
    }
}
