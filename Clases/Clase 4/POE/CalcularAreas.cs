using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    internal class AreaCalculator
    {
        public static void EjectCalculator()
        {
            Console.WriteLine("=== Area de Figuras Geometricas ===");

            // Rectangulo: metodo con parametros y con retorno
            double resultadoRectangulo = ObtenerAreaRectangulo(8, 3);
            Console.WriteLine("Rectangulo -> Area: " + resultadoRectangulo + " m²");

            // Circulo: metodo con parametros y sin retorno
            MostrarAreaDeCirculo(4.5);

            // Triangulo: metodo sin parametros y con retorno
            double resultadoTriangulo = PedirDatosTriangulo();
            Console.WriteLine("Triangulo -> Area: " + resultadoTriangulo + " m²");

            Console.WriteLine("Calculos finalizados.");
            Console.ReadLine();
        }

        // Metodo con parametros y con retorno
        static double ObtenerAreaRectangulo(double ancho, double largo)
        {
            return ancho * largo;
        }

        // Metodo sin parametros pero con retorno
        static double PedirDatosTriangulo()
        {
            Console.Write("Base del triangulo: ");
            double baseT = Convert.ToDouble(Console.ReadLine());

            Console.Write("Altura del triangulo: ");
            double alturaT = Convert.ToDouble(Console.ReadLine());

            return (baseT * alturaT) / 2;
        }

        // Metodo con parametros y sin retorno
        static void MostrarAreaDeCirculo(double radio)
        {
            double area = Math.PI * radio * radio;
            Console.WriteLine($"Circulo -> Area: {area:F2} m²");
        }
    }
}
