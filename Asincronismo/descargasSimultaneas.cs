/*
//simular la descarga de dos archivos

using System;
using System.Diagnostics; // Herramienta para usar un cronómetro real
using System.Threading.Tasks;

// Preparamos nuestro cronómetro
Stopwatch cronometro = new Stopwatch();


Console.WriteLine("Guardar en Task y usar await al final");
cronometro.Restart();

// Arrancamos el video.si no hay await el programa pasa a la siguiente línea al instante.
Task tareaVideo = DescargarArchivoAsync("Video.mp4", 3000);

// Arrancamos el audio, Ambos se están descargando a la vez en el fondo.
Task tareaAudio = DescargarArchivoAsync("Audio.mp3", 2000);

Console.WriteLine("Ambas descargas están ocurriendo en el fondo simultáneamente...");

// Ya no tenemos más cosas que hacer, nos frenamos a esperar que ambas terminen.
await tareaVideo;
await tareaAudio;

cronometro.Stop();
Console.WriteLine($"[!] Tiempo total Forma 2: {cronometro.ElapsedMilliseconds / 1000} segundos.\n");

// MÉTODO ASÍNCRONO SIMULADO
static async Task DescargarArchivoAsync(string nombre, int tiempoMilisegundos)
{
    Console.WriteLine($" > Iniciando {nombre}...");
    await Task.Delay(tiempoMilisegundos); // Simulamos el tiempo de descarga
    Console.WriteLine($" > ¡{nombre} completado!");
}
*/