namespace _28_BMI_Calculator
{
    internal class Program
    {
        public static double BMI = 0, bodyLengthM = 0;

        static void Main(string[] args)
        {
            // Let the user add length in cm and weight in kg
            Console.WriteLine("Ange kroppsvikt i kg: ");
            double bodyWeightDouble = double.Parse(Console.ReadLine());

            Console.WriteLine("Ange kroppslängd i cm: ");
            double bodyLengthDouble = double.Parse(Console.ReadLine());

            // Call of method to calculate the individuals BMI
            BMI = Math.Round(BMICalculator(bodyWeightDouble, bodyLengthDouble), 2);

            // Print out the result of BMI
            Console.WriteLine($"Vid en kroppsvikt på: {bodyWeightDouble} kg, och \n" +
                $"en kroppslängd på: {bodyLengthDouble} cm, blir BMI: {BMI}.");
        }

        static double BMICalculator(double bodyWeightDouble, double bodyLengthDouble)
        {
            // Converting the bodylength from cm to meters and computes BMI
            bodyLengthM = bodyLengthDouble / 100;

            BMI = bodyWeightDouble / (bodyLengthM * bodyLengthM);

            return BMI;
        }
    }
}