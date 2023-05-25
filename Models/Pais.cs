public class pais
{
   public string Nombre {get; private set;}
   public string imgBandera {get; private set;}
   public int Poblacion {get; private set;}
   public DateOnly FechaIndependencia{get; private set;}
   public string AtractivosTuristicos {get; private set;}

   public pais()
   {

   }
   public pais(string nom, string iB, int pobl, DateOnly fI, string aT)
   {
        Nombre = nom;
        imgBandera = iB;
        Poblacion = pobl;
        FechaIndependencia = fI;
        AtractivosTuristicos = aT;
   }
}