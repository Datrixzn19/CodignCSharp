namespace Constructor.POO;


public class Computadora
{
    //Propiedades - campos 
    //estas se llaman propiedades auto-implementadas
    public string? Marca{get; set;}
    public string? Modelo{get; set;}
    public decimal Precio{get; set;}


    //Constructor (mismo nombre de la clase)
    public Computadora(string ma, string mo, decimal pr) //marca, modelo, precio
    //this hace referencia a las propiedades, se usa para no confundir
    {
        this.Marca = ma;
        this.Modelo = mo;
        this.Precio = pr;
    }


}

/*
using System.Runtime.CompilerServices;
using Constructor.POO;

Console.WriteLine("TU COMPUTADORA");
Console.WriteLine("Introduce el nombre de la marca: ");
string compu = Console.ReadLine();

Console.WriteLine("Introduce el modelo: ");
string model = Console.ReadLine();

Console.WriteLine("Introduce el precio: ");
decimal prec = 0; //precio por defecto
decimal.TryParse(Console.ReadLine(), out prec);

Computadora micompu = new Computadora(compu, model, prec);
Console.WriteLine("resumen");
Console.WriteLine(micompu.Marca);
Console.WriteLine(micompu.Modelo);
Console.WriteLine(micompu.Precio);

*/