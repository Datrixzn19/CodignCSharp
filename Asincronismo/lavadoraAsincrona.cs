/*
using System.Threading.Tasks;


Console.WriteLine("Ponemos a funcionar la lavadora");
Task lavar = LavarRopaAsync();


Console.WriteLine("Mientras se lava la ropa, me pongo a barrer...");
await Task.Delay(2000);
Console.WriteLine("Terminé de barrer");

Console.WriteLine("Esperando que la lavadora termine");
await lavar;
Console.WriteLine("Ya terminó, ahora a colgar la ropa");


static async Task LavarRopaAsync()
{
    Console.WriteLine("La lavadora arrancó");
    await Task.Delay(4000);
    Console.WriteLine("La lavadora terminó");
} 

*/