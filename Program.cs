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


// Guardar en una lista los juegos con Calificacion MAYOR a 8.5

List<VideojuegoLinq> mayorCalificaciones = catalogo.Where(p => p.Calificacion > 8.5).ToList();
Console.WriteLine("Mejores calificaciones de videojuegos");
foreach (var item in mayorCalificaciones)
{
    Console.WriteLine($"{item.Titulo} {item.Calificacion}");
}














// Reto 2: Usa .OrderBy() para ordenar los juegos por 'Anio' (del más viejo al más nuevo)
// Escribe tu código aquí...

// Reto 3: Usa .FirstOrDefault() para buscar el juego que se llame exactamente "Minecraft"
// Escribe tu código aquí...

// Reto 4 (Combinado): Usa .Where() para buscar los juegos multijugador y luego .Select() para extraer solo sus Títulos.
// Escribe tu código aquí...

// Reto 5 (Bonus): Adivina o busca cómo usar el método .Count() para saber la cantidad exacta (int) de juegos multijugador.
// Escribe tu código aquí...



// DECLARACIÓN DE CLASE

public class VideojuegoLinq
{
    public string Titulo { get; set; }
    public int Anio { get; set; }
    public double Calificacion { get; set; }
    public bool EsMultijugador { get; set; }
}


