namespace _16_CircumferenceCircle
{
    internal class CircumferenceCircle
    {
        
        static void Main(string[] args)
        {
            // Declaring variables
            double circumferenceCircle = 0;

            // Declaring constants
            const double Pi = 3.1415;

            // Reads in the radius of the circle
            Console.WriteLine("Ange radien på cirkeln som du vill beräkna omkretsen på: ");
                    string radiusString = Console.ReadLine();
            double radiusDouble = double.Parse(radiusString);

            // Calling the method CircCircle to compute the circumference of the circele
            circumferenceCircle = CircumferenceCirc(Pi, radiusDouble);
            Console.WriteLine($"Omkrets på en cirkel med angiven radie är: {circumferenceCircle}");
        }
        
        static double CircumferenceCirc(double Pi, double radius)
        {
            return (radius * Pi);
        }

    }
}