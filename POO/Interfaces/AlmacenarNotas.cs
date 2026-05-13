
namespace GuardarNotas.Logica;

public interface IGuardadorNotas//interfaz, declaramos los metodos, no tienen contenido ni llaves
{
    void GuardarNota(string titulo, string contenido);
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


/*
// PROGRAM.CS
using GuardarNotas.Logica;


//<IGuardadorNotas>, le decimos al compilador: Esta lista SOLO aceptará objetos instanciados de clases que hayan implementado esta interfaz
List<IGuardadorNotas> listaGuardadores = new List<IGuardadorNotas>
{
    // Podemos mezclar diferentes clases dentro de la misma lista, 
    // porque ambas cumplen con la regla de ser 'IGuardadorNotas'.
    new GuardadorLocal(),
    new GuardadorNube()
};

foreach (var guardador in listaGuardadores)
{
    // Al llamar al método, el programa no sabe si es la versión Local o Nube,
    // solo confía en el contrato. El polimorfismo se encarga de ejecutar 
    // la versión correcta según el objeto que esté en memoria en ese momento.
    guardador.GuardarNota("BioVault_Draft", "Estructurando la base de datos para las notas seguras.");
}
*/