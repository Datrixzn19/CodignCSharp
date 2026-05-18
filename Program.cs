/*
El Ejecutor (Program.cs):
Crea una instancia de GeneradorPinBasico.
Crea una instancia de GestorBoveda, inyectándole por constructor el generador básico. Llama a ProtegerArchivo("ListaDeCompras.txt").

Crea una instancia de GeneradorTokenBiometrico.
Crea una nueva instancia de GestorBoveda, inyectándole por constructor el generador biométrico. Llama a ProtegerArchivo("FotosPrivadas.zip").
Escribe el código estructurando las piezas y haciendo la inyección en el punto de entrada.
*/

using GeneradorClaves.POO;


IGeneradorClaves gen1 = new GeneradorPinBasico();
var gestorBoveda = new GestorBoveda(gen1);
gestorBoveda.ProtegerArchivo("archivo.txt");

Console.WriteLine("---------------");

IGeneradorClaves gen2 = new GeneradorTokenBiometricoInterf();//Cambie de nombres nose algo hibo de conflicto de nombres con otro archivo 
var gestorBoveda1 = new GestorBoveda(gen2);
gestorBoveda1.ProtegerArchivo("fotos.zip");