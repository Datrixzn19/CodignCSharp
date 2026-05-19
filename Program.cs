using MotorSincronizacion.POO;

ISincronizador sinc = new SincronizadorSQLite();
var sincronizador = new MotorRespaldo(sinc);
sincronizador.EjecutarCopiaSeguridad("Notas_Cifradas_V1");

ISincronizador sinc1 = new SincronizadorDrive();
var sincronizador1 = new MotorRespaldo(sinc1);
sincronizador1.EjecutarCopiaSeguridad("Notas_Cifradas_V1");