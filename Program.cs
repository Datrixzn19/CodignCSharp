using System;
using System.Collections.Generic;
using System.Linq;

    


// BASE DE DATOS SIMULADA

List<VideojuegoLinq> catalogo = new List<VideojuegoLinq>
{
    new VideojuegoLinq { Titulo = "Zelda: Breath of the Wild", Anio = 2017, Calificacion = 9.8, EsMultijugador = false },
    new VideojuegoLinq { Titulo = "Minecraft", Anio = 2011, Calificacion = 9.5, EsMultijugador = true },
    new VideojuegoLinq { Titulo = "Cyberpunk 2077", Anio = 2020, Calificacion = 7.5, EsMultijugador = false },
    new VideojuegoLinq { Titulo = "Mario Kart 8", Anio = 2014, Calificacion = 8.9, EsMultijugador = true },
    new VideojuegoLinq { Titulo = "Tetris", Anio = 1984, Calificacion = 9.0, EsMultijugador = false }
};


//RETOS LINQ
//Seleccionar elementos 
Console.WriteLine("\n Trear solo nombres con Select");
List<string> seleccionar = catalogo.Select(p => p.Titulo).ToList();
Console.WriteLine(string.Join(", ", seleccionar)); // imprime todos los elementnos eparados por comas, se usa join o sino un foreach



// Guardar en una lista los juegos con Calificacion MAYOR a 8.5
Console.WriteLine("\n Traer mejores calificaciones con Where");
List<VideojuegoLinq> mayorCalificaciones = catalogo.Where(p => p.Calificacion > 8.5).ToList();
foreach (var item in mayorCalificaciones)
{
    Console.WriteLine($"{item.Titulo} - {item.Calificacion}");
}



// Ordenar los juegos por 'Anio' (del más viejo al más nuevo)
Console.WriteLine("\n Ordenar resultados de busqueda con OrderBy");
List<VideojuegoLinq> ordenadosPorAnio = catalogo.OrderByDescending(p => p.Anio).ToList(); //para hacer al revez se usa OrderByDescending
foreach (var item in ordenadosPorAnio)
{
    Console.WriteLine($"{item.Titulo} - {item.Anio}");
}



// Buscar el juego que se llame exactamente "Minecraft"
//FoDft no devuelve una lista, devuele lo que encontró o null, por eso el tipo de dato es la clase
Console.WriteLine("\nBuscar primer elemento con FirstOrDefault");
VideojuegoLinq? primerEncontrado = catalogo.FirstOrDefault(p => p.Titulo=="Minecraft");
if (primerEncontrado != null)
{
    Console.WriteLine($"Si se encontró {primerEncontrado.Titulo}");
}
else
{
    Console.WriteLine("No existe ese elemento");
}



// Busqueda combinada, categoria y multijador
Console.WriteLine("\n Doble busqueda, select + where");
var dobleFiltro = catalogo.Where(p => p.EsMultijugador ==true)
.Select(p => p.Titulo);//no supe como hacerlo con el tipo objeto, no sabia donde va el tolist
foreach (var item in dobleFiltro)
{
    Console.WriteLine(item);
}


// Saber la cantidad exacta (int) de juegos multijugador.
Console.WriteLine("\n Contar juegos multijugador con Count");
var contar = catalogo.Count(p=> p.EsMultijugador==true);
Console.WriteLine($"La cantidad de juegos multiplayer es de {contar}");


// DECLARACIÓN DE CLASE

public class VideojuegoLinq
{
    public string Titulo { get; set; }
    public int Anio { get; set; }
    public double Calificacion { get; set; }
    public bool EsMultijugador { get; set; }
}


