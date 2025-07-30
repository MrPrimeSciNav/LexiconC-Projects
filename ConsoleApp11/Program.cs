namespace _14_PracticeMultiplication
{
    internal class Program
    {
        static Random SlumpTal = new Random();

        static void Main(string[] args)
        {
            int Tal1, Tal2, CorrAnswer = 0, SvarInt, CountCorr = 0, CountTries = 0;
            string Svar;
            char val = 'j';

            while (val == 'j')
            {

                Console.WriteLine("Försök nummer " + CountTries);
                Console.WriteLine();

                if (val != 'j')
                {
                    break;
                }

                //Skapa två slumptal mellan 1 och 10
                Tal1 = SlumpTal.Next(1, 11);
                Tal2 = SlumpTal.Next(1, 11);

                //Rätt svar
                CorrAnswer = Tal1 * Tal2;

                Console.WriteLine("Vad är " + Tal1 + " * " + Tal2 + "?");
                Svar = Console.ReadLine();

                //Konvertera värdet i variabeln Svar till heltal
                int.TryParse(Svar, out SvarInt);

                //Kontrollera om svaret är korrekt
                if (SvarInt == CorrAnswer)
                {
                    Console.WriteLine("Rätt svar!");
                    CountCorr++;
                }
                else
                {
                    Console.WriteLine("Fel svar! Rätt svar är " + CorrAnswer);
                    if (SvarInt > CorrAnswer)
                    {
                        Console.WriteLine("Ditt svar var för högt.");
                    }
                    else
                    {
                        Console.WriteLine("Ditt svar var för lågt.");
                    }
                }

                CountTries++;
                double PercentCorr = CorrAnswer / CountTries;

                Console.WriteLine($"Antal rätt hittills: {CountCorr}, {PercentCorr} % korrekt)");
                Console.WriteLine("Vill du fortsätta? (j/n)");
                val = Console.ReadKey().KeyChar;
            }

        }
    }
}