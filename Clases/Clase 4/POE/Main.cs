using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("6. Cálculo de áreas");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción (1-7): ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo.\n");
                    continue;
                }

                Console.WriteLine();

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
                        AreaCalculator.EjectCalculator();
                        break;
                    case 7:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                Console.WriteLine();

            } while (opcion != 7);
        }
    }
}

