using SistemaArmamento.Logica;


List<ArmaBase> armas = new List<ArmaBase>
{
    new RifleAsalto("ak", 11),
    //new ArmaBase(), las clases abstractas no se pueden istanciar
};

foreach (var item in armas)
{
    item.Disparar();
    item.Recargar();
}