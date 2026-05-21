using Genericos.POO;


Caja<string> caja1 = new Caja<string>("mensaje de string");


Caja<bool> caja2 = new Caja<bool>(true);


Caja<int> caja3 = new Caja<int>(99);

caja1.MostrarContenido();
caja2.MostrarContenido();
caja3.MostrarContenido();
