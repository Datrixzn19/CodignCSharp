namespace controlarTemp.POO; 



public class Sensor
{
    //marca del sensor??
    public string? Marca{get; init; }//init dice que solo permite ponerle el valor una vez 


    //Temperatura

    //propiedad con logica de validacion 
    private decimal _temperatura; //campo privado para respaldar la logica
    public decimal Temperatura
    {
        get => _temperatura;
        set
        {
            if(value<-50 || value>100) //value es el dato que estamos ingresando
            {
                _temperatura = 0;
            }
            else
            {
                _temperatura = value;
            }
            Console.WriteLine($"la temperatura es de  {value}");

        }
    }
    // PROPIEDAD SOLO LECTURA (Calculada)
    // No tiene almacenamiento propio; se calcula al momento de consultarla.
    public bool AlertaActiva => _temperatura > 80; //true si es mas de 80


    //metodo constructor
    public Sensor(string marca, decimal temperaturaInicial)
    {
        this.Marca = marca;
        this.Temperatura = temperaturaInicial;
    }



}



/*
using controlarTemp.POO;
string marca = "Sensor nombre";
decimal temperatura = 81.00m;

var misensor = new Sensor(marca, temperatura);
Console.WriteLine(misensor.AlertaActiva);
Console.WriteLine(misensor.Marca);
Console.WriteLine(misensor.Temperatura);



Console.WriteLine("======================");
decimal temperatura1 = -10.00m;
string marca1 = "marca 1";
var misensor1 = new Sensor(marca1, temperatura1);
Console.WriteLine(misensor1.AlertaActiva);
Console.WriteLine(misensor1.Marca);
Console.WriteLine(misensor1.Temperatura);


Console.WriteLine("======================");
decimal temperatura2 = 80.00m;
string marca2 = "marca 2";
var misensor2 = new Sensor(marca2, temperatura2);
Console.WriteLine(misensor2.AlertaActiva);
Console.WriteLine(misensor2.Marca);
Console.WriteLine(misensor2.Temperatura);



Console.WriteLine("======================");
decimal temperatura3 = -51.00m;
string marca3 = "marca 3";
var misensor3 = new Sensor(marca3, temperatura3);
Console.WriteLine(misensor3.AlertaActiva);
Console.WriteLine(misensor3.Marca);
Console.WriteLine(misensor3.Temperatura);

*/