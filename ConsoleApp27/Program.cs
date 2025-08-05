namespace __27_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in valfritt antal heltal (tom rad för att avsluta):");

            CountOnes(ReadNumbers());
        }

        // Method to read numbers from the user's input
        static int[] ReadNumbers()
        {
            List<int> numbers = new List<int>();
            string input;

            while ((input = Console.ReadLine()) != null && input != "")
            {
                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Ogiltigt tal, försök igen.");
                }
            }

            return numbers.ToArray();
        }

        // Method that calculates the number of "1" digits in the sequence
        static void CountOnes(int[] numbers)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                count += number.ToString().Count(c => c == '1');
            }
            Console.WriteLine($"Antal '1': {count}");
        }
    }
}