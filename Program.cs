using System;
using System.Collections.Generic;
using System.Linq;


List<Producto> inventario = new List<Producto>
{
    new Producto { Nombre = "Laptop", Precio = 1200, Categoria = "Electrónica" },
    new Producto { Nombre = "Ratón", Precio = 25, Categoria = "Electrónica" },
    new Producto { Nombre = "Escritorio", Precio = 300, Categoria = "Muebles" },
    new Producto { Nombre = "Silla", Precio = 150, Categoria = "Muebles" }
};


/*
// OrderBy: Ordena la colección 
// La lambda 'p => p.Precio' indica qué propiedad se usará como criterio de ordenación (ascendente por defecto).
List<Producto> inventarioOrdenado = inventario.OrderBy(p => p.Precio).ToList();

Console.WriteLine("\n2. ORDENADOS POR PRECIO:");
foreach (var p in inventarioOrdenado) 
{
    Console.WriteLine($"- {p.Nombre} (${p.Precio})");
}

*/


public class Producto
{
    public string Nombre { get; set; }
    public int Precio { get; set; }
    public string Categoria { get; set; }
}