
public class Arma
{
    public string? Nombre{get; init;}
    private int _municion;
    protected int Municion{//protected solo la clase y la hija tienen acceso
        get => _municion;
        set
        {
            if(value<0)
            {
                Console.WriteLine("Cantidad de balas no valida, se han asignado solo 30 balas");
                _municion = 30;
            }
            else
            {
                _municion = value;
            }
        }
        }
    
    //constructor
    public Arma(string nombre, int municion)
    {
        this.Nombre = nombre;
        this.Municion = municion;
    }

    public void Disparar()
    {
        if (_municion<1)
        {
            Console.WriteLine($"Click! no hay balas en {Nombre}");
        }
        else
        {
            Console.WriteLine($"Disparando, hay {_municion} balas en {Nombre}");
            _municion--;
        }
    }
}


//HERENCIA
public class RifleFrancotirador : Arma
{
    public int AumentoMira{get; set;}//propiedad exclusiva de la clase hija
    //como el padre exige ciertos argumentos aca debemos pasarselos
    public RifleFrancotirador(string nombre, int municion, int aumentoMira ) 
    : base(nombre, municion)
    {
        this.AumentoMira = aumentoMira;//solo definimos la nueva
    }
    
    public void Apuntar()
    {
        Console.WriteLine($"Apuntando con el francotirador con mira X{AumentoMira}");
    }



}


/*

var arma = new Arma("ak47", 5);//clase padre



var sniper = new RifleFrancotirador("kar", 5, 15);//clase hija 

sniper.Disparar();
sniper.Disparar();
sniper.Disparar();
sniper.Disparar();
sniper.Disparar();
sniper.Disparar();
sniper.Disparar();
*/