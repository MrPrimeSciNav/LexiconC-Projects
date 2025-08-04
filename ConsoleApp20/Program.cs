namespace _20_Palindrom2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Be användaren att skriva ett ord
            Console.WriteLine("Skriv ett ord: ");
            string Ordet = Console.ReadLine();

            // Skapa en array av datatypen char och tilldela arrayen tecknen från variabeel
            char[] OrdArray1 = Ordet.ToCharArray();

            // Kolla antal tecken i variabeln Ordet
            int OrdLength = Ordet.Length;

            // Deklarera en ny array av typen char
            char[] OrdArray2;
            OrdArray2 = new char[OrdLength];

            // Läs in tecken baklänges till OrdArray2
            int j = 0;
            for (int i = OrdArray1.Length - 1; i >= 0; i--)
            {
                OrdArray2[j] = OrdArray1[i];
                j++;
            }

            Console.WriteLine();

            // Kolla om arrayerna är lika tecken för tecken
            int Koll = 0;
            int Antal;
            for (Antal = 0; Antal < OrdArray2.Length; Antal++)
            {
                if (OrdArray1[Antal] != OrdArray2[Antal])
                {
                    Koll++;
                }
            }

            Console.WriteLine();

            // Kolla om ordet är ett palindrom
            if (Koll > 0)
            {
                Console.WriteLine($"Angivet ord: {Ordet} består av {Antal} tecken, och är inte ett palindrom.");
            }
            else
            {
                Console.WriteLine($"Angivet ord: {Ordet} består av {Antal} tecken, och är ett palindrom.");
            }
        }
    }
}