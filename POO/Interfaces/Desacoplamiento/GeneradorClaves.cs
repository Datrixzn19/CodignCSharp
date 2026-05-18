/*
Si se depende de una implementacion o una clase concreta con new, el codigo es rigido,si mas adelante queremos cambiar algo hay que modificar el codigo interno de la clase, lo que puede llegar a romper otras cosas
Pero si mejor se depende de una interfaz el código es flexible, la clase principal trabaja con un "contrato" y no le importa quién ni cómo lo ejecuta.

*/


/*
Vas a estructurar el motor de asignación de contraseñas para una aplicación de bóveda de notas seguras. El objetivo es que el gestor de la bóveda pueda usar cualquier algoritmo de generación de claves sin modificar su propio código interno.

Requerimientos:

La Interfaz (IGeneradorClaves):

Define un método que retorne un string llamado Generar().

Las Implementaciones:

Clase GeneradorPinBasico: Implementa la interfaz. Su método Generar() debe retornar simplemente "1234".

Clase GeneradorTokenBiometrico: Implementa la interfaz. Su método Generar() debe retornar un texto simulado como "Token_Huella_X98P".

La Clase Principal Desacoplada (GestorBoveda):

Crea una variable privada y de solo lectura del tipo de la interfaz.

Crea un constructor que reciba la interfaz y asigne el valor a la variable privada (esto es la inyección de la dependencia).

Crea un método void ProtegerArchivo(string nombreArchivo). Este método debe usar la variable privada para llamar a Generar() y luego imprimir: "[BioVault] El archivo '{nombreArchivo}' fue asegurado con la credencial: {credencialGenerada}".

El Ejecutor (Program.cs):

Crea una instancia de GeneradorPinBasico.

Crea una instancia de GestorBoveda, inyectándole por constructor el generador básico. Llama a ProtegerArchivo("ListaDeCompras.txt").

Crea una instancia de GeneradorTokenBiometrico.

Crea una nueva instancia de GestorBoveda, inyectándole por constructor el generador biométrico. Llama a ProtegerArchivo("FotosPrivadas.zip").

Escribe el código estructurando las piezas y haciendo la inyección en el punto de entrada.
*/