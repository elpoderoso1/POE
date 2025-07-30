using System;

namespace POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("==== MENÚ PRINCIPAL ====");
                Console.WriteLine("1. Calculadora");
                Console.WriteLine("2. Suma con ciclo for");
                Console.WriteLine("3. Verificación de contraseña");
                Console.WriteLine("4. Promedio de calificaciones");
                Console.WriteLine("5. Sistema de inventario");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción (1-6): ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo.\n");
                    continue;
                }

                Console.WriteLine(); // espacio extra

                switch (opcion)
                {
                    case 1:
                        Calculadora.Calculator();
                        break;
                    case 2:
                        SumaFor.SumFor();
                        break;
                    case 3:
                        Contra.Password();
                        break;
                    case 4:
                        Promedios.Prome();
                        break;
                    case 5:
                        Inventario.Inventory();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                Console.WriteLine();

            } while (opcion != 6);
        }
    }
}
