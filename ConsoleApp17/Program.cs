namespace _17_SalaryTax
{
    internal class SalaryTax
    {


        static void Main(string[] args)
        {
            // Let the user add the salary to base the neat salary and tax upon
            Console.WriteLine("Ange bruttolön i hela kronor: ");
            string stringSalary = Console.ReadLine();
            double.TryParse(stringSalary, out double doubleSalary);



            // Call the method SalaryCalc() to get the results from theh computations
            double neatSalary = SalaryCalc(doubleSalary);

            // Calculatingthe tax
            double tax = doubleSalary - neatSalary;

            // Print out the results to the user
            Console.WriteLine($"Nettolönen för en bruttolön om {doubleSalary} kr är {neatSalary} kr,\n" +
                              $"och skatten är {tax} kr");

            Console.WriteLine();
        }

        static double SalaryCalc(double doubleSalary)
        {
            // declaring constants
            int taxLevel1 = 48000, taxLevel2 = 38000;

            // Declaring variables            
            double salaryTax1, salaryTax2, salaryTax3, neatSalary;

            // Checking the salary and calculating the neat salary and tax
            if (doubleSalary > taxLevel1)
            {
                salaryTax1 = (double)((doubleSalary - taxLevel1) * 0.05);
                salaryTax2 = (double)((doubleSalary - taxLevel2) * 0.2);
                salaryTax3 = (double)(doubleSalary * 0.31);
                neatSalary = doubleSalary - (salaryTax1 + salaryTax2 + salaryTax3);

            }
            if (doubleSalary > taxLevel2)
            {
                salaryTax2 = (double)((doubleSalary - taxLevel2) * 0.2);
                salaryTax3 = (double)(doubleSalary * 0.31);
                neatSalary = doubleSalary - (salaryTax2 + salaryTax3);
                return neatSalary;

            }
            else
            {
                neatSalary = doubleSalary * (1 - 0.31);

            }
            return neatSalary;
        }
    }
}