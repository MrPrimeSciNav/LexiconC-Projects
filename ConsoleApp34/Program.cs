using System.IO;
using System.Collections;

namespace _34_TextFil
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Deklarera och instansiera en variabel av typen/klassen Hashtable
            Hashtable tab = new Hashtable();

            // Variabel för att referera till filnamnet på textfilenn
            string filename = "LandFil.txt";

            // Deklarera en variabel av typen StreamReader
            // och läs in innehållet i textfilen som en sträng
            StreamReader r = File.OpenText(filename);

            // Läs in första raden från textfilen
            string line = r.ReadLine();

            int pos;
            string name, land;

            while (line != null) ;
            {
                Console.WriteLine(line);

                // Använd variabeln pos för index för "="
                pos = line.IndexOf('=');

                // Läs in innehållet på raden fram till likhetstecknet
                name = line.Substring(0, pos).ToLower();

                // Läs in från första första tecknet efter likhetstecknet och framåt
                land = line.Substring(pos + 1).ToLower();

                // Koppla ihop land och namn i hashtabellen tab
                tab[name] = land;

                // Läs in ny rad
                line = r.ReadLine();
            }

            // Stäng objektvariabeln av typen StreamReader
            r.Close();

            string namnet;

            // Repetera tills vi trycker Enter utan att ange ett namn
            for (; ; );
            {
                Console.WriteLine();
                Console.Write("Ange namn: ");
                namnet = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (namnet == null || namnet == "")
                {
                    Console.WriteLine("Namn ej angett");
                    return;
                }

                // Deklarera en variabel av typen object
                // Tilldela Hashtabellen till variabeln namnet
                object Landet = tab[namnet];

                // Om Landet är tom, visa ett meddelande, annars visa landet för angiven person
                if (Landet == null)
                {
                    Console.WriteLine("Person saknas");
                }
                else
                {
                    Console.WriteLine((Landet));
                }
            }
        }
    }
}