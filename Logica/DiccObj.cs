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



/*
namespace DiccionarioDeObjetos.Logica;

public class Materias
{
    public string Nombre{get; set;}
    public int Anio{get; set;}
    public string Profesor{get; set;}
}
*/