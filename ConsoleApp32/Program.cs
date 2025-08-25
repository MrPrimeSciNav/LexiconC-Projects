namespace _32_Klasser_Metoder
{
    internal class Moderskepp
    {
        static void Main(string[] args)
        {
            // Användaren anger antal positioner i arrayen
            Console.WriteLine("Ange antal djur");
            int Ant = int.Parse(Console.ReadLine());

            // Deklarera och instansiera en array
            string[] DjurArray = new string[Ant];

            // Läs in olika djur i arrayen
            for (int i = 0; i < Ant; i++)
            {
                // Skriv namnet på ett djur
                Console.WriteLine("Skriv namnet på ett djur");
                DjurArray[i] = Console.ReadLine();
            }

            // Skapa ett nytt objekt av klassen Kollklass
            // Jag kommerrr åt innehållet i klassen Kollklass med hjälp av variabeln KlassObjekt
            Kollklass KlassObjekt = new Kollklass();

            // Anropa metoden Kolla i klassen med Kollklass med hjälp av variabeln KlassObjekt
            string Anrop = KlassObjekt.Kolla(DjurArray, Ant);

            // Visa resultatet
            Console.WriteLine("Resultat {0}", Anrop);

        }
    }

    public class Kollklass
    {
        public string Kolla(string[] DjurArray, int Antal)
        {
            string KollV = "Värdet hittades inte";

            for (int i = 0; i < Antal; i++)
            {
                if (DjurArray[i].ToLower() == "Katt")
                {
                    KollV = "Värdet hittades";
                }

            }
            return KollV;
        }
    }

}