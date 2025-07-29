namespace _11_Slumptal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Här är 10 slumptal mellan 1 och 10");

            for (int i = 1; 1 <= 10; i++)
            {
                RandMetod();
            }
            Console.WriteLine();

        }

        //Initiera en variabel av klassen Random
        static Random slumpTal = new Random();

        static void RandMetod()
        {
            int Tal = slumpTal.Next(1, 11); // Slumptal mellan 1 och 10
            Console.Write($"{Tal,3}"); // Skriv ut slumptalet med 3 teckenbredd
        }

    }
}