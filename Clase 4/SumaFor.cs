using System;

namespace POE
{
    internal class SumaFor
    {
        public static void SumFor()
        {
            Console.Write("¿Cuántos números desea ingresar?: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            int suma = 0;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                suma += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"La suma total es: {suma}");
        }
    }
}
