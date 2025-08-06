namespace _30_LivingCostFlat
{
    internal class Program
    {
        public static double[] livingCostArr = new double[4];

        // Main method
        static void Main(string[] args)
        {
            // Let the usertype in price for the flat, interest, amortization period,
            // and mortgage per month
            Console.WriteLine("Ange pris för lägenheten: ");
            livingCostArr[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Ange ränta: ");
            livingCostArr[1] = double.Parse(Console.ReadLine());

            Console.WriteLine("Ange amorteringstid i år: ");
            livingCostArr[2] = double.Parse(Console.ReadLine());

            Console.WriteLine("Ange månadsamortering: ");
            livingCostArr[3] = double.Parse(Console.ReadLine());

            // Call of the method LivingCostCalc
            LivingCostCalc(livingCostArr);

        }

        static void LivingCostCalc(double[] livingCostArr)
        {
            // Calculate the monthly cost of the flat
            double interest = livingCostArr[0] * (livingCostArr[1] / 100) / 12;
            double amortization = livingCostArr[0] / (livingCostArr[2] * 12);
            double totalMonthlyCost = interest + amortization + livingCostArr[3];

            // Print the result
            Console.WriteLine($"Månadskostnaden för lägenheten är: {totalMonthlyCost:F2} kr,\n" +
            $"givet att lägenhetspriset är: {livingCostArr[0]}, räntan är: {livingCostArr[1]},\n" +
            $"amorteringstiden är: {livingCostArr[2]} år, och månadsamorteringen är: {livingCostArr[3]} kr.");
            Console.WriteLine("Tryck på valfri tangent för att avsluta programmet.");
        }
    }
}