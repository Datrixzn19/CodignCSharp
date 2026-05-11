namespace GestorConexionesOracle.POO;

public class GestorConexiones
{
    //Propiedad de inicializacion obligatoria
    public string? Host{get; init;} //si o si un necesitamos el host


    //asigancion de puerto 
    private int _puerto;
    public int Puerto
    {
        get => _puerto;
        set
        {
            if (value<1 || value>65535)
            {
                Console.WriteLine($"Puerto no valido, se ha asignado por defecto el puerto {1521}");
                _puerto = 1521;
            }
            else
            {
                Console.WriteLine($"Puerto {value} agregado con exito");
                _puerto = value; 
            }
        }
    }


    //Propiedad calculada
    public string CadenaConexion => $"Data Source=//[{Host}]:[{_puerto}];";
    //public string CadenaConexion => Console.WriteLine($"Data Source=//[{_host} ]:[{_puerto}]");

    //sobrecarga de constructores
    public GestorConexiones(string host, int puerto)
    {
        this.Host = host;
        this.Puerto = puerto;
    }
    public GestorConexiones(string host) : this(host, 1521){} 

    //sobrecarga de metodos
    public void Conectar()
    {
        Console.WriteLine($"intentando conectar a {CadenaConexion}");
    }
        public void Conectar(int timeout)
    {
        Console.WriteLine($"intentando conectar a {CadenaConexion} con tiempo {timeout}");
    }


}


/*
 using GestorConexionesOracle.POO;


var Gestor = new GestorConexiones("192.168.0.0.1", 223);
Gestor.Conectar();
Gestor.Conectar(22);
Console.WriteLine("==========================");

GestorConexiones Gestor1 = new GestorConexiones("192.168.192.0.1");
Gestor1.Conectar();
Gestor1.Conectar(11);
*/