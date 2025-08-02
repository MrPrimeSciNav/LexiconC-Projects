namespace _15_StarTravel
{
    internal class _15_StarTravel
    {
        internal class StarTravel
        {

            static void Main(string[] args)
            {
                // Declaration of variables
                string starName, starDistance, travelSpeed;

                double travelTime = 0;

                // Reads the name of the star the user want to compute the travel distance to
                Console.WriteLine("Ange namn på den stjärna du vill beräkna restid till: ");
                starName = Console.ReadLine();

                // Reads the distance to the star in lightyears
                Console.WriteLine("Ange avstånd till stjärnan i ljusår: ");
                starDistance = Console.ReadLine();
                double.TryParse(starDistance, out double starDistanceDouble);

                // Reads the travelspeed in km/h
                Console.WriteLine("Ange reshastighet i km/h: ");
                travelSpeed = Console.ReadLine();
                double.TryParse(travelSpeed, out double travelSpeedDouble);

                // Call of the method StarTravelTime to compute the traveltime to the given star
                travelTime = StarTravelTime(starDistanceDouble, travelSpeedDouble);

                Console.WriteLine($"The traveltime is {Math.Round(travelTime)} years.");
                Console.WriteLine();
            }

            public static double StarTravelTime(double starDistanceDouble, double travelSpeedDouble)
            {

                // Declaring constants
                int lightSpeed = 300000;

                double travelTime = 0;

                if (travelSpeedDouble > 0)
                {
                    // Computing the traveltime in years
                    travelTime = starDistanceDouble * lightSpeed * 60 * 60 / travelSpeedDouble;
                }
                else
                {
                    // Traveltime is infinite
                    Console.WriteLine("The traveltime is infinite!");
                }

                return travelTime;
            }
        }
    }

}