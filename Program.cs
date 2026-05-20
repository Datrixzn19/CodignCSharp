using SmartHome.POO;
IClimatizacion clima = new AireAcondicionado();
IIluminacion luces = new LucesLed();


var hogarInteligente = new HabitacionInteligente(clima, luces);
hogarInteligente.ActivarModoNoche();
