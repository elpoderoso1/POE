using System;

public class Ejercicio1
{
    public static void Ejecutar()
    {
        Console.Clear();
        Console.WriteLine("=== Ejercicio 1: Calculadora de Promedio de Calificaciones ===");

        int cantidadNotas;
        while (true)
        {
            Console.Write("Ingrese la cantidad de notas a procesar: ");
            if (int.TryParse(Console.ReadLine(), out cantidadNotas) && cantidadNotas > 0)
                break;
            Console.WriteLine("❌ Error: ingrese un número entero válido mayor que 0.");
        }

        double[] notas = new double[cantidadNotas];

        for (int i = 0; i < cantidadNotas; i++)
        {
            double nota;
            while (true)
            {
                Console.Write($"Ingrese la nota {i + 1} (0 a 10): ");
                if (double.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 10)
                {
                    notas[i] = nota;
                    break;
                }
                Console.WriteLine("❌ Error: ingrese un número entre 0 y 10.");
            }
        }

        double suma = 0;
        double max = notas[0];
        double min = notas[0];

        for (int i = 0; i < cantidadNotas; i++)
        {
            suma += notas[i];
            if (notas[i] > max) max = notas[i];
            if (notas[i] < min) min = notas[i];
        }

        double promedio = suma / cantidadNotas;

        Console.WriteLine("\n=== Resultados ===");
        Console.WriteLine($"Promedio: {promedio:F2}");
        Console.WriteLine($"Nota más alta: {max}");
        Console.WriteLine($"Nota más baja: {min}");
        Console.WriteLine(promedio >= 7 ? "✅ Estado: APROBADO" : "❌ Estado: REPROBADO");
    }
}
