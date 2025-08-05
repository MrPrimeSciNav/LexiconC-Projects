namespace _25_SumAVG
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            // Declare variables
            double[] numberArr = new double[5];
            int Sum = 0;
            int Count = 0;
            double SumAVG = 0;

            // Let the user add 5 real numbers to compute sum and average
            Console.WriteLine("Type in 5 real numbers to compute the sum and average: ");

            // Loop to read 5 real numbers from the user
            for (int i = 0; i < 5; i++)
            {
                // Prompt the user to enter a real number
                Console.Write("Type in a real number: ");
                numberArr[i] = double.Parse(Console.ReadLine());
            }

            // Call of the ComputeSumAndAverage
            ComputeSumAndAverage(numberArr);


        }

        // Call of the method ComputeSumAndAverage
        private static void ComputeSumAndAverage(double[] numberArr)
        {
            double sum = 0;

            // Looping through numberArr to calculate the sum
            for (int i = 0; i < numberArr.Length; i++)
            {
                sum += numberArr[i];
            }

            // Computing the average of the 5 real numbers in numberArr
            double avg = sum / numberArr.Length;

            // Printing out the rounded results
            Console.WriteLine($"The sum of the numbers is: {Math.Round(sum, 2)}");
            Console.WriteLine($"The average of the numbers is: {Math.Round(avg, 2)}");
        }
    }
}