// Under development

using System.IO;
using System.Xml.Linq;
using OdeInt;

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
            Console.WriteLine("5. Definiera behov av makronutrienter")
            Console.WriteLine("6. Definiera slutdatum för optimering");
            Console.WriteLine("7. Avsluta applikationen");

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
                    DefineNutritionalNeed();
                    break;
                case '6':
                    // Call the method to define end date for optimization
                    DefineEndDateForOptimization();
                    break;
                case '7':
                    // Exit the application
                    Console.WriteLine("Tack för att du använde Fitness Budget Applikationen!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }

        }

        public class Grocery
        {
            public string Name { get; set; }
            public double Amount { get; set; }
            public double PricePerUnit { get; set; }
            public double KCal { get; set; }
            public double Fat { get; set; }
            public double Carbs { get; set; }
            public double Protein { get; set; }

            // Method to define grosery and store data in an XML-file       

            public static void DefineGrosery()
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
        }

        public class Meal
        {
            public string Name { get; set; }
            public List<string> Groceries { get; set; }
            public string Size { get; set; }

            // Method to define meals
            public static void DefineMealsAndSizes()
            {
                char userContinue = 'y';

                while (userContinue == 'y' || userContinue == 'Y')
                {
                    // Let the user define a meal and it's included groceries
                    Console.WriteLine("Ange namn på måltid: ");
                    string mealName = Console.ReadLine();
                    Console.WriteLine("Ange ingående ingredienser (grocery): ");
                    while (string.IsNullOrEmpty(mealName))
                    {
                        Console.WriteLine("Måltidsnamn kan inte vara tomt, försök igen.");
                        mealName = Console.ReadLine();
                    }
                    // Let the user add multiple croceries to a meal in an array
                    else if (string.IsNullOrEmpty(grocery))
                    {
                        Console.WriteLine("Livsmedelsnamn kan inte vara tomt, försök igen.");
                        grocery = Console.ReadLine();
                    }
                    Console.WriteLine("Ange ingredienser (grocery) separerade med kommatecken: ");
                    string[] groceries = Console.ReadLine()?.Split(',') ?? new string[0];
                    for (int i = 0; i < groceries.Length; i++)
                    {
                        groceries[i] = groceries[i].Trim();
                    }
                    Console.WriteLine("Ange storlek på måltiden (t.ex. liten, medelstor, stor): ");
                    string mealSize = Console.ReadLine()?.Trim() ?? "";
                    while (string.IsNullOrEmpty(mealSize))
                    {
                        Console.WriteLine("Måltidsstorlek kan inte vara tom, försök igen.");
                        mealSize = Console.ReadLine();
                    }
                    Console.WriteLine($"Du har angett måltid: {mealName}, med ingredienser: {string.Join(", ", groceries)} och storlek: {mealSize}.");



                    // Store the data in an XML-file to be able to retrieve it later
                    // Tags are "<mealName>", "<groceries>", and "<mealSize>"
                    // Write data to the file FitnessBudget.xml
                    try
                    {
                        using (StreamWriter writer = new StreamWriter("FitnessBudget.xml", true))
                        {
                            writer.WriteLine($"<mealName>{mealName}</mealName>");
                            writer.WriteLine($"<groceries>{groceries}</groceries>");
                            writer.WriteLine($"<mealSize>{pricePmealSizeerUnit}</mealSize>");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ett fel uppstod vid skrivning till filen: {ex.Message}");
                        return;
                    }

                    Console.WriteLine("Måltid har sparats i FitnessBudget.xml.");

                    // Check if the user wants to continue
                    Console.WriteLine("Vill du lägga till ytterligare måltid? (y/n)");
                    userContinue = char.Parse(Console.ReadLine());

                    // If the user wants to continue, call the method again
                    if (userContinue == 'y' || userContinue == 'Y')
                    {
                        //Define meals and groceries and sizes
                        DefineMealsAndSizes();
                    }
                    else if (userContinue == 'n' || userContinue == 'N')
                    {
                        Console.WriteLine("Måltidsdata är uppdaterat!");
                        return;
                    }

                }

                Console.WriteLine("Avslutar definiering av måltider.");
            }
        }

        public class NutritionalNeed
        {
            public int KCal { get; set; }
            public int Carbohydrates { get; set; }
            public int Fat { get; set; }
            public int Protein { get; set; }

            // Defin the nutritional need
            public static < string, int> DefineNutritionalNeed();
                {
                    // Define the nutritional need in terms of kCal, Carbs, Fat and Protein
                    Console.WriteLine("Ange önskad mängd energi (kCal): ");
                    int kCal;
                    while (!int.TryParse(Console.ReadLine(), out kCal) || kCal <= 0)
                    {
                        Console.WriteLine("Ogiltig mängd energi, försök igen.");
                    }

        Console.WriteLine("Ange önskad mängd kolhydrater (g): ");
                    int carbohydrates;
                    while (!int.TryParse(Console.ReadLine(), out carbohydrates) || carbohydrates <= 0)
                    {
                        Console.WriteLine("Ogiltig mängd kolhydrater, försök igen.");
                    }

    Console.WriteLine("Ange önskad mängd fett (g): ");
                    int fat;
                    while (!int.TryParse(Console.ReadLine(), out fat) || fat <= 0)
                    {
                        Console.WriteLine("Ogiltig mängd fett, försök igen.");
                    }

Console.WriteLine("Ange önskad mängd protein (g): ");
int protein;
while (!int.TryParse(Console.ReadLine(), out protein) || protein <= 0)
{
    Console.WriteLine("Ogiltig mängd protein, försök igen.");
}

// Store the nutritional need of energy and macro nutrients in a dictionary
Dictionary<string, int> nutritionalNeed = new Dictionary<string, int>
                    {
                        { "kCal", kCal },
                        { "Carbohydrates", carbohydrates },
                        { "Fat", fat },
                        { "Protein", protein }
                    };

return nutritionalNeed; 

            }

        }


        
        

        static < string, int> DefineAvailableGrosery()sssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss
        {
            char userContinue = 'y';

while (userContinue == 'y' || userContinue == 'Y')
{
    // Let the user define grosery, amount and price per unit
    Console.WriteLine("Ange livsmedel som finns i lager (grosery): ");
    string groseryInStore = Console.ReadLine();
    Console.WriteLine("Ange mängd (amount): ");
    double amountInStore = double.Parse(Console.ReadLine());
    Console.WriteLine($"Du har angett: {groseryInStore}, {amountInStore} enheter.");

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
        Console.WriteLine("Livsmedelslager är uppdaterat!");
        return;
    }

}

Console.WriteLine("Avslutar updatering av livsmedelslager.");
        }

        static int DefineBudget()
{
    // Define the budget for the food optimization
    int budget;

    Console WriteLine("Ange din budget för livsmedel: ");
    while (!int.TryParse(Console.ReadLine(), out budget) || budget <= 0)
    {
        Console.WriteLine("Ogiltig budget, försök igen.");
    }
    Console.WriteLine($"Din budget är satt till {budget} kronor.");

    return budget;
}


// Method to compute the amount of groceries, packaged in meals, to fulfill the requirements
// of nutritional need, budget and end date for the time scope.
static int DefineEndDateForOptimization()
{
    // Define the end date for the food and budget optimization
    Console.WriteLine("Ange önskat slutdatum för kostoptimering utifrån din budget (Format ÅÅÅÅMMDD): ");
    string endDateInput = Console.ReadLine();
    DateTime endDate;
    while (!DateTime.TryParseExact(endDateInput, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out endDate))
    {
        Console.WriteLine("Ogiltigt datumformat, försök igen (Format ÅÅÅÅMMDD): ");
        endDateInput = Console.ReadLine();
    }

    // Compute the amount of each grosery per day too reach end date input based on budget
    // while still reaching the required macronutrients needed, while trying to stick with 
    // combinations of grocery defined in meals.
    // If the budget is not enough to reach eend date of budget, compute the day the budget
    // will be zero. Also, when computing the grocery within budget, stick to increment of 
    // grocery defined in "LandFil.xml".


    // Compute optimization by a differential equation with date for endDate as dependent variable (Y)
    // and budget, nutritional need and grocery as independent variables (X1, X2, X3, ...).

    // Define the differential equation
    // Computing the amount of grocery within different meaals to stretch the budget while still 
    // fulfilling the requirements of the macro nutrients and energy

    DateTime dateNow = DateTime.Now();
    DateTime endDate = DefineEndDateForOptimization();
    int budget = DefineBudget();
    Dictionary<string, int> nutritionalNeed = DefineNutritionalNeed();
    Dictionary<string, int> grocery = DefineAvailableGrosery();
    // Reads the data  of meals sttored in "FitnessBudget.xml" and storing in variable meals
    // Read meals data from the file FitnessBudget.xml
    try
    {
        using (StreamReader reader = new StreamReader("FitnessBudget.xml", true))
        {
            reader.WriteLine($"<mealName>{mealName}</mealName>");
            reader.WriteLine($"<groceries>{groceries}</groceries>");
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ett fel uppstod vid läsning från filen: {ex.Message}");
        return;
    }

    // Define the differential equation as a function
    // The function takes the current date and the budget as parameters and reads the date
    // of grocery and meals definition stored in "FitnessBudget.xml"
    // and computes the amount of grocery needed to reach the end date of budget while still
    // fulfilling the requirements of the macro nutrients and energy.
    // The function returns the amount of grocery needed to reach the end date of budget while still
    // fulfilling the requirements of the macro nutrients and energy.
    // Define the differential equation as a Func<DateTime, double, double>
    // where the first parameter is the current date and the second parameter is the budget.


    Func < DateTtime, DateTime, int, < string, int>> differentialEquation = (dateNow, endDate, budget, nutritionalNeed) =>
    {
        // Implement the logic for the differential equation


    };

}
    }
}
