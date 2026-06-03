
namespace excLogistica.POO;
public class PesoInvalidoException : Exception //Para cuando el peso sea 0 o negativo
{
    public PesoInvalidoException(string msj) : base(msj){}
}


public class SobrepesoException : Exception//Para cuando se exeda el peso permitido 
{
    public SobrepesoException(string msj) : base(msj){}
}