
namespace excLogistica.POO;
public class PesoInvalidoException : Exception //Para cuando el peso sea 0 o negativo
{
    public PesoInvalidoException(string msj) : base(msj){}
}


public class SobrepesoException : Exception//Para cuando se exeda el peso permitido 
{
    public SobrepesoException(string msj) : base(msj){}
}

/*
using excLogistica.POO;


Bascula basc = new Bascula();


try
{
    //basc.ProcesaPaquete(50);
    basc.ProcesaPaquete(49.9);
    basc.ProcesaPaquete(0);
}
catch (PesoInvalidoException ex)
{
    
    Console.WriteLine($"ERROR {ex.Message}");
}
catch(SobrepesoException ex)
{
    Console.WriteLine($"ERROR {ex.Message}");
}
*/