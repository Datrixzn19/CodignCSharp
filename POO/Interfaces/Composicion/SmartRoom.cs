/*
Reto: Habitación Inteligente (Smart Room)
Requerimientos:

Contrato 1 (IIluminacion):
Define un método void EncenderLuces();
Crea una clase LucesLed que implemente esta interfaz y al ejecutar el método imprima: "[Iluminación] Encendiendo paneles LED en tono cálido."

Contrato 2 (IClimatizacion):
Define un método void AjustarTemperatura(int grados);
Crea una clase AireAcondicionado que implemente esta interfaz y al ejecutar el método imprima: "[Clima] Ajustando el aire a {grados}°C."

La Clase Compuesta (HabitacionInteligente):
Debe tener dos variables privadas y de solo lectura (readonly), una para cada interfaz (ej. _iluminacion y _climatizacion).
Un constructor que exija ambas interfaces y las asigne a las variables.
Un método void ActivarModoNoche(). Este método debe usar tus dependencias inyectadas para:
Encender las luces.
Ajustar la temperatura a 22 grados.


*/