/*
En tu ejecutor (Program.cs):
Crea una lista tipada con la clase abstracta.
Agrega una instancia de PagoTarjeta (ej. "David", 150.50m) y una de PagoPayPal (ej. "Leonel", 25.00m). (Nota: En C#, el sufijo 'm' indica que el número es un tipo decimal).
Recorre la lista con un foreach. Por cada pago, llama a ProcesarTransaccion() y luego a GenerarRecibo().
*/

using procesamientoDePagos.POO;

List<MetodoPago> pagos = new List<MetodoPago>
{
    new PagoTarjeta("david tarjeta", 443.01m),
    new PagoPayPal("david paypal", 33.01m),
};


foreach(var p in pagos)
{
    p.ProcesarTransaccion();
    p.GenerarRecibo();
    Console.WriteLine("--------");
}