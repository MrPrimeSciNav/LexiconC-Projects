namespace _14_BMICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, heightCM, bmi;

            Console.Write("Ange din vikt i kg: ");
            weight = double.Parse(Console.ReadLine());

            Console.Write("Ange din längd i centimeter: ");
            heightCM = double.Parse(Console.ReadLine());

            bmi = CalculateBMI(weight, heightCM);

            Console.WriteLine($"Ditt BMI är: {bmi:F2}");
        }

        static double CalculateBMI(double weight, double heightCM)
        {
            double heightM = 0;
            heightM = heightCM / 100; // Konvertera längd från cm till meter

            return weight / (heightM * heightM);
        }
    }

}