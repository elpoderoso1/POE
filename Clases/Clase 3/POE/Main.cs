using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    internal class Class_III
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("=== CÁLCULO DE ÁREAS ===");
                Console.WriteLine("1. Área - Clase 3_1");
                Console.WriteLine("2. Promedio - Clase 3_2");
                Console.WriteLine("3. Celcius -> Fahrenheit - Clase 3_3");
                Console.WriteLine("4. Dolar -> Colon - Clase 3_4");
                Console.WriteLine("5. Años -> Meses & dias - Clase 3_5");
                Console.WriteLine("6. Perímetro - Clase 3_6");
                Console.WriteLine("7. Cuadrado & raíz cuadrada - Clase 3_7");
                Console.WriteLine("8. Salir");
                Console.Write("Seleccione una opción (1-8): ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Entrada inválida.\n");
                    continue;
                }

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        Class_3_1.Mostrar();
                        break;
                    case 2:
                        Class_3_2.Mostrar();
                        break;
                    case 3:
                        Class_3_3.Mostrar();
                        break;
                    case 4:
                        Class_3_4.Mostrar();
                        break;
                    case 5:
                        Class_3_5.Mostrar();
                        break;
                    case 6:
                        Class_3_6.Mostrar();
                        break;
                    case 7:
                        Class_3_7.Mostrar();
                        break;
                    case 8:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.\n");
                        break;
                }

                Console.WriteLine();

            } while (opcion != 8);
        }
    }
}
