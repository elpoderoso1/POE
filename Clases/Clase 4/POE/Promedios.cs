using System;

namespace POE
{
    internal class Promedios
    {
        public static void Prome()
        {
            Console.Write("¿Cuántas calificaciones desea ingresar?: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double suma = 0;

            for (int i = 1; i <= n; i++)
            {
                double nota;
                do
                {
                    Console.Write($"Ingrese la calificación {i} (0 a 10): ");
                    nota = Convert.ToDouble(Console.ReadLine());

                    if (nota < 0 || nota > 10)
                        Console.WriteLine("Nota inválida. Debe estar entre 0 y 10.");

                } while (nota < 0 || nota > 10);
            }

            double promedio = suma / n;
            Console.WriteLine($"Promedio: {promedio}");

            if (promedio < 6)
                Console.WriteLine("Rendimiento: Bajo");
            else if (promedio < 8)
                Console.WriteLine("Rendimiento: Regular");
            else
                Console.WriteLine("Rendimiento: Excelente");
        }
    }
}
