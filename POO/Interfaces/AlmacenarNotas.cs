
namespace GuardarNotas.Logica;

public interface IGuardadorNotas//interfaz, declaramos los metodos, no tienen contenido ni llaves
{
    public void GuardarNota(string titulo, string contenido);
}

public class GuardadorLocal : IGuardadorNotas
{
    public void GuardarNota(string titulo, string contenido)
    {
        
        Console.WriteLine($"[Local] Guardando '{titulo}.txt' en el disco. Contenido: {contenido}");
    }
}



public class GuardadorNube : IGuardadorNotas
{
    public void GuardarNota(string titulo, string contenido)
    {
        
        Console.WriteLine($"[Backend] Conectando a la base de datos... Nota '{titulo}' sincronizada de forma segura.");
    }
}


