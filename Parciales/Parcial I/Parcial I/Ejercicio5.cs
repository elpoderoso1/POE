using System;
using System.Collections.Generic;
using System.Linq;

namespace Parcial_I
{
    public class Ejercicio5
    {
        enum Dificultad
        {
            Facil = 1,
            Normal = 2,
            Dificil = 3
        }

        public static void JuegoAdivinanza()
        {
            Console.Clear();
            Console.WriteLine("=== Ejercicio 5: Juego de Adivinanza Mejorado ===\n");

            List<int> puntuaciones = new List<int>();
            bool jugarDeNuevo;

            do
            {
                Dificultad dificultad = SeleccionarDificultad();
                int max;
                switch (dificultad)
                {
                    case Dificultad.Facil:
                        max = 50;
                        break;
                    case Dificultad.Normal:
                        max = 100;
                        break;
                    case Dificultad.Dificil:
                        max = 200;
                        break;
                    default:
                        max = 100;
                        break;
                }

                Random rnd = new Random();
                int numeroSecreto = rnd.Next(1, max + 1);
                int intentos = 0;
                int intento;

                Console.WriteLine($"\nHe pensado un número entre 1 y {max}. ¡Adivínalo!");

                do
                {
                    Console.Write("Ingresa tu intento: ");
                    while (!int.TryParse(Console.ReadLine(), out intento))
                    {
                        Console.Write("Entrada inválida. Ingresa un número: ");
                    }

                    intentos++;

                    if (intento == numeroSecreto)
                    {
                        Console.WriteLine($"\n¡Correcto! Lo adivinaste en {intentos} intentos.");
                        puntuaciones.Add(intentos);
                        break;
                    }
                    else
                    {
                        int diferencia = Math.Abs(numeroSecreto - intento);
                        string pista;
                        if (diferencia <= 3) pista = "Muy cerca";
                        else if (diferencia <= 10) pista = "Cerca";
                        else if (diferencia <= 20) pista = "Lejos";
                        else pista = "Muy lejos";

                        Console.WriteLine($"Incorrecto. Pista: {pista}");
                    }

                } while (true);

                Console.WriteLine("\n=== Estadísticas de Partidas ===");
                Console.WriteLine($"Total de partidas: {puntuaciones.Count}");
                Console.WriteLine($"Mejor puntuación (menos intentos): {puntuaciones.Min()}");
                Console.WriteLine($"Promedio de intentos: {puntuaciones.Average():F2}");
                Console.WriteLine($"Intentos ordenados: {string.Join(", ", puntuaciones.OrderBy(x => x))}");

                Console.Write("\n¿Quieres jugar otra vez? (s/n): ");
                string respuesta = Console.ReadLine()?.Trim().ToLower();
                jugarDeNuevo = respuesta == "s";

            } while (jugarDeNuevo);

            Console.WriteLine("\nGracias por jugar. Presiona cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        private static Dificultad SeleccionarDificultad()
        {
            while (true)
            {
                Console.WriteLine("Selecciona la dificultad:");
                Console.WriteLine("1. Fácil (1-50)");
                Console.WriteLine("2. Normal (1-100)");
                Console.WriteLine("3. Difícil (1-200)");
                Console.Write("Opción: ");

                if (int.TryParse(Console.ReadLine(), out int opcion) &&
                    Enum.IsDefined(typeof(Dificultad), opcion))
                {
                    return (Dificultad)opcion;
                }
                else
                {
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.\n");
                }
            }
        }
    }
}