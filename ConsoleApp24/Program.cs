namespace _24_StarShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Count = 0;
            int Number = 0;

            // Be användaren ange antal rader
            Console.Write("Ange antal rader\n");
            Number = int.Parse(Console.ReadLine());

            Count = Number - 1;

            // Yttre loop som refererar till rader i konsollen
            // Den övre halvan av stjärnan skrivs
            for (int k = 1; k <= Number; k++)
            {
                // Skriv blanktecken så länge villkoret i loopen är uppfyllt
                for (int i = 1; i <= Count; i++)
                {
                    Console.Write(" ");
                }

                Count--; // Minska antalet blanktecken med 1 för varje rad

                for (int i = 1; i <= 2 * k - 1; i++)
                {
                    Console.Write("*"); // Skriv stjärnor
                }

                Console.WriteLine(); // Gå till nästa rad
            }

            Count = 1;

            // Skriv ut den nedre halvan av stjärnan
            for (int k = 1; k <= Number - 1; k++)
            {
                // Skriv blanktecken så länge villkoret i loopen är uppfyllt
                for (int i = 1; i <= Count; i++)
                {
                    Console.Write(" ");
                }

                Count++; // Öka antalet blanktecken med 1 för varje rad

                for (int i = 1; i <= 2 * (Number - k) - 1; i++)
                {
                    Console.Write("*"); // Skriv stjärnor
                }

                Console.WriteLine(); // Gå till nästa rad
            }
        }
    }
}