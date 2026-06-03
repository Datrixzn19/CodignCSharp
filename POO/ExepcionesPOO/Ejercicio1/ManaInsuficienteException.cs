
namespace ManainsExc.POO;
public class ManaInsuficienteException : Exception
{
    public ManaInsuficienteException(string mensaje) : base(mensaje){}
}


/*
Program cs 

using ManainsExc.POO;

Mago miMago = new Mago();

try 
{
    miMago.LanzarHechizo(5);  
    miMago.LanzarHechizo(5);  //aun funciona 
    miMago.LanzarHechizo(20); // err
    miMago.LanzarHechizo(30); // Esta línea ya no se va a ejecutar
}

catch (ManaInsuficienteException ex)
{

    Console.WriteLine($"[Aviso del Sistema]: {ex.Message}");
}

Console.WriteLine("El combate continúa...");



*/