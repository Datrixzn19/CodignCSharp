List<Producto> inventario = new List<Producto>
{
    new Producto { Nombre = "Laptop", Precio = 1200, Categoria = "Electrónica" },
    new Producto { Nombre = "Ratón", Precio = 25, Categoria = "Electrónica" },
    new Producto { Nombre = "Escritorio", Precio = 300, Categoria = "Muebles" },
    new Producto { Nombre = "Silla", Precio = 150, Categoria = "Muebles" }
};

Console.WriteLine("1. Solicitando el catálogo a la base de datos...");

// El 'await' es la campana del chef. 
// Le dice a C#: "Pausa esta línea aquí, ve a hacer otras cosas si quieres, y cuando 
// TerminarDescargaAsync termine, guarda el resultado en 'mensaje' y continúa".
string mensaje = await DescargarDatosAsync();

Console.WriteLine($"3. Resultado: {mensaje}");



// MÉTODO ASÍNCRONO SIMULADO
// La palabra 'async' avisa que usaremos 'await' adentro.
// 'Task<string>' significa que devolverá un texto, pero en el futuro (es una promesa).
static async Task<string> DescargarDatosAsync()
{
    Console.WriteLine("2. (Servidor procesando... esto tomará 3 segundos)");
    
    // Simulamos una demora de red de 3000 milisegundos 
    await Task.Delay(3000); 
    
    return "¡Los videojuegos han sido descargados con éxito!";
}

















public class Producto
{
    public string Nombre { get; set; }
    public int Precio { get; set; }
    public string Categoria { get; set; }
}