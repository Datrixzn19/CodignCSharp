
namespace DiccionarioDeObjetos.Logica;

public class Materias
{
    public string? Nombre{get; set;}
    public int Anio{get; set;}
    public string? Profesor{get; set;}
}
/*
using DiccionarioDeObjetos.Logica;



Dictionary<string, Materias> diccionario = new Dictionary<string, Materias>();

var materias = new Materias();
materias.Nombre = "Mates";
materias.Anio = 2020;
materias.Profesor = "Jimenez"; 


diccionario.Add(materias.Nombre, materias);


foreach (var par in diccionario)
{
    Console.WriteLine($"llave {par.Key} el profesor es {par.Value.Anio}");
}


*/


// otra forma de imprimir 
/*
La forma "Moderna" (Deconstrucción)
A partir de versiones recientes de C#, puedes "desarmar" el par directamente en el foreach. Es la forma más limpia y parecida a como se hace en lenguajes como Python.

C#
foreach (var (nombre, juego) in coleccion)
{
    // 'nombre' ya es el string, 'juego' ya es el objeto
    Console.WriteLine($"{nombre} es un juego de {juego.Categoria}");
}
*/