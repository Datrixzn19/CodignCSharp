namespace Genericos.POO;

//los genericos ayudan a reusar codigo, permiten guardar distintos tipos de datos partiendo de uuna sola case, quien instancia la clase es el que va a decidir que tipo de dato va a ser

//Se usa <> y se pone la letra T de type por convencion
public class Caja<T>
{
    public T Contenido{get; init;}//no sabemos el tipo de dato, entonces usamos T


    public Caja(T contenido)//usamos el dato generico de nuevo 
    {
        Contenido = contenido;
    }

    public void MostrarContenido()
    {
        Console.WriteLine($"El contenido es: {Contenido} ");
    }
}


/*
using Genericos.POO;


Caja<string> caja1 = new Caja<string>("mensaje de string");


Caja<bool> caja2 = new Caja<bool>(true);


Caja<int> caja3 = new Caja<int>(99);

caja1.MostrarContenido();
caja2.MostrarContenido();
caja3.MostrarContenido();

*/