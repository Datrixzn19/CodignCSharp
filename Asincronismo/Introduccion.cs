/*

Console.WriteLine("1. Solicitando el catálogo a la base de datos...");

// Pausa, se hace otras actividades y cuando TerminarDescargaAsync termine, guarda el resultado en 'mensaje' y continúa".
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


*/