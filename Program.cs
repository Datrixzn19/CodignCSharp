using excLogistica.POO;


Bascula basc = new Bascula();


try
{
    //basc.ProcesaPaquete(50);
    basc.ProcesaPaquete(49.9);
    basc.ProcesaPaquete(0);
}
catch (PesoInvalidoException ex)
{
    
    Console.WriteLine($"ERROR {ex.Message}");
}
catch(SobrepesoException ex)
{
    Console.WriteLine($"ERROR {ex.Message}");
}