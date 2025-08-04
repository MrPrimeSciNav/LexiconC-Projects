namespace _19_Konstruktor
{
    // Egendefinierad klass som jag kommer åt från andra klasserrrr
    public class Time
    {
        // Lokala variabler i klassen
        private int Year;
        private int Month;
        private int Day;
        private int Hour;
        private int Minute;
        private int Second;

        public void DisplayCurrentTime()
        {

            Console.WriteLine($"{Year:0000}-{Month:00}-{Day:00}  {Hour:00}:{Minute:00}:{Second:00}");

        }

        // Konstruktor som skapar ett objekt av klassen Time
        public Time(System.DateTime dt)
        {
            Year = dt.Year;
            Month = dt.Month;
            Day = dt.Day;
            Hour = dt.Hour;
            Minute = dt.Minute;
            Second = dt.Second;
        }
    }

    internal class Tester
    {
        static void Main(string[] args)
        {
            // Variabel av typen System.DateTime värdet av aktuellt datum och tid
            System.DateTime CurrentDateTime = System.DateTime.Now;

            // Deklarera en variabel av klassen Time
            // Instansiera en variabel med värdet från variabeln CurrentDateTime
            Time t = new Time(CurrentDateTime);

            // Anropa metoden DisplayCurrentTime med hjälp av variabeln t
            t.DisplayCurrentTime();
        }
    }
}