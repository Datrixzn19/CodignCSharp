
/*
¡Me parece excelente que quieras afianzarlo con otro ejercicio antes de avanzar! La memoria muscular es clave en la programación.

Vamos a subir un poquito el nivel. En este ejercicio vas a crear dos excepciones personalizadas distintas para un mismo sistema y vas a atrapar ambas.

Reto: La Báscula de Envíos 📦
Imagina que estás programando el sistema de una empresa de paquetería. La báscula automática debe rechazar paquetes si pesan cero o menos (es un error de lectura), y también debe rechazarlos si superan el peso máximo permitido (50 kg) por políticas de la empresa.

Requerimientos:

1. Archivo ExcepcionesEnvio.cs

Crea el namespace Logistica.POO;

Crea una clase llamada PesoInvalidoException que herede de Exception (para cuando el peso sea 0 o negativo).

Crea otra clase llamada SobrepesoException que herede de Exception (para cuando el peso sea mayor a 50).

(Recuerda ponerles su constructor que reciba el mensaje y use : base(mensaje)).

2. Archivo Bascula.cs

Usa el mismo namespace Logistica.POO;

Crea la clase Bascula.

Crea un método public void ProcesarPaquete(double peso).

Dentro del método:

Si el peso <= 0, lanza PesoInvalidoException con el mensaje: "Error de lectura: El peso no puede ser cero o negativo."

Si el peso > 50, lanza SobrepesoException con el mensaje: "Paquete rechazado: El límite máximo es de 50 kg."

Si todo está bien, imprime en consola: "Paquete de {peso} kg procesado correctamente para su envío."

3. Archivo Program.cs

Pon tu using Logistica.POO;

Instancia tu Bascula.

Abre tu bloque try e intenta procesar un paquete que rompa la regla (por ejemplo, pásale -5 o 60).

Abre un bloque catch para atrapar PesoInvalidoException y muestra su mensaje.

Abre otro bloque catch debajo del anterior para atrapar SobrepesoException y muestra su mensaje.

Escribe tu código y envíamelo para revisar cómo manejas las múltiples caídas.
*/