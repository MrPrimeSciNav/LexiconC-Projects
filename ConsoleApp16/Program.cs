namespace _16_CircumferenceCircle
{
    internal class CircumferenceCircle
    {

        static void Main(string[] args)
        {
            // Declaring variables
            double circumferenceCircle = 0.0;

            // Reads in the radius of the circle
            Console.WriteLine("Ange radien (cm) på cirkeln som du vill beräkna omkretsen på: ");
            string radiusString = Console.ReadLine();
            double radiusDouble = double.Parse(radiusString);

            // Calling the method CircCircle to compute the circumference of the circele
            circumferenceCircle = CircumferenceCirc(radiusDouble);
            Console.WriteLine($"Omkrets på en cirkel med angiven radie är: {Math.Round(circumferenceCircle, 2)} cm");
        }

        static double CircumferenceCirc(double radius)
        {
            return (2 * Math.PI * radius);
        }

    }
}