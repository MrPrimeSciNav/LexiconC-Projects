namespace _15_Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Be användaren ange antal värden i en array
            Console.Write("Ange antal värden som ett heltal: ");
            int Antal = int.Parse(Console.ReadLine());

            // Deklarera en array av typen int
            int[] ValueArr = new int[Antal];

            // Läs in värden i arrayen
            for (int i = 0; i < Antal; i++)
            {
                Console.Write("Ange värde " + (i + 1) + ": ");
                ValueArr[i] = int.Parse(Console.ReadLine());

                // Kolla om värdet på aktuell indexposition är större än 10
                if (ValueArr[i] > 10)
                {
                    ValueArr[i] = ValueArr[i] * ValueArr[i];
                }
            }

            Console.WriteLine();

            for (int i = 0; i < Antal; i++)
            {
                // Skriv ut värdena i arrayen
                Console.WriteLine("Värde " + (i + 1) + ": " + ValueArr[i]);
            }
        }
    }
}