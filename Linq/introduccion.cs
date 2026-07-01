namespace linq.intro;

public class Producto
{
    public string Nombre{ get; set; }
    public int Precio { get; set; } 
    public string Categoria { get; set; }



    List<Producto> inventario = new List<Producto>
{
    new Producto { Nombre = "Laptop", Precio = 1200, Categoria = "Electrónica" },
    new Producto { Nombre = "Ratón", Precio = 25, Categoria = "Electrónica" },
    new Producto { Nombre = "Escritorio", Precio = 300, Categoria = "Muebles" },
    new Producto { Nombre = "Silla", Precio = 150, Categoria = "Muebles" },
    new Producto { Nombre = "Teclado", Precio = 80, Categoria = "Electrónica" }
};


}



