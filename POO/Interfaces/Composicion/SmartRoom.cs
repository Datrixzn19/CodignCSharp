namespace SmartHome.POO;
public interface IIluminacion
{
    void EncenderLuces();
    
}
public class LucesLed : IIluminacion
{
    public void EncenderLuces()
    {
        Console.WriteLine("[Iluminación] Encendiendo paneles LED en tono cálido.");
    }
}



public interface IClimatizacion
{
    void AjustarTemperatura(int grados);
}
public class AireAcondicionado : IClimatizacion
{
    public void AjustarTemperatura(int grados)
    {
        Console.WriteLine($"[Clima] Ajustando el aire a {grados}°C.");
    }
}


//Clase compuesta

public class HabitacionInteligente
{
    private readonly IIluminacion _iluminacion;
    private readonly IClimatizacion _climatizacion;
    public HabitacionInteligente(IClimatizacion climatizacion, IIluminacion iluminacion)
    {
        _climatizacion = climatizacion;
        _iluminacion = iluminacion;
    }
    public void ActivarModoNoche()
    {
        _iluminacion.EncenderLuces();
        _climatizacion.AjustarTemperatura(22);
    }
}
