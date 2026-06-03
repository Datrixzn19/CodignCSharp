/*
1. Archivo ExcepcionesEnvio.cs
Crea el namespace Logistica.POO;
Crea una clase llamada PesoInvalidoException que herede de Exception (para cuando el peso sea 0 o negativo).
Crea otra clase llamada SobrepesoException que herede de Exception (para cuando el peso sea mayor a 50).
(Recuerda ponerles su constructor que reciba el mensaje y use : base(mensaje)).

*/

namespace excLogistica.POO;
public class PesoInvalidoException : Exception //Para cuando el peso sea 0 o negativo
{
    public PesoInvalidoException(string msj) : base(msj){}
}


public class SobrepesoException : Exception//Para cuando se exeda el peso permitido 
{
    public SobrepesoException(string msj) : base(msj){}
}