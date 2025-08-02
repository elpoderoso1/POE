using System;

namespace Class_III
{
    internal class Class_3_7
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            double cuadrado = Math.Pow(numero, 2);
            double raiz = Math.Sqrt(numero);

            Console.WriteLine("Cuadrado: " + cuadrado);
            Console.WriteLine("Raíz cuadrada: " + raiz);
        }
    }
}