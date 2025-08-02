using System;

namespace POE
{
    internal class Class_3_5
    {
        public static void Mostrar()
        {
            Console.Write("Ingrese su edad en años: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            int meses = edad * 12;
            int dias = edad * 365;

            Console.WriteLine("Has vivido aproximadamente " + meses + " meses y " + dias + " días.");
        }
    }
}
