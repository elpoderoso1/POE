using System;

namespace Class_III
{
    internal class Class_3_3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la temperatura en Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Temperatura en Fahrenheit: " + fahrenheit + " °F");
        }
    }
}