using System;

namespace POE
{
    internal class Class_3_7
    {
        public static void Mostrar()
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
