namespace ColeccionJuegos.Logica;

public enum Categorias
{
    Accion, 
    RPG, 
    Deportes
}
public class Videojuego
{
    public string Titulo{get; set;}
    public int AnioLanzamiento{get; set;}
    public Categorias Categoria{get; set;}
}

/*

using ColeccionJuegos.Logica;

List<Videojuego> listaVideojuego = new List<Videojuego>();

int vueltas = 1;
int juegosAgregar = 1;//por defecto dejara ingresar un juego 
try
{
    Console.WriteLine("Escribe cuantos juegos quieres agregar: ");
    juegosAgregar = int.Parse(Console.ReadLine());//intentamos asignar el numero de juegos
}
catch (FormatException)
{
    Console.WriteLine("No has introducido un numero, solo podras ingresar un solo juego");
}



do
{
    Console.WriteLine("\n INTRODUCE TU VIDEOJUEGO");

    var videojuego = new Videojuego();//instaciamos la clase 
    Console.WriteLine($"\n Vuelta N{vueltas}");

            //NOMBRE
    Console.WriteLine("Nombre: ");
    videojuego.Titulo = Console.ReadLine();


            //ANIO
    int aniolanVideojuego = 0;

    Console.WriteLine("Introduce el anio de lanzamiento: ");
    if (int.TryParse(Console.ReadLine(), out aniolanVideojuego) && aniolanVideojuego>0)
    {
        Console.WriteLine(aniolanVideojuego);
    }
    else
    {
        Console.WriteLine("Anio no valido, se asinara el anio 2026");
        aniolanVideojuego = 2026;
    }
    videojuego.AnioLanzamiento = aniolanVideojuego;




            ///CATEGORIA 
        int categoriaVideojuego = 100;
        Console.WriteLine("Elije la categorira: 0-Accion, 1-RPG, 2-Deportes");
        if (int.TryParse(Console.ReadLine(), out categoriaVideojuego) && categoriaVideojuego > 0 && categoriaVideojuego <= 2)
        {
            videojuego.Categoria = (Categorias)categoriaVideojuego;
        }
        else
        {
            Console.WriteLine("Opcion no valida, se asignara la opcion 0-Accion");
            videojuego.Categoria = Categorias.Accion;
        }
        




        //ASIGNACION 
    listaVideojuego.Add(videojuego);
    vueltas++;
} while (vueltas <= juegosAgregar);








//RESULTADOS 
Console.WriteLine("\n RESUMEN");
foreach (var lv in listaVideojuego)
{
    Console.WriteLine($"nombre: {lv.Titulo}, lanzado el: {lv.AnioLanzamiento}, categoria: {lv.Categoria}");
}


//USO DE LINQ
var catAccion = listaVideojuego.
    Where(j => j.Categoria == Categorias.Accion
    ).ToList();
foreach (var p in catAccion)
{
    Console.WriteLine($"Juego de accion: {p.Titulo}");
}

var contar = listaVideojuego.Count(j => j.Categoria == Categorias.Deportes);
Console.WriteLine($"Hubo {contar} juegos de deportes");


*/