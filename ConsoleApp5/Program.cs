using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _9_ListaSortering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa en lista med heltal
            List<string> PersNamn = new List<string>();

            //Lägg in namn i listan
            PersNamn.Add("Anna");
            PersNamn.Add("Bertil");
            PersNamn.Add("Cecilia");
            PersNamn.Add("David");
            PersNamn.Add("Eva");
            PersNamn.Add("Filip");

            // Sortera listan Alfanumeriskt stigande
            PersNamn.Sort();

            // Skriv ut den sorterade listan
            foreach (string namnet in PersNamn)
            {
                Console.WriteLine(namnet);
            }

            // Vänta på användarens inmatning innan programmet avslutas
            Console.ReadLine();
        }
    }
}