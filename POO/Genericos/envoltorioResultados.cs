namespace envoltorioDeResultados.POO;

public class ResultadoOperacion<T>
{
    public bool Estado{get; init;}//para saber si la operacion resulto exitosa o no 
    public string Mensaje{get; init;}
    public T Datos{get; init;}

    public ResultadoOperacion(bool estado, string mensaje, T datos)
    {
        Estado = estado;
        Mensaje = mensaje;
        Datos = datos;
    }
    public void MostrarResumen()
    {
        Console.WriteLine($"[Éxito: {Estado}] Mensaje: {Mensaje} | Datos: {Datos}");
    }
}