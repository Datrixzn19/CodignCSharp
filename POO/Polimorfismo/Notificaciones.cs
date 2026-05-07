/*
El Reto: Sistema de Notificaciones Polimórfico: Vas a crear un sistema que envíe alertas a los usuarios de distintas formas, usando la misma orden de ejecución pero comportamientos diferentes (virtual, override y sealed).

Requerimientos:
1. Clase Base: NotificadorBase
Propiedad: Destinatario (tipo string, de solo lectura al inicializar con init).
Constructor: Debe recibir y asignar el destinatario.
Método: Crea un método public virtual void Enviar(string mensaje). Debe imprimir en consola: "[Sistema] Mensaje estándar para {Destinatario}: {mensaje}".

2. Clase Hija 1: NotificadorEmail
Hereda de NotificadorBase.
Constructor: Exige el destinatario y se lo envía al constructor base.
Método: Sobrescribe (override) el método Enviar. Debe imprimir: "[Email] Conectando al puerto 587. Enviando a {Destinatario}: {mensaje}".

3. Clase Hija 2: NotificadorPush
Hereda de NotificadorBase.
Constructor: Exige el destinatario y se lo envía al constructor base.
Método: Sobrescribe el método Enviar y séllalo (sealed) para que ninguna futura clase que herede de NotificadorPush pueda cambiar la forma en que se envían los mensajes Push. Debe imprimir: "[FCM Push] Despertando dispositivo de {Destinatario}. Payload: {mensaje}".
*/

//override: indica que vas a sobreescribir un metodo. el padre o metodo que estes modificando debe tener virtual
//virtual: da permiso para que las hijas sobreescriban
//sealed: indica que ya no puedes sobreescribir las que herenden, puede ser usado en una clase o metodo 
//sealed en un método solo se puede usar en combinación con la palabra override. No puedes crear un método nuevo y hacerlo sealed directamente, porque por defecto, si no le pones virtual, un método ya está bloqueado (no se puede sobreescribir).

public class NotificadorBase
{
    public string? Destinatario{get; init;}
    public NotificadorBase(string destinatario)
    {
        this.Destinatario = destinatario;
    }


    public virtual void Enviar(string mensaje)//virtual da permiso para modificar
    {
        Console.WriteLine($"[Sistema] Mensaje estándar para {Destinatario}: {mensaje}");
    }
}
//Clase Hija 1
public class NotificadorEmail : NotificadorBase
{
    public NotificadorEmail(string destinatario)
    : base(destinatario){}

    public override void Enviar(string mensaje)//override es que vas a sobreescribir, se necesita que en el padre poner virtual para permitir sobreescritura
    {
        Console.WriteLine($"[Email] Conectando al puerto 587. Enviando a {Destinatario}: {mensaje}");
    }
}


//Clase Hija 2
public class NotificadorPush : NotificadorBase
{
    public NotificadorPush(string destinatario)
    : base(destinatario){}
    public sealed override void Enviar(string mensaje)//override pq estamos modificando y sealed pra decir que ninguna clase que herede de esta va a poder tocar
    {
        Console.WriteLine($"[FCM Push] Despertando dispositivo de {Destinatario}. Payload: {mensaje}");
    }


}