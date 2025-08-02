using System;

namespace POE
{
    internal class Class_3_3
    {
        public static void Mostrar()
        {
            Console.Write("Ingrese la temperatura en Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Temperatura en Fahrenheit: " + fahrenheit + " °F");
        }
    }
}
