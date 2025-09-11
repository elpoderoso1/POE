using System;
using System.Collections.Generic;
using System.Linq;

namespace Parcial_I
{
    public class Ejercicio2
    {
        public static void GestorInventario()
        {
            List<Producto> inventario = new List<Producto>();
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== GESTOR DE INVENTARIO ===");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Buscar producto por nombre");
                Console.WriteLine("3. Mostrar todos los productos");
                Console.WriteLine("4. Calcular valor total del inventario");
                Console.WriteLine("0. Volver al menú principal");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida.");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        AgregarProducto(inventario);
                        break;

                    case 2:
                        BuscarProducto(inventario);
                        break;

                    case 3:
                        MostrarProductos(inventario);
                        break;

                    case 4:
                        CalcularValorTotal(inventario);
                        break;

                    case 0:
                        Console.WriteLine("Volviendo al menú principal...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }

        static void AgregarProducto(List<Producto> inventario)
        {
            Console.Clear();
            Console.WriteLine("=== AGREGAR PRODUCTO ===");

            Console.Write("Nombre del producto: ");
            string nombre = Console.ReadLine();

            double precio;
            while (true)
            {
                Console.Write("Precio: ");
                if (double.TryParse(Console.ReadLine(), out precio) && precio > 0)
                    break;
                Console.WriteLine("Error: el precio debe ser mayor que 0.");
            }

            int cantidad;
            while (true)
            {
                Console.Write("Cantidad: ");
                if (int.TryParse(Console.ReadLine(), out cantidad) && cantidad >= 0)
                    break;
                Console.WriteLine("Error: la cantidad no puede ser negativa.");
            }

            inventario.Add(new Producto { Nombre = nombre, Precio = precio, Cantidad = cantidad });
            Console.WriteLine("Producto agregado correctamente.");
        }

        static void BuscarProducto(List<Producto> inventario)
        {
            Console.Clear();
            Console.WriteLine("=== BUSCAR PRODUCTO ===");
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            var encontrados = inventario.Where(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)).ToList();

            if (encontrados.Any())
            {
                foreach (var producto in encontrados)
                    Console.WriteLine($"{producto.Nombre} | Precio: {producto.Precio} | Cantidad: {producto.Cantidad} | Valor Total: {producto.ValorTotal}");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        static void MostrarProductos(List<Producto> inventario)
        {
            Console.Clear();
            Console.WriteLine("=== LISTA DE PRODUCTOS ===");

            if (!inventario.Any())
            {
                Console.WriteLine("No hay productos en el inventario.");
                return;
            }

            foreach (var producto in inventario)
                Console.WriteLine($"{producto.Nombre} | Precio: {producto.Precio} | Cantidad: {producto.Cantidad} | Valor Total: {producto.ValorTotal}");
        }
        static void CalcularValorTotal(List<Producto> inventario)
        {
            Console.Clear();
            Console.WriteLine("=== VALOR TOTAL DEL INVENTARIO ===");

            if (!inventario.Any())
            {
                Console.WriteLine("No hay productos en el inventario.");
                return;
            }

            double total = inventario.Sum(p => p.ValorTotal);
            Console.WriteLine($"Valor total: {total}");
        }
    }
}