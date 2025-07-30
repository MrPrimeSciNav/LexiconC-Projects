namespace _16_Array3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deklarera en array av typen int och ge den värden
            int[] MinArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Visa värdena i arrayen
            foreach (int Val in MinArr)
            {
                // Variabeln Val refererar till elementen i MinArr
                Console.Write("{0} ", Val);
            }

            // Vänd på innehållet i arrayen
            Array.Reverse(MinArr);

            Console.WriteLine();

            // Visa värdena i arrayen
            foreach (int Val in MinArr)
            {
                // Variabeln Val refererar till elementen i MinArr
                Console.Write("{0} ", Val);
            }
        }
    }
}