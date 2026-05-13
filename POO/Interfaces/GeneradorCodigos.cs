namespace GeneradorDeCodigos;


public interface IGeneradorCodigos
{
    string GenerarCodigo(int longitud);//desde c#8 no es necesario poner public porque se asume que las interfaces son publicas
    //es convencios dejarlo sin el public 
}


public class GeneradorPin : IGeneradorCodigos
{
    public string GenerarCodigo(int longitud)
    {
        return  $"[PIN Numérico de {longitud} dígitos generados]";
    }
}

public class GeneradorTokenBiometrico : IGeneradorCodigos
{
    public string GenerarCodigo(int longitud)
    {
        return  $"[Hash Biométrico de {longitud} caracteres encriptados]";
    }
}

/*

using GeneradorDeCodigos;

List<IGeneradorCodigos> generador = new List<IGeneradorCodigos>
{
    new GeneradorTokenBiometrico(),
    new GeneradorPin(),
};


foreach(var g in generador)
{
    string res = g.GenerarCodigo(8);
    Console.WriteLine(res);
}
*/