
namespace ExportacionDocumentos.Logica;
//Clase original
public class Documento
{
    public string? Titulo{get; init;}
    public Documento(string titulo)
    {
        this.Titulo = titulo;
    }
    public virtual void Exportar()//virtual permite que las hijas hereden 
    {
        Console.WriteLine($"[TXT] Exportando documento básico: {Titulo}");
    }

}



public class DocumentoExcel : Documento
{
    public DocumentoExcel(string titulo) :
    base(titulo){}

    public override void Exportar()
    {
        Console.WriteLine($"[XLSX] Generando celdas y fórmulas para: {Titulo}");
    }

}


public sealed class DocumentoConfidencialPDF : Documento
{
    public DocumentoConfidencialPDF(string titulo) : base(titulo){}

    public  override void Exportar()
    {
        Console.WriteLine($"[PDF] Encriptando con contraseña el documento: {Titulo}");
    }
}


/*
using ExportacionDocumentos.Logica;

List<Documento> docs = new List<Documento>
{
    new Documento("DocumentoOficial"),
    new DocumentoExcel("DocumentoOficial2"),
    new DocumentoConfidencialPDF("DocumentoOficial3"),


};


foreach (var item in docs)
{
    item.Exportar();
}
*/