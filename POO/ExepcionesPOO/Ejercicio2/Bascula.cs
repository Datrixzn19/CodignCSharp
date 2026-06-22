
namespace excLogistica.POO;

public class Bascula
{
    public void ProcesaPaquete(double peso)
    {
        if(peso <= 0)
        {
            throw new PesoInvalidoException("Error de lectura: el peso no puede ser cero o negativo");
        }
        else if(peso >= 50)
        {
            throw new SobrepesoException("Paquete rechazado: El límite máximo es de 50 kg");
        }
        else
        {
            Console.WriteLine($"Paquete de {peso} kg procesado correctamente para su envío.");
        }

    }
}


