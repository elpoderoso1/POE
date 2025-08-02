using System;

namespace POE
{
    internal class Class_3_6
    {
        public static void Mostrar()
        {
            Console.Write("Ingrese la longitud del lado 1: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la longitud del lado 2: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la longitud del lado 3: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            double perimetro = lado1 + lado2 + lado3;
            Console.WriteLine("Perímetro del triángulo: " + perimetro);
        }
    }
}
