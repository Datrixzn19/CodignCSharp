/*
Si se depende de una implementacion o una clase concreta con new, el codigo es rigido,si mas adelante queremos cambiar algo hay que modificar el codigo interno de la clase, lo que puede llegar a romper otras cosas
Pero si mejor se depende de una interfaz el código es flexible, la clase principal trabaja con un "contrato" y no le importa quién ni cómo lo ejecuta.

*/


/*
Vas a estructurar el motor de asignación de contraseñas para una aplicación de bóveda de notas seguras. El objetivo es que el gestor de la bóveda pueda usar cualquier algoritmo de generación de claves sin modificar su propio código interno.

Requerimientos:

La Interfaz (IGeneradorClaves):
Define un método que retorne un string llamado Generar().

Las Implementaciones:
Clase GeneradorPinBasico: Implementa la interfaz. Su método Generar() debe retornar simplemente "1234".

Clase GeneradorTokenBiometrico: Implementa la interfaz. Su método Generar() debe retornar un texto simulado como "Token_Huella_X98P".

La Clase Principal Desacoplada (GestorBoveda):
Crea una variable privada y de solo lectura del tipo de la interfaz.

Crea un constructor que reciba la interfaz y asigne el valor a la variable privada (esto es la inyección de la dependencia).

Crea un método void ProtegerArchivo(string nombreArchivo). Este método debe usar la variable privada para llamar a Generar() y luego imprimir: "[BioVault] El archivo '{nombreArchivo}' fue asegurado con la credencial: {credencialGenerada}".
*/


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

