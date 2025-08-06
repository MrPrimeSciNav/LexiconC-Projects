namespace _29_SocialSecurityNumberCheck
{
    internal class Program
    {
        public static string ssn;
        // Main method        
        static void Main(string[] args)
        {
            // Let the user type in a social security numper to check the parity digit
            Console.WriteLine("Ange personnummer (ÅÅÅÅMMDDXXXX): ");
            string input = Console.ReadLine();

            // Call of the method CheckParityDigit
            ssn = input;

            if (CheckParityDigit(ssn))
            {
                Console.WriteLine($"Personnumret: {ssn} är giltigt.");
            }
            else
            {
                Console.WriteLine($"Personnumret: {ssn} är ogiltigt.");
            }
        }

        // Method to check the parity digit of a Swedish social security number
        static bool CheckParityDigit(string ssn)
        {
            if (ssn.Length != 12 || !long.TryParse(ssn, out _))
                return false;

            string tenDigits = ssn.Substring(2, 10); // YYMMDDNNNC

            int sum = 0;
            for (int i = 0; i < tenDigits.Length - 1; i++)
            {
                int digit = int.Parse(tenDigits[i].ToString());
                if (i % 2 == 0)
                {
                    digit *= 2;
                    if (digit > 9) digit -= 9;
                }
                sum += digit;
            }

            int parityDigit = (10 - (sum % 10)) % 10;
            return parityDigit == int.Parse(tenDigits[9].ToString());
        }
    }
}