using System;

namespace Class_III
{
    internal class Class_3_4
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad en dólares: ");
            double dolares = Convert.ToDouble(Console.ReadLine());

            double tasaCambio = 8.75;
            double colones = dolares * tasaCambio;

            Console.WriteLine("Equivalente en colones: " + colones + " CRC");
        }
    }
}