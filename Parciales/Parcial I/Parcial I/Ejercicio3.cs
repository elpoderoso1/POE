using System;

namespace Parcial_I
{
    public class Ejercicio3
    {
        public static void ConversorNumeros()
        {
            Console.Clear();
            Console.WriteLine("=== CONVERSOR DE NÚMEROS A PALABRAS ===");
            Console.WriteLine("Ingrese un número entre 1 y 999 (0 para salir).");

            int numero;
            do
            {
                Console.Write("\nNúmero: ");
                if (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo.");
                    continue;
                }

                if (numero == 0)
                {
                    Console.WriteLine("Saliendo del conversor...");
                    break;
                }

                if (numero < 1 || numero > 999)
                {
                    Console.WriteLine("El número debe estar entre 1 y 999.");
                    continue;
                }

                string resultado = ConvertirNumeroAPalabras(numero);
                Console.WriteLine($"{numero} = \"{resultado}\"");

            } while (numero != 0);
        }

        static string ConvertirNumeroAPalabras(int numero)
        {
            string[] unidades = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
            string[] decenas = { "", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
            string[] especiales = { "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" };
            string[] centenas = { "", "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };

            int centena = numero / 100;
            int resto = numero % 100;
            int decena = resto / 10;
            int unidad = resto % 10;

            string resultado = "";

            if (numero == 100) return "cien";
            if (centena > 0) resultado += centenas[centena] + " ";

            if (resto >= 10 && resto <= 19)
            {
                resultado += especiales[resto - 10];
                return resultado.Trim();
            }

            if (resto >= 20 && resto <= 29)
            {
                if (resto == 20) return resultado + "veinte";
                resultado += "veinti" + unidades[unidad];
                return resultado.Trim();
            }

            if (decena > 0)
            {
                resultado += decenas[decena];
                if (unidad > 0) resultado += " y ";
            }

            if (unidad > 0) resultado += unidades[unidad];

            return resultado.Trim();
        }
    }


}