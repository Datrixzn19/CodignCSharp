// PROGRAM.CS
using GuardarNotas.Logica;


//<IGuardadorNotas>, le decimos al compilador: Esta lista SOLO aceptará objetos instanciados de clases que hayan implementado esta interfaz
List<IGuardadorNotas> listaGuardadores = new List<IGuardadorNotas>
{
    // Podemos mezclar diferentes clases dentro de la misma lista, 
    // porque ambas cumplen con la regla de ser 'IGuardadorNotas'.
    new GuardadorLocal(),
    new GuardadorNube()
};

foreach (var guardador in listaGuardadores)
{
    // Al llamar al método, el programa no sabe si es la versión Local o Nube,
    // solo confía en el contrato. El polimorfismo se encarga de ejecutar 
    // la versión correcta según el objeto que esté en memoria en ese momento.
    guardador.GuardarNota("BioVault_Draft", "Estructurando la base de datos para las notas seguras.");
}