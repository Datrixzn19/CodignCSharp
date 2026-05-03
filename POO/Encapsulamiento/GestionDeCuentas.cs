
namespace gestorCuentas.POO;
public class CuentaBancaria
{
    public string? Titular{get; init;}//titular de la cuenta, una vez creado no se modifica

    private decimal _saldo;
    public decimal Saldo
    {
        get => _saldo;
        set
        {
            if(value<0)//value es lo que ingresa el user
            {
                _saldo = 0;
                Console.WriteLine("Cantidad no permitida, se ha asigando el valor de cero");
            }
            else
            {
                Console.WriteLine($"Se ha agregado el valor {value:C2} con exito");
                _saldo = value;
            }
        }
    }


    //Propiedades calculadas
    public bool EsCuentaPremium => _saldo>5000; //si se cumple es true

    public decimal LimiteRetiro => _saldo * 0.10m;


    public CuentaBancaria(string titular, decimal saldo)
    {
        this.Saldo = saldo;
        this.Titular = titular;
    }
}

/*
using gestorCuentas.POO;


var misaldo = new CuentaBancaria("sr 1", 5001);
Console.WriteLine($"es premiun? {misaldo.EsCuentaPremium}");
Console.WriteLine($"titular {misaldo.Titular}");
Console.WriteLine($"saldo {misaldo.Saldo}");
Console.WriteLine("==============");

var misaldo2 = new CuentaBancaria("sr 2", -1);
Console.WriteLine($"es premiun? {misaldo2.EsCuentaPremium}");
Console.WriteLine($"titular {misaldo2.Titular}");
Console.WriteLine($"saldo {misaldo2.Saldo}");
Console.WriteLine("==============");


var misaldo3 = new CuentaBancaria("sr 3", 5000);
Console.WriteLine($"es premiun? {misaldo3.EsCuentaPremium}");
Console.WriteLine($"titular {misaldo3.Titular}");
Console.WriteLine($"saldo {misaldo3.Saldo}");
Console.WriteLine("==============");
*/