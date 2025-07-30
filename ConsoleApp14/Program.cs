namespace _17_MatrisOchKlasser
{
    internal class StartKlass
    {
        // Deklarera en variabel av typen (Klasses) Random
        static Random Rnd = new Random();

        static void Main(string[] args)
        {
            // Be användaren ange antal rader och kolumner i arrayen
            Console.Write("Ange antal rader som ett heltal: ");
            int Rad = int.Parse(Console.ReadLine());

            Console.Write("Ange antal kolumner som ett heltal: ");
            int Kolumn = int.Parse(Console.ReadLine());

            // Variabel som håller reda på antal genererade slumptal
            int AntalTal = 0;

            // Deklarera och instantisera en tvådimensionell array (Matris)
            int[,] TalMatris = new int[Rad, Kolumn];

            // Läs in värden i matrisen och fyll den med värden mellan 1 och 20
            for (int i = 0; i < Rad; i++)
            {
                for (int j = 0; j < Kolumn; j++)
                {
                    // Generera ett slumptal mellan 1 och 20
                    TalMatris[i, j] = Rnd.Next(1, 21);

                    // Öka räknaren för antal genererade slumptal
                    AntalTal++;
                }
            }

            // Anropa den statiska metoden CalcAntal direkt via klassen Calculata
            int AntalHits = Calculate.CalcAntal(TalMatris, Rad, Kolumn);
            // Skriv ut resultatet
            Console.WriteLine($"Antal värden i matrisen: {AntalTal} Antal värden större än 10: {AntalHits} ({Math.Round((double)AntalHits / AntalTal * 100)}%)");

        }

        #region

        public class Calculate
        {
            // En metod som har 3 indatapositioner och som ska returnera ett heltal
            public static int CalcAntal(int[,] IndataMatris, int Row, int Col)
            {
                // Variabel som räknar antal värden större än 10
                int AntalV = 0;
                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < Col; j++)
                    {
                        // Kolla om värdet på aktuell indexposition är större än 10
                        if (IndataMatris[i, j] > 10)
                        {
                            AntalV++;
                        }
                    }
                }
                return AntalV;
            }

        }
        #endregion

    }
}