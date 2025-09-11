using System;

namespace Parcial_I
{
    class Menu
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ PRINCIPAL ===");
                Console.WriteLine("1. Ejercicio 1 - Calculadora de Promedio");
                Console.WriteLine("2. Ejercicio 2 - Gestor de Inventario");
                Console.WriteLine("3. Ejercicio 3 - Conversor de Números a Palabras");
                Console.WriteLine("4. Ejercicio 4 - Analizador de Texto");
                Console.WriteLine("5. Ejercicio 5 - Juego de Adivinanza Mejorado");
                Console.WriteLine("0. Salir");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        Ejercicio1.CalculadoraPromedio();
                        break;
                    case "2":
                        Ejercicio2.GestorInventario();
                        break;
                    case "3":
                        Ejercicio3.ConversorNumeros();
                        break;
                    case "4":
                        Ejercicio4.AnalizadorTexto();
                        break;
                    case "5":
                        Ejercicio5.JuegoAdivinanza();
                        break;
                    case "0":
                        salir = true;
                        Console.WriteLine("\nSaliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
