public static class info
{
    private static List<pais> ListaPaises = new List<pais>{};
    
    private static void IniciarLista()
    {
        pais unPais = new pais("Argentina","Argentina.jpg",4500000,new DateOnly(1816,7,9),"Cataratas");
        ListaPaises.Add(unPais);
        unPais = new pais("Brasil","Brasil.jpg",14500000,new DateOnly(1816,7,10),"Amazonas");
        ListaPaises.Add(unPais);
        unPais = new pais("Chile","Chile.jpg",2500000,new DateOnly(1816,7,11),"Chile");
        ListaPaises.Add(unPais);
        unPais = new pais("Uruguay","Uruguay.jpg",3000000,new DateOnly(1816,7,17),"Punta Del Este");
        ListaPaises.Add(unPais);
        unPais = new pais("Mexico","Mexico.jpg",1000000,new DateOnly(1816,4,12),"Guadalajara");
        ListaPaises.Add(unPais);
    }
    public static List<pais> ListarPaises()
    {
        if(ListaPaises.Count == 0)
        {
            IniciarLista();
        }
        return ListaPaises;
    }
    public static pais DetallePais(string Nombre)
    {
        pais devolver = new pais();
        foreach (pais item in ListaPaises)
        {
            if(item.Nombre == Nombre)
            {
                return item;
            }
        }
        return devolver;
    }
}