using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Parcial_I
{
    public class Ejercicio4
    {
        public static void AnalizadorTexto()
        {
            Console.Clear();
            Console.WriteLine("=== Ejercicio 4: Analizador de Texto ===\n");

            Console.Write("Ingrese el texto a analizar: ");
            string texto = Console.ReadLine() ?? "";

            string textoLimpio = Regex.Replace(texto, @"\s+", " ").Trim();

            int totalCaracteresConEspacios = texto.Length;
            int totalCaracteresSinEspacios = texto.Count(c => !char.IsWhiteSpace(c));
            string[] palabras = textoLimpio.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int totalPalabras = palabras.Length;

            int totalOraciones = Regex.Matches(texto, @"[.!?]").Count;

            string palabraMasLarga = palabras.OrderByDescending(p => p.Length).FirstOrDefault() ?? "";
            string palabraMasCorta = palabras.OrderBy(p => p.Length).FirstOrDefault() ?? "";

            var vocales = new Dictionary<char, int> { { 'a', 0 }, { 'e', 0 }, { 'i', 0 }, { 'o', 0 }, { 'u', 0 } };
            foreach (char c in texto.ToLower())
            {
                if (vocales.ContainsKey(c))
                    vocales[c]++;
            }

            var conteoPorLetra = palabras
                .Where(p => p.Length > 0)
                .GroupBy(p => char.ToUpper(p[0]))
                .OrderBy(g => g.Key)
                .Select(g => new { Letra = g.Key, Cantidad = g.Count() });

            // --- Resultados ---
            Console.WriteLine($"\nTotal de caracteres (con espacios): {totalCaracteresConEspacios}");
            Console.WriteLine($"Total de caracteres (sin espacios): {totalCaracteresSinEspacios}");
            Console.WriteLine($"Total de palabras: {totalPalabras}");
            Console.WriteLine($"Total de oraciones: {totalOraciones}");
            Console.WriteLine($"Palabra más larga: {palabraMasLarga}");
            Console.WriteLine($"Palabra más corta: {palabraMasCorta}");

            Console.WriteLine("\nFrecuencia de vocales:");
            foreach (var v in vocales)
                Console.WriteLine($"{v.Key}: {v.Value}");

            Console.WriteLine("\nConteo de palabras por letra inicial:");
            foreach (var grupo in conteoPorLetra)
                Console.WriteLine($"{grupo.Letra}: {grupo.Cantidad}");

            Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}