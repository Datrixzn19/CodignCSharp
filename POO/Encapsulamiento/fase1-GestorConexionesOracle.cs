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
    public GestorConexiones(string host) : this(host, 1521){} // esto es innecesario? ya hago la validacion en Puerto (pd: ya vi que si esto lo quito y no paso puerto el programa no corre asi que masomenos veo para que puede servir)


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
El Reto: Gestor de Conexiones Oracle
Debes crear una clase llamada ConexionOracle que simule la configuración para conectarse a una base de datos. Este ejercicio evalúa los 4 pilares de la Fase 1.

Requerimientos de la Clase:
Propiedades (Encapsulamiento y Validación):

Host: Debe ser una propiedad de inicialización obligatoria (init), representando la dirección del servidor (ej. "192.168.1.10").

Puerto: Usa un campo de respaldo (_puerto). En el bloque set, valida que el número esté entre 1 y 65535. Si el usuario ingresa un valor fuera de ese rango, asígnale el puerto por defecto de Oracle: 1521.

CadenaConexion: Propiedad calculada (solo lectura con =>) que devuelva un string uniendo los datos, por ejemplo: "Data Source=//[Host]:[Puerto];".




Constructores (Obligatoriedad y Encadenamiento):

Crea un constructor principal que reciba host y puerto. Asegúrate de asignar los parámetros a las Propiedades para que la validación del puerto se ejecute.

Crea un segundo constructor que reciba solo el host. Utiliza this(...) para encadenarlo al constructor principal, enviándole el host y el puerto por defecto 1521.

Sobrecarga de Métodos:

Crea un método llamado Conectar() que no reciba parámetros. Debe imprimir en consola: "Intentando conexión a: [CadenaConexion]".

Crea una sobrecarga del método Conectar(int timeout). Debe imprimir: "Intentando conexión a: [CadenaConexion] con tiempo de espera de [timeout] segundos".
*/