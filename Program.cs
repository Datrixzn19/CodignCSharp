 using GestorConexionesOracle.POO;


var Gestor = new GestorConexiones("192.168.0.0.1", 223);
Gestor.Conectar();
Gestor.Conectar(22);
Console.WriteLine("==========================");

GestorConexiones Gestor1 = new GestorConexiones("192.168.192.0.1");
Gestor1.Conectar();
Gestor1.Conectar(11);