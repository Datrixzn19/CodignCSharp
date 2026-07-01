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

// WHERE Filtra la colección 
// 'p =>' es una Expresión Lambda. Se lee: "Dado un elemento 'p' del inventario, devuelve true si p.Precio > 100"
// .ToList() ejecuta la consulta inmediatamente y guarda los resultados en una nueva lista en memoria.
List<Producto> productosCaros = inventario.Where(p => p.Precio > 100).ToList();

Console.WriteLine("1. CAROS (> 100):");
foreach (var p in productosCaros) 
{
    Console.WriteLine($"- {p.Nombre}");
}

// OrderBy: Ordena la colección 
// La lambda 'p => p.Precio' indica qué propiedad se usará como criterio de ordenación (ascendente por defecto).
List<Producto> inventarioOrdenado = inventario.OrderBy(p => p.Precio).ToList();

Console.WriteLine("\n2. ORDENADOS POR PRECIO:");
foreach (var p in inventarioOrdenado) 
{
    Console.WriteLine($"- {p.Nombre} (${p.Precio})");
}

// FirstOrDefault: Busca el primer elemento exacto 
// Busca el primer registro que cumpla la condición. Si no existe, devuelve 'null'.
// A diferencia de Where, no devuelve una lista, sino un único objeto de tipo 'Producto'.
Producto productoBuscado = inventario.FirstOrDefault(p => p.Nombre == "Escritorio");

Console.WriteLine("\n3. BÚSQUEDA:");
if (productoBuscado != null) // Validación para evitar excepciones (NullReferenceException)
{
    Console.WriteLine($"Encontrado: {productoBuscado.Nombre} a ${productoBuscado.Precio}");
}

// Select: Transforma o extrae datos 
// Toma una lista de objetos 'Producto' y devuelve una lista de tipos 'string' (solo los nombres).
List<string> nombres = inventario.Select(p => p.Nombre).ToList();

Console.WriteLine("\n4. SOLO NOMBRES:");
Console.WriteLine(string.Join(", ", nombres));



public class Producto
{
    public string Nombre { get; set; }
    public int Precio { get; set; }
    public string Categoria { get; set; }
}