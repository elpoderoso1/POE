using System;

namespace POE
{
    internal class Class_3_4
    {
        public static void Mostrar()
        {
            Console.Write("Ingrese la cantidad en dólares: ");
            double dolares = Convert.ToDouble(Console.ReadLine());

            double tasaCambio = 8.75;
            double colones = dolares * tasaCambio;

            Console.WriteLine("Equivalente en colones: " + colones + " CRC");
        }
    }
}
