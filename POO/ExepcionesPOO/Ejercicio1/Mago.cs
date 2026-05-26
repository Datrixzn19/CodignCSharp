
namespace ManainsExc.POO;
public class Mago
{
    public int Mana { get; private set; } = 20;
    public void LanzarHechizo(int costo)
    {
        if(costo >Mana)
        {
            throw new ManaInsuficienteException("No tienes suficiente maná para este hechizo");
        }else
        {
            Mana -= costo;
            Console.WriteLine($"Hechizo lanzado. Maná restante: {Mana}");
        }
    }
}