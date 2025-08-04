namespace _19_Palindrom_1
{
    internal class Program
    {
        static void Main(string[] arrgs)
        {
            // Skapa 2 arrayer med datatypen string
            char[] Ord1 = new char[4];
            char[] Ord2 = new char[4];

            Console.WriteLine("Skriv ett ord, tryck enter mellan varje bokstav:");

            // Läs in ett ord, bokstav för bokstav i arrayen
            for (int i = 0; i < Ord1.Length; i++)
            {
                Ord1[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < Ord2.Length; i++)
            {
                Ord2[i] = Ord1[i];
            }

            Array.Reverse(Ord2);

            if (Ord1.SequenceEqual(Ord2))
            {
                Console.WriteLine("Ordet är ett palindrom.");
            }
            else
            {
                Console.WriteLine("Ordet är inte ett palindrom.");
            }
        }
    }
}