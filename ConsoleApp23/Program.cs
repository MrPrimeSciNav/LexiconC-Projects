namespace _23_Skottår
{
    internal class LeapYear
    {
        int TheYear;

        static void Main(string[] args)
        {
            //Skapa en ny instans av klassen LeapYear
            LeapYear Obj = new LeapYear();

            // Använd metoderna ReadData och Leap som tillhör klassen LeapYear
            Obj.ReadData();
            Obj.Leap();
        }

        public void ReadData()
        {
            Console.WriteLine("Ange år med fyra siffror:");
            TheYear = Convert.ToInt32(Console.ReadLine());
        }

        public void Leap()
        {
            if (TheYear % 4 == 0 && TheYear % 100 != 0 || TheYear % 400 == 0)
            {
                Console.WriteLine($"{TheYear} är ett skottår.");
            }
            else
            {
                Console.WriteLine($"{TheYear} är inte ett skottår.");
            }
        }
    }
}