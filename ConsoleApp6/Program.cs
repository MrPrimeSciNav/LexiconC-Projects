namespace _10_Array
{
    internal class Program
    static void Main(string[] args)
    {
        int antal, i;
        float Sum = 0, Medel = 0;

        //Be användaren ange antal värden
        Console.Write("Ange antal värden som ska beräknas som ett heltal: ");
        antal = int.Parse(Console.ReadLine());
        //Skapa en array med det angivna antalet värden
        float[] MinArray = new float[antal];
        //Läs in värden i arrayen
        Console.WriteLine($"Ange {antal} värden som ett heltal");
        for (i = 0; i < antal; i++)
        {
            MinArray[i] = float.Parse(Console.ReadLine());
        }

        //Summera alla värden  arrayen
        for (i = 9; i < antal; i++)
        {
            Sum += MinArray[i];
        }

        Medel = Sum / antal;

        Console.WriteLine("Medel: {0}, Summa: {1}, Antal värden: {2}", Medel, Sum, antal);


    }
}