using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            decimal resultado;
            decimal baseFigura, altura, radio;

            do
            {
                Console.WriteLine("\n=== CALCULO DE AREAS ===");
                Console.WriteLine("1. Area de rectangulo");
                Console.WriteLine("2. Area de triangulo");
                Console.WriteLine("3. Area de circulo");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opcion (0-3): ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingresa un numero valido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1: // Rectangulo: metodo con parametros y retorno
                        Console.Write("Introduce la base: ");
                        baseFigura = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Introduce la altura: ");
                        altura = Convert.ToDecimal(Console.ReadLine());

                        resultado = CalcularAreaRectangulo(baseFigura, altura);
                        Console.WriteLine("El area del rectangulo es: {0} m²", resultado);
                        break;

                    case 2: // Triangulo: metodo sin parametros pero con retorno
                        resultado = CalcularAreaTriangulo();
                        Console.WriteLine("El area del triángulo es: {0} m²", resultado);
                        break;

                    case 3: // Circulo: metodo con parametros y sin retorno
                        Console.Write("Introduce el radio del circulo: ");
                        radio = Convert.ToDecimal(Console.ReadLine());

                        MostrarAreaCirculo(radio);
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida. Intenta de nuevo.");
                        break;
                }

            } while (opcion != 0);
        }

        // Metodo con parametros y con retorno
        static decimal CalcularAreaRectangulo(decimal baseRect, decimal altura)
        {
            return baseRect * altura;
        }

        // Metodo sin parametros pero con retorno
        static decimal CalcularAreaTriangulo()
        {
            decimal baseTri, altura, area;

            Console.Write("Introduce la base del triangulo: ");
            baseTri = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Introduce la altura del triangulo: ");
            altura = Convert.ToDecimal(Console.ReadLine());

            area = (baseTri * altura) / 2;
            return area;
        }

        // Metodo con parametros y sin retorno
        static void MostrarAreaCirculo(decimal radio)
        {
            decimal area = (decimal)Math.PI * radio * radio;
            Console.WriteLine("El area del circulo es: {0:F2} m²", area);
        }
    }
}
