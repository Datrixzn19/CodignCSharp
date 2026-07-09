
using System.Threading.Tasks;
/*
Reto: Pantalla de Carga (Texturas 4K vs Perfil de Usuario)
Cuando abres un juego moderno, el motor gráfico tiene que hacer dos cosas para dejarte jugar:

Cargar los archivos de texturas en 3D (pesadísimo, tarda 5 segundos).
Descargar los datos del perfil del jugador (sus monedas, su nivel, etc. Tarda 2 segundos).
Tu misión es programar este flujo desde cero:

Crea el método de las texturas: Escribe un método llamado CargarTexturasAsync(). Esta vez no debe ser Task a secas, debe devolver un texto, es decir, su tipo de dato debe ser Task<string>. Adentro, ponle un retraso de 5 segundos (5000 milisegundos) y al final haz que haga un return "¡120 Archivos de Texturas 3D listos en la memoria RAM!";

Arranca las texturas en el fondo: En tu hilo principal, llama al método y guárdalo en una variable. Como el método devuelve un Task<string>, tu variable debe ser de tipo Task<string>. (No uses await todavía).

Carga el perfil del jugador en el hilo principal: Inmediatamente después, simula que descargas el perfil del usuario. Pon un mensaje de "Descargando nivel y monedas del jugador...", haz una pausa directa en el hilo principal de 2 segundos (await Task.Delay(2000);), e imprime "¡Datos del jugador descargados! Nivel: 45, Monedas: 1200".

Espera las texturas y atrapa el mensaje: Ahora que ya tienes el perfil, el juego no puede arrancar hasta que las texturas terminen. Usa la palabra await con la variable del paso 2 para frenar el programa. Como este método sí devuelve un texto, guárdalo en una variable normal tipo string.

Fin: Imprime en la pantalla el string que te devolvió el método de las texturas y remata con un mensaje que diga: "=== TODO LISTO: Entrando al Menú Principal ===".
*/



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