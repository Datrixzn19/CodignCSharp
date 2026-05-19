/*
private readonly IGeneradorClaves _generador;
    ```
    La razón es pura legibilidad: si tu clase tiene 200 líneas de código y llamas a `_generador.Generar()`, inmediatamente sabes qué está haciendo esa línea sin tener que subir a buscar la declaración de la variable.

### Reto: Motor de Sincronización

Para dominar la inyección de dependencias, vas a estructurar el sistema que sube las copias de seguridad de BioVault. Queremos que la aplicación pueda hacer el respaldo tanto en la base de datos local del teléfono como en la nube, sin modificar la lógica principal de respaldo.

**Requerimientos:**

1.  **El Contrato (`ISincronizador`):**
    *   Define un método `void Sincronizar(string datos)`.

2.  **Las Implementaciones:**
    *   Clase `SincronizadorSQLite`: Implementa la interfaz. Su método debe imprimir: `"[Local] Guardando '{datos}' en la base de datos SQLite."`.
    *   Clase `SincronizadorDrive`: Implementa la interfaz. Su método debe imprimir: `"[Nube] Conectando a Google Drive... Subiendo '{datos}'."`.

3.  **La Clase Principal (`MotorRespaldo`):**
    *   Crea una variable privada y de solo lectura para el contrato (ej. `_sincronizador`).
    *   Crea el constructor para inyectar la dependencia.
    *   Crea un método `void EjecutarCopiaSeguridad(string datosBoveda)`. Este método debe usar la dependencia inyectada para llamar a `Sincronizar(datosBoveda)`.

4.  **El Ejecutor (`Program.cs`):**
    *   Instancia el sincronizador de SQLite y pásalo a un nuevo `MotorRespaldo`. Ejecuta la copia con el texto `"Notas_Cifradas_V1"`.
    *   Instancia el sincronizador de Drive y pásalo a un *nuevo* `MotorRespaldo`. Ejecuta la copia con el texto `"Notas_Cifradas_V1"`.

Escribe la estructura aplicando las convenciones de nombres.
*/