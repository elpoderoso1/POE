using System;
using System.Collections.Generic;

namespace POE
{
    internal class Inventario
    {
        class Producto
        {
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public double Precio { get; set; }

            public double Total => Cantidad * Precio;
        }

        public static void Inventory()
        {
            List<Producto> inventario = new List<Producto>();
            string continuar;

            do
            {
                Producto prod = new Producto();
                Console.Write("Ingrese el nombre del producto: ");
                prod.Nombre = Console.ReadLine();

                Console.Write("Ingrese la cantidad: ");
                int cantidad;
                while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad < 0)
                {
                    Console.Write("Cantidad inválida. Ingrese un número entero válido: ");
                }
                prod.Cantidad = cantidad;

                Console.Write("Ingrese el precio unitario: ");
                double precio;
                while (!double.TryParse(Console.ReadLine(), out precio) || precio < 0)
                {
                    Console.Write("Precio inválido. Ingrese un número válido: ");
                }
                prod.Precio = precio;

                inventario.Add(prod);

                do
                {
                    Console.Write("¿Desea agregar otro producto? (s/n): ");
                    continuar = Console.ReadLine().ToLower();
                } while (continuar != "s" && continuar != "n");

            } while (continuar == "s");

            double totalInventario = 0;
            Console.WriteLine("\nInventario:");
            foreach (var item in inventario)
            {
                Console.WriteLine($"{item.Nombre} - Cantidad: {item.Cantidad}, Precio: {item.Precio}, Total: {item.Total}");
                totalInventario += item.Total;
            }

            Console.WriteLine($"\nTotal en inventario: {totalInventario}");
        }
    }
}
