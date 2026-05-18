//archivo duplicado en /POO/ClasesAbstractas/


//Cuando usar interfaces
//cuando necesitamos heredar un comportamiento de dos entidades que no estan estrictamente relacionadas
//como un dron y un pajaro, no tienen mucho que ver pero ambas pueden volar
// ahi entraria IVolar
//ademas una clase puede heredar de otras interfaces

//Cuando usar Clases Abstractas
//cuando tenemos dos entidades que se relacionan mucho
// como AnimalBase va a heredar su comportamietno a un Perro, como respirar que ahi reusamos codigo, pero en hacerSonido seria un metodo abstracto para que perro implemente lo propio 

//una clase solo puede heredar de una sola clase

//ejemplo mezclando los dos, ejemplo de gemini 
namespace ConceptosPOO;

// 1. LA INTERFAZ (Habilidad / Contrato)
// Convención: Se nombran con "I" al inicio y suelen ser adjetivos o acciones.
public interface IExportablePdf
{
    // SINTAXIS: Solo la firma del método. Sin modificador de acceso y sin llaves.
    void ExportarPdf();
}

// 2. LA CLASE ABSTRACTA (Identidad / Plantilla)
public abstract class DocumentoBase
{
    public string Titulo { get; init; }

    public DocumentoBase(string titulo)
    {
        Titulo = titulo;
    }

    // Código compartido: Todas las hijas heredan esto gratis.
    public void ImprimirEncabezado()
    {
        Console.WriteLine($"--- DOCUMENTO: {Titulo} ---");
    }

    // Código obligado: Las hijas deben darle cuerpo a este método.
    public abstract void ProcesarContenido();
}

// 3. LA CLASE CONCRETA (Hija)
// SINTAXIS DE HERENCIA MÚLTIPLE (Simulada):
// Primero va obligatoriamente la Clase Padre (DocumentoBase).
// Luego, separadas por comas, van todas las interfaces que firme.
public class Factura : DocumentoBase, IExportablePdf
{
    public decimal Total { get; init; }

    // SINTAXIS ': base()': Envía el título al constructor de DocumentoBase.
    public Factura(string titulo, decimal total) : base(titulo)
    {
        Total = total;
    }

    // SINTAXIS 'override': Obligatorio para implementar el método de la clase abstracta.
    public override void ProcesarContenido()
    {
        Console.WriteLine($"Procesando cobro de: ${Total}");
    }

    // SINTAXIS DE INTERFAZ: Obligatorio poner 'public' y no usar 'override'.
    public void ExportarPdf()
    {
        Console.WriteLine($"Guardando '{Titulo}' como archivo .pdf encriptado.");
    }
}