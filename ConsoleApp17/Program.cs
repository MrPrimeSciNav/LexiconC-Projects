namespace _17_SalaryTax
{
    internal class SalaryTax
    {


        static void Main(string[] args)
        {
            // Let the user add the salary to base the neat salary and tax upon
            Console.WriteLine("Ange bruttolön i hela kronor: ");
            string stringSalary = Console.ReadLine();
            int.TryParse(stringSalary, out int intSalary);



            // Call the method SalaryCalc() to get the results from theh computations
            double neatSalary = SalaryCalc(intSalary);


            // Print out the results to the user
            Console.WriteLine($"Nettolönen för en bruttolön om {intSalary} är {neatSalary} kr.");
            Console.WriteLine();
        }

        static double SalaryCalc(int intSalary)
        {
            // declaring constants
            int taxLevel1 = 48000, taxLevel2 = 38000;
            // Casting integer to double
            double doubleSalary = (double)intSalary;
            double salaryTax1, salaryTax2, salaryTax3, neatSalary;

            // Checking the salary and calculating the neat salary and tax
            if (doubleSalary > taxLevel1)
            {
                salaryTax1 = (double)((doubleSalary - taxLevel1) * 0.05);
                salaryTax2 = (double)((doubleSalary - taxLevel2) * 0.2);
                salaryTax3 = (double)(doubleSalary * 0.31);
                neatSalary = salaryTax1 + salaryTax2 + salaryTax3;

            }
            if (doubleSalary > taxLevel2)
            {
                salaryTax2 = (double)((doubleSalary - taxLevel2) * 0.2);
                salaryTax3 = (double)(doubleSalary * 0.31);
                neatSalary = (double)(salaryTax2 + salaryTax3);
                return neatSalary;

            }
            else
            {
                neatSalary = (double)doubleSalary * 0.31;

            }
            return neatSalary;
        }
    }
}