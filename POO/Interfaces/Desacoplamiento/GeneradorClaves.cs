

namespace GeneradorClaves.POO;
public interface IGeneradorClaves
{
    //no es necesario poner public porque las interfaces deberian ser publicas
    string Generar();
}

//primera implementacion de la interfaz
public class GeneradorPinBasico : IGeneradorClaves
{
    public string Generar()
    {
        return "1234";
    }
}

//segunda implementacion 
public class GeneradorTokenBiometricoInterf : IGeneradorClaves
{
    public string Generar() => "Token_Huella_X98P";//probando esta forma acortada del return 
}


//Clase principal DESCOPLADA

public class GestorBoveda
{
    private readonly IGeneradorClaves _a;//perdon puse este nombre porque no entendia bien lo que hacia

    public GestorBoveda(IGeneradorClaves a)
    {
        _a = a;
    }
    public void ProtegerArchivo(string nombreArchivo)
    {
        string g = _a.Generar();
        Console.WriteLine($"[BioVault] El archivo '{nombreArchivo}' fue asegurado con la credencial: {g}");
    }

}

/*


using GeneradorClaves.POO;


IGeneradorClaves gen1 = new GeneradorPinBasico();
var gestorBoveda = new GestorBoveda(gen1);
gestorBoveda.ProtegerArchivo("archivo.txt");

Console.WriteLine("---------------");

IGeneradorClaves gen2 = new GeneradorTokenBiometricoInterf();//Cambie de nombres nose algo hibo de conflicto de nombres con otro archivo 
var gestorBoveda1 = new GestorBoveda(gen2);
gestorBoveda1.ProtegerArchivo("fotos.zip");
*/