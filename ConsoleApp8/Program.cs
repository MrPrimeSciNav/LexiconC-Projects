namespace _12_ValutaOmräkning
{
    internal class Program
    {
        const double USD = 9.64;
        const double Euro = 11.16;
        const double GBP = 12.87;

        static void Main(string[] args)
        {
            char Svar = 'j';
            while (Svar == 'j')
            {
                Console.Write("Ange önskad valuta (USD, EUR, GBP)");
                string Valuta = Console.ReadLine();

                Console.Write("Ange belopp att omvandla i SEK: ");
                double Belopp = double.Parse(Console.ReadLine());

                double OmvandlatBelopp = Konvertera(Belopp, Valuta);

                if (OmvandlatBelopp > 0)
                {
                    Console.WriteLine($"Omvandlat belopp: {Math.Round(OmvandlatBelopp, 2)} {Valuta}");
                }
                else
                {
                    Console.WriteLine("Ogiltig inmatning, försök igen.");
                }

                Console.WriteLine("Vill du omvandla mer? (j/n)");
                Svar = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
        }

        private static double Konvertera(double inBelopp, string ValutaTyp)
        {
            double ValutaV;

            switch (ValutaTyp.ToUpper())
            {
                case "USD":
                    ValutaV = inBelopp / USD;
                    break;
                case "EUR":
                    ValutaV = inBelopp / Euro;
                    break;
                case "GBP":
                    ValutaV = inBelopp / GBP;
                    break;
                default:
                    Console.WriteLine("Ogiltig valuta, försök igen.");
                    return 0;
            }

            return ValutaV;

        }
    }

}