using envoltorioDeResultados.POO;

ResultadoOperacion<int> resultado1 = new ResultadoOperacion<int>(true, "Usuario encontrado", 1050);
resultado1.MostrarResumen();
ResultadoOperacion<string> resultado2 = new ResultadoOperacion<string>(true, "Token Generado", "ABC-123-XYZ");
resultado2.MostrarResumen();