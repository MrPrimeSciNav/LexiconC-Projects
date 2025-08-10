// Under development

using System.IO;
using System.Xml.Linq;

namespace _31_FitnessBudget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char userContinue = 'y';

            // Call the method to present the application
            PresentApplication();

            while (userContinue == 'y' || userContinue == 'Y')
            {


                // Ask the user if they want to continue
                Console.WriteLine("Vill du fortsätta? (y/n)");



                // Let the user type in an option
                userContinue = char.Parse(Console.ReadLine());
                Console.WriteLine(); // For better readability
                                     // Check the user's choice


                switch (userContinue)
                {
                    case 'y':
                    case 'Y':
                        // Continue with the application
                        break;
                    case 'n':
                    case 'N':
                        // Exit the application
                        Console.WriteLine("Tack för att du använde Fitness Budget Applikationen!");
                        return;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        continue;
                }

                PresentApplication();

                // If the user want, let the user define grosery, amount and price per unit
                PresentOptions();

                // If the user want, let the user define different types of meals and sizes

                // If the user want. let the user define what grosery are available
            }
            // End of the application
        }

        static void PresentApplication()
        {
            // Present the application for the user
            Console.WriteLine("Välkommen till Fitness Budget Applikationen!");
            Console.WriteLine("Denna applikation hjälper dig att hålla koll på dina kostnader för fitness och hälsa.");
        }

        static void PresentOptions()
        {
            // Give the user numeric multi-option display of which options they have
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Definiera livsmedel och kostnader");
            Console.WriteLine("2. Definiera måltider och storlekar");
            Console.WriteLine("3. Definiera tillgängliga livsmedel");
            Console.WriteLine("4. Definiera budget");
            Console.WriteLine("5. Definiera slutdatum för optimering");
            Console.WriteLine("6. Avsluta applikationen");

            // Ask the user if they want to continue
            Console.WriteLine("Vad vill du göra? (Ange det numeriska värdet för ditt val)");

            // Let the user type in an option
            char option = char.Parse(Console.ReadLine());
            Console.WriteLine(); // For better readability

            switch (option)
            {
                case '1':
                    // Call the method to define grosery
                    DefineGrosery();
                    break;
                case '2':
                    // Call the method to define meals and sizes
                    DefineMealsAndSizes();
                    break;
                case '3':
                    // Call the method to define available grosery
                    DefineAvailableGrosery();
                    break;
                case '4':
                    // Call the method to define budget
                    DefineBudget();
                    break;
                case '5':
                    // Call the method to define end date for optimization
                    DefineEndDateForOptimization();
                    break;
                case '6':
                    // Exit the application
                    Console.WriteLine("Tack för att du använde Fitness Budget Applikationen!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }

        }

        // Method to define grosery and store data in an XML-file       

        static void DefineGrosery()
        {
            string xmlPath = Path.Combine(Directory.GetCurrentDirectory(), "FitnessBudget.xml");
            char userContinue = 'y';

            // Create or load XML document
            XDocument doc;
            if (!File.Exists(xmlPath))
            {
                doc = new XDocument(
                    new XDeclaration("1.0", "utf-8", null),
                    new XElement("groceries")
                );
            }
            else
            {
                doc = XDocument.Load(xmlPath);
            }

            while (userContinue == 'y' || userContinue == 'Y')
            {
                // Get user input
                Console.WriteLine("Ange livsmedel (grosery): ");
                string grosery = Console.ReadLine()?.Trim() ?? "";
                if (string.IsNullOrEmpty(grosery))
                {
                    Console.WriteLine("Ogiltigt livsmedelsnamn, försök igen.");
                    continue;
                }

                // Check if grocery already exists
                var existingGrocery = doc.Root?.Elements("item")
                    .FirstOrDefault(x => x.Element("grocery")?.Value.Equals(grosery, StringComparison.OrdinalIgnoreCase) == true);

                if (existingGrocery != null)
                {
                    var nutrition = existingGrocery.Element("nutrition");
                    Console.WriteLine($"Befintliga värden för {grosery}:");
                    Console.WriteLine($"Mängd: {existingGrocery.Element("amount")?.Value}");
                    Console.WriteLine($"Pris per enhet: {existingGrocery.Element("pricePerUnit")?.Value}");
                    Console.WriteLine($"kCal per 100g: {nutrition?.Element("kcal")?.Value}");
                    Console.WriteLine($"Fett per 100g: {nutrition?.Element("fat")?.Value}");
                    Console.WriteLine($"Kolhydrater per 100g: {nutrition?.Element("carbs")?.Value}");
                    Console.WriteLine($"Protein per 100g: {nutrition?.Element("protein")?.Value}");

                    Console.WriteLine("Vill du uppdatera värdena? (y/n)");
                    if (char.Parse(Console.ReadLine()?.ToLower() ?? "n") != 'y')
                    {
                        continue;
                    }
                    existingGrocery.Remove();
                }

                Console.WriteLine("Ange mängd (amount): ");
                string amountStr = Console.ReadLine()?.Trim() ?? "";
                if (!double.TryParse(amountStr, out double amount))
                {
                    Console.WriteLine("Ogiltig mängd, försök igen.");
                    continue;
                }

                Console.WriteLine("Ange pris per enhet (pricePerUnit): ");
                string priceStr = Console.ReadLine()?.Trim() ?? "";
                if (!double.TryParse(priceStr, out double pricePerUnit))
                {
                    Console.WriteLine("Ogiltigt pris, försök igen.");
                    continue;
                }

                // Add nutritional values input
                Console.WriteLine("Ange kCal per 100g: ");
                string kCalStr = Console.ReadLine()?.Trim() ?? "";
                if (!double.TryParse(kCalStr, out double kCal))
                {
                    Console.WriteLine("Ogiltigt kCal-värde, försök igen.");
                    continue;
                }

                Console.WriteLine("Ange fett (g) per 100g: ");
                string fatStr = Console.ReadLine()?.Trim() ?? "";
                if (!double.TryParse(fatStr, out double fat))
                {
                    Console.WriteLine("Ogiltigt fettvärde, försök igen.");
                    continue;
                }

                Console.WriteLine("Ange kolhydrater (g) per 100g: ");
                string carbsStr = Console.ReadLine()?.Trim() ?? "";
                if (!double.TryParse(carbsStr, out double carbs))
                {
                    Console.WriteLine("Ogiltigt kolhydratvärde, försök igen.");
                    continue;
                }

                Console.WriteLine("Ange protein (g) per 100g: ");
                string proteinStr = Console.ReadLine()?.Trim() ?? "";
                if (!double.TryParse(proteinStr, out double protein))
                {
                    Console.WriteLine("Ogiltigt proteinvärde, försök igen.");
                    continue;
                }

                // Modify the XML element creation to include nutrition data
                var newItem = new XElement("item",
                    new XElement("grocery", grosery),
                    new XElement("amount", amount),
                    new XElement("pricePerUnit", pricePerUnit),
                    new XElement("nutrition",
                        new XElement("kcal", kCal),
                        new XElement("fat", fat),
                        new XElement("carbs", carbs),
                        new XElement("protein", protein)
                    )
                );

                doc.Root?.Add(newItem);

                // Save document
                try
                {
                    doc.Save(xmlPath);
                    Console.WriteLine($"Data har sparats i {xmlPath}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ett fel uppstod vid skrivning till filen: {ex.Message}");
                    return;
                }

                Console.WriteLine("Vill du lägga till ytterligare livsmedel? (y/n)");
                userContinue = char.Parse(Console.ReadLine()?.ToLower() ?? "n");
            }

            Console.WriteLine("Avslutar definiering av livsmedel.");
        }

        static void DefineMealsAndSizes()
        {
            char userContinue = 'y';

            while (userContinue == 'y' || userContinue == 'Y')
            {
                // Let the user define grosery, amount and price per unit
                Console.WriteLine("Ange livsmedel (grosery): ");
                string grosery = Console.ReadLine();
                Console.WriteLine("Ange mängd (amount): ");
                double amount = double.Parse(Console.ReadLine());
                Console.WriteLine("Ange pris per enhet (pricePerUnit): ");
                double pricePerUnit = double.Parse(Console.ReadLine());
                Console.WriteLine($"Du har angett: {grosery}, {amount} enheter, till priset av {pricePerUnit} per enhet.");

                // Store the data in an XML-file to be able to retrieve it later
                // Tags are "<grosery>", "<amount>", and "<pricePerUnit>"
                // Write data to the file FitnessBudget.xml
                try
                {
                    using (StreamWriter writer = new StreamWriter("FitnessBudget.xml", true))
                    {
                        writer.WriteLine($"<grosery>{grosery}</grosery>");
                        writer.WriteLine($"<amount>{amount}</amount>");
                        writer.WriteLine($"<pricePerUnit>{pricePerUnit}</pricePerUnit>");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ett fel uppstod vid skrivning till filen: {ex.Message}");
                    return;
                }

                Console.WriteLine("Data har sparats i FitnessBudget.xml.");

                // Check if the user wants to continue
                Console.WriteLine("Vill du lägga till ytterligare livsmedel? (y/n)");
                userContinue = char.Parse(Console.ReadLine());

                // If the user wants to continue, call the method again
                if (userContinue == 'y' || userContinue == 'Y')
                {
                    //DefineGrosery(grosery, amount, pricePerUnit);
                    DefineGrosery();
                }
                else if (userContinue == 'n' || userContinue == 'N')
                {
                    Console.WriteLine("Livsmedelsdata är uppdaterat!");
                    return;
                }

            }

            Console.WriteLine("Avslutar definiering av livsmedel.");
        }

        static void DefineAvailableGrosery()
        {
            char userContinue = 'y';

            while (userContinue == 'y' || userContinue == 'Y')
            {
                // Let the user define grosery, amount and price per unit
                Console.WriteLine("Ange livsmedel (grosery): ");
                string grosery = Console.ReadLine();
                Console.WriteLine("Ange mängd (amount): ");
                double amount = double.Parse(Console.ReadLine());
                Console.WriteLine("Ange pris per enhet (pricePerUnit): ");
                double pricePerUnit = double.Parse(Console.ReadLine());
                Console.WriteLine($"Du har angett: {grosery}, {amount} enheter, till priset av {pricePerUnit} per enhet.");

                // Store the data in an XML-file to be able to retrieve it later
                // Tags are "<grosery>", "<amount>", and "<pricePerUnit>"
                // Write data to the file FitnessBudget.xml
                try
                {
                    using (StreamWriter writer = new StreamWriter("FitnessBudget.xml", true))
                    {
                        writer.WriteLine($"<grosery>{grosery}</grosery>");
                        writer.WriteLine($"<amount>{amount}</amount>");
                        writer.WriteLine($"<pricePerUnit>{pricePerUnit}</pricePerUnit>");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ett fel uppstod vid skrivning till filen: {ex.Message}");
                    return;
                }

                Console.WriteLine("Data har sparats i FitnessBudget.xml.");

                // Check if the user wants to continue
                Console.WriteLine("Vill du lägga till ytterligare livsmedel? (y/n)");
                userContinue = char.Parse(Console.ReadLine());

                // If the user wants to continue, call the method again
                if (userContinue == 'y' || userContinue == 'Y')
                {
                    //DefineGrosery(grosery, amount, pricePerUnit);
                    DefineGrosery();
                }
                else if (userContinue == 'n' || userContinue == 'N')
                {
                    Console.WriteLine("Livsmedelsdata är uppdaterat!");
                    return;
                }

            }

            Console.WriteLine("Avslutar definiering av livsmedel.");
        }

        static void DefineBudget()
        {
            char userContinue = 'y';

            while (userContinue == 'y' || userContinue == 'Y')
            {
                // Let the user define grosery, amount and price per unit
                Console.WriteLine("Ange livsmedel (grosery): ");
                string grosery = Console.ReadLine();
                Console.WriteLine("Ange mängd (amount): ");
                double amount = double.Parse(Console.ReadLine());
                Console.WriteLine("Ange pris per enhet (pricePerUnit): ");
                double pricePerUnit = double.Parse(Console.ReadLine());
                Console.WriteLine($"Du har angett: {grosery}, {amount} enheter, till priset av {pricePerUnit} per enhet.");

                // Store the data in an XML-file to be able to retrieve it later
                // Tags are "<grosery>", "<amount>", and "<pricePerUnit>"
                // Write data to the file FitnessBudget.xml
                try
                {
                    using (StreamWriter writer = new StreamWriter("FitnessBudget.xml", true))
                    {
                        writer.WriteLine($"<grosery>{grosery}</grosery>");
                        writer.WriteLine($"<amount>{amount}</amount>");
                        writer.WriteLine($"<pricePerUnit>{pricePerUnit}</pricePerUnit>");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ett fel uppstod vid skrivning till filen: {ex.Message}");
                    return;
                }

                Console.WriteLine("Data har sparats i FitnessBudget.xml.");

                // Check if the user wants to continue
                Console.WriteLine("Vill du lägga till ytterligare livsmedel? (y/n)");
                userContinue = char.Parse(Console.ReadLine());

                // If the user wants to continue, call the method again
                if (userContinue == 'y' || userContinue == 'Y')
                {
                    //DefineGrosery(grosery, amount, pricePerUnit);
                    DefineGrosery();
                }
                else if (userContinue == 'n' || userContinue == 'N')
                {
                    Console.WriteLine("Livsmedelsdata är uppdaterat!");
                    return;
                }

            }

            Console.WriteLine("Avslutar definiering av livsmedel.");
        }

        static void DefineEndDateForOptimization()
        {
            char userContinue = 'y';

            while (userContinue == 'y' || userContinue == 'Y')
            {
                // Let the user define grosery, amount and price per unit
                Console.WriteLine("Ange livsmedel (grosery): ");
                string grosery = Console.ReadLine();
                Console.WriteLine("Ange mängd (amount): ");
                double amount = double.Parse(Console.ReadLine());
                Console.WriteLine("Ange pris per enhet (pricePerUnit): ");
                double pricePerUnit = double.Parse(Console.ReadLine());
                Console.WriteLine($"Du har angett: {grosery}, {amount} enheter, till priset av {pricePerUnit} per enhet.");

                // Store the data in an XML-file to be able to retrieve it later
                // Tags are "<grosery>", "<amount>", and "<pricePerUnit>"
                // Write data to the file FitnessBudget.xml
                try
                {
                    using (StreamWriter writer = new StreamWriter("FitnessBudget.xml", true))
                    {
                        writer.WriteLine($"<grosery>{grosery}</grosery>");
                        writer.WriteLine($"<amount>{amount}</amount>");
                        writer.WriteLine($"<pricePerUnit>{pricePerUnit}</pricePerUnit>");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ett fel uppstod vid skrivning till filen: {ex.Message}");
                    return;
                }

                Console.WriteLine("Data har sparats i FitnessBudget.xml.");

                // Check if the user wants to continue
                Console.WriteLine("Vill du lägga till ytterligare livsmedel? (y/n)");
                userContinue = char.Parse(Console.ReadLine());

                // If the user wants to continue, call the method again
                if (userContinue == 'y' || userContinue == 'Y')
                {
                    //DefineGrosery(grosery, amount, pricePerUnit);
                    DefineGrosery();
                }
                else if (userContinue == 'n' || userContinue == 'N')
                {
                    Console.WriteLine("Livsmedelsdata är uppdaterat!");
                    return;
                }

            }

            Console.WriteLine("Avslutar definiering av livsmedel.");
        }
    }
}
