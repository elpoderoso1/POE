﻿public class Producto
{
    // Propiedades automáticas
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Cantidad { get; set; }

    // Propiedad calculada
    public double ValorTotal => Precio * Cantidad;
}
