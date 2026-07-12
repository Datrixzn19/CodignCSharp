//cargar las texturas de un mapa de un videojuego de forma asincorna 
using System.Threading.Tasks;


Console.WriteLine("Cargando texturas en 3D");
Task<string> cargarTexturas = cargarTexturasAsync();

Console.WriteLine("Cargando perfil del jugador");
await Task.Delay(2000);
Console.WriteLine("¡Datos del jugador descargados! Nivel: 45, Monedas: 1200");
string resultado = await cargarTexturas; // como este metodo devuelve un string lo guardamos en una variable 

Console.WriteLine("TODO LISTO: Entrando al Menú Principal");
Console.WriteLine(resultado);
static async Task<string> cargarTexturasAsync()
{

    await Task.Delay(5000);
    return "¡120 Archivos de Texturas 3D listos en la memoria RAM!";
}