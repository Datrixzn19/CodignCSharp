public class Videojuego
{
    // 1. PROPIEDAD (El "molde" o campo de la clase)
    // Se escribe en PascalCase (Primera letra mayúscula).
    public string Titulo { get; set; }

    // 2. CONSTRUCTOR
    // El nombre del método debe ser EXACTAMENTE igual al de la clase.
    public Videojuego(string titulo) 
    {
        // 3. PARÁMETRO (El dato que entra de afuera)
        // Se escribe en camelCase (Primera letra minúscula) por convención.
        
        // 'this.Titulo' hace referencia a la PROPIEDAD (punto 1).
        // 'titulo' hace referencia al PARÁMETRO (punto 3).
        this.Titulo = titulo; 
    }
}