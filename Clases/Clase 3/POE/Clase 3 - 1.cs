using System;

namespace POE
{
    internal class Class_3_1
    {
        public static void Mostrar()
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
