
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
    //los metodos abstractos no tienen cuerpo por ahora, proveen una plantilla a las hijas, no usan llaves {} ahora
    public abstract void Disparar();//abstract aqui es para obligar al hijo a sobreescribirla
}

//  Clase 1 que hereda que la clase abstracta


public class RifleAsalto : ArmaBase
{
    public RifleAsalto(string nombre, int municion) : base(nombre, municion){}//hacemos el contructor igual que siempre al heredar 


    public override void Disparar()//ahora a los metodos ya les agregamos su propio contenido, se usa override porque lo estamos sobreescribiendo
    {
        Console.WriteLine($"[Ráfaga] ¡Pum pum pum! {Nombre} vaciando el cargador.");
    }
}

/*
using SistemaArmamento.Logica;


List<ArmaBase> armas = new List<ArmaBase>
{
    new RifleAsalto("ak", 11),
    //new ArmaBase(), las clases abstractas no se pueden istanciar
};

foreach (var item in armas)
{
    item.Disparar();
    item.Recargar();
}
*/