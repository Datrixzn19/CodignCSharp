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

/*
using envoltorioDeResultados.POO;

ResultadoOperacion<int> resultado1 = new ResultadoOperacion<int>(true, "Usuario encontrado", 1050);
resultado1.MostrarResumen();
ResultadoOperacion<string> resultado2 = new ResultadoOperacion<string>(true, "Token Generado", "ABC-123-XYZ");
resultado2.MostrarResumen();
*/