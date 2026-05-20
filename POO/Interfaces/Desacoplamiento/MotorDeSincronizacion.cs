namespace MotorSincronizacion.POO;
public interface ISincronizador //interface
{
    void Sincronizar(string datos);
}
 

 //1ra implementacion 
public class SincronizadorSQLite : ISincronizador
{
    public void Sincronizar(string datos)
    {
        Console.WriteLine($"[Local] Guardando '{datos}' en la base de datos SQLite.");
    }
}

//2da implementacion 
public class SincronizadorDrive : ISincronizador
{
    public void Sincronizar(string datos)
    {
        Console.WriteLine($"[Nube] Conectando a Google Drive... Subiendo '{datos}'");
    }
}



//Clase principal desacoplada 
public class MotorRespaldo
{
    private readonly ISincronizador _sincronizador; 


    public MotorRespaldo(ISincronizador sincronizador)
    {
        _sincronizador = sincronizador;
    }


    public void EjecutarCopiaSeguridad(string datosBoveda)
    {
        _sincronizador.Sincronizar(datosBoveda);
    }
}

/*
using MotorSincronizacion.POO;

ISincronizador sinc = new SincronizadorSQLite();
var sincronizador = new MotorRespaldo(sinc);
sincronizador.EjecutarCopiaSeguridad("Notas_Cifradas_V1");

ISincronizador sinc1 = new SincronizadorDrive();
var sincronizador1 = new MotorRespaldo(sinc1);
sincronizador1.EjecutarCopiaSeguridad("Notas_Cifradas_V1");
*/