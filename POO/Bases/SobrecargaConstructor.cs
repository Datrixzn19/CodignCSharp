namespace SobrecargaConstructor.POO;


public class Computadora
{
    //Propiedades - campos 
    //estas se llaman propiedades auto-implementadas
    public string? Marca{get; set;}
    public string? Modelo{get; set;}
    public decimal Precio{get; set;}


    //Constructor (mismo nombre de la clase)
    public Computadora(string marca, string modelo, decimal precio) //marca, modelo, precio
    //this hace referencia a las propiedades, se usa para no confundir
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Precio = precio;
    }




    //SOBRECARGA 
    // El constructor de 2 parámetros llamarca al de 3 parámetros
    public Computadora(string nombre, string modelo) : this(nombre, modelo, 9.00m)
    {
        // Aquí no hace falta escribir nada, el trabajo ya lo hizo el otro constructor
    }
    

    public Computadora(string nombre) : this(nombre, "Vivobook15", 10.00m)
    {
    }


}

/*


using SobrecargaConstructor.POO;

//csharp llama al metodo contructor correspondiente dependiendo de cuantos argumentos le pasemos 
Computadora micompu = new Computadora("asus", "vivobook", 1223.44m); 
Computadora micompu2 = new Computadora("lenovo", "ideapad"); //aqui usa el metodo const. que tiene el precio predefinido
Computadora micompu3 = new Computadora("dell"); 

Console.WriteLine("Tres metodos pasados: ");
Console.WriteLine(micompu.Marca);
Console.WriteLine(micompu.Modelo);
Console.WriteLine(micompu.Precio);

Console.WriteLine("......");

Console.WriteLine("dos metodos pasados: ");
Console.WriteLine(micompu2.Marca);
Console.WriteLine(micompu2.Modelo);
Console.WriteLine(micompu2.Precio);

Console.WriteLine("......");

Console.WriteLine("un metodo pasado: ");
Console.WriteLine(micompu3.Marca);
Console.WriteLine(micompu3.Modelo);
Console.WriteLine(micompu3.Precio);
*/