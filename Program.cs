// SINTAXIS: Creación de una colección tipada con la clase Padre.
// List<T> es una colección dinámica. Dentro de los diamantes < > indicamos 
// que esta lista SOLO aceptará objetos que sean 'NotificadorBase' o hereden de él.
List<NotificadorBase> canalesDeAviso = new List<NotificadorBase>
{
    // Instanciamos directamente dentro de las llaves de inicialización de la lista
    new NotificadorBase("AdminGeneral"),
    new NotificadorEmail("usuario@correo.com"),
    new NotificadorPush("Dispositivo_X89")
};

string alerta = "El servidor se reiniciará en 5 minutos.";

// Bucle foreach para iterar colecciones.
// 'var' deja que el compilador deduzca el tipo (NotificadorBase).
foreach (var canal in canalesDeAviso)
{
    // Ejecución polimórfica: C# decide en tiempo de ejecución 
    // cuál versión de Enviar() debe ejecutar según el objeto original.
    canal.Enviar(alerta);
}