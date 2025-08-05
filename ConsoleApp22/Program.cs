namespace _22_Felhantering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ValueArr = { null, "16724", "9453.89", "67,34", " -87 ", "+765", "(566)", "09A" };

            double number;
            foreach (var value in ValueArr)
            {
                bool success = double.TryParse(value, out number);
                if (success)
                {
                    Console.WriteLine($"Konvertering av: '{value}', till: {number}");
                }
                else
                {
                    Console.WriteLine($"Försöket att konvertera värdet: '{value ?? "<null>"}' misslyckades.");
                }
            }
        }
    }
}