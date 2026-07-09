using System;
using System.Threading.Tasks;


Console.WriteLine("=== PREPARANDO EL CAFÉ ASÍNCRONO ===\n");


Console.WriteLine("Ponemos a calentar el agua");
Task calentar = CalentarAguaAsync();


// no tiene await, por lo que podemos hacer otras cosas 
Console.WriteLine("Pasando al paso 2... Moliendo los granos y preparando la taza.");
Console.WriteLine("Taza lista con café en polvo.");


// Ahora para poder terminar el café, necesitamos que ya el agua esté lista forzosamente.
Console.WriteLine("\n-> Esperando a que el agua termine de hervir...");


await calentar;//nos sentamos a esperar que esto este listo 

Console.WriteLine("\n=== ¡CAFÉ LISTO PARA TOMAR! ===");



// MÉTODO ASÍNCRONO 

static async Task CalentarAguaAsync()
{
    Console.WriteLine(" [Agua] Encendiendo la cocina...");
    await Task.Delay(3000); // El agua tarda 3 segundos en hervir
    Console.WriteLine(" [Agua] ¡El agua ha hervido con éxito!");
}

