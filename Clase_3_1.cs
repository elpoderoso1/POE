using System;

namespace Class_III
{
    internal class Class_3_1
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la base del terreno (m): ");
            double baseTerreno = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura del terreno (m): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double area = baseTerreno * altura;
            Console.WriteLine("Área del terreno: " + area + " m²");
        }
    }
}