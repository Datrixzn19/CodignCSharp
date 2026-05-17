namespace procesamientoDePagos.POO;


public abstract class MetodoPago
{
    public string? Titular{get; init;}
    public decimal Monto{get; init;}
    //constructor
    public MetodoPago(string titular, decimal monto)
    {
        Titular = titular;
        Monto = monto;
    }
    public void GenerarRecibo()
    {
        Console.WriteLine($"[Recibo] Cobro de ${Monto} a nombre de {Titular}.");
    }
    public abstract void ProcesarTransaccion();
}
    //Clase hija 1

    public class PagoTarjeta : MetodoPago
{
    //constructor
    public PagoTarjeta(string titular, decimal monto) : base(titular, monto){}

    public override void ProcesarTransaccion()
    {
        Console.WriteLine("[Red Bancaria] Validando los 16 dígitos de la tarjeta... Pago aprobado.");
    }
}

    //Clase hija 1
    public class PagoPayPal : MetodoPago
{
    //constructor
    public PagoPayPal(string titular, decimal monto) : base(titular, monto){}
    public override void ProcesarTransaccion()
    {
        Console.WriteLine("[API PayPal] Redirigiendo al correo del usuario... Transferencia completada.");
    }
}


