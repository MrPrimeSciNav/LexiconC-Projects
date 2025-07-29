namespace _13_InchToCm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variabel som används för att hantera feedback från användaren
            //och sätts till 'j' initialt
            char Svar = 'j';
            double TalInch = 0;
            double TalCM = 0;

            while (Svar == 'j')
            {
                Console.WriteLine("Ange ett värde i Inch: ");
                TalInch = double.Parse(Console.ReadLine());

                TalCM = InchToCm(TalInch);
                Console.WriteLine($"Värdet i cm är: {TalCM}");

            }

        }

        static double InchToCm(double Inch)
        {
            double cm = Inch * 2.54;
            return cm;
        }
    }
}