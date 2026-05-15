
namespace SistemaArmamento.Logica;
//      Clase abstracta
public abstract class ArmaBase
{
    public string Nombre{get; init;}
    public int Municion{get; init;}
    public ArmaBase(string nombre, int municion)
    {
        Nombre = nombre;
        Municion = municion;
    }
    //metodo concreto(normal)
    public void Recargar()
    {
        Console.WriteLine($"[Sistema] {Nombre} recargada. Balas listas: {Municion}");
    }
    //los metodos abstractos no tienen cuerpo por ahora, proveen una plantilla a las hijas, no usan llaves {}
    public abstract void Disparar();
}

//  Clase 1 que hereda que la clase abstracta


public class RifleAsalto : ArmaBase
{
    public RifleAsalto(string nombre, int municion) : base(nombre, municion){}//hacemos el contructor igual que siempre al heredar 


    public override void Disparar()
    {
        Console.WriteLine($"[Ráfaga] ¡Pum pum pum! {Nombre} vaciando el cargador.");
    }
}

