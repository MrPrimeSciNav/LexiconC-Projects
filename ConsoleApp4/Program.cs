using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _4_Multiplikationstabell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Be användaren ange maxvärde för multiplikationstabellen
            Console.Write("Ange maxvärde för tabellen som ett heltal: ");

            //Användaren kan ange ett värde
            string MaxVString = Console.ReadLine();


            //Variabel som ska ta emot det omvandlade värdet
            int MaxVInt;

            //Konvertera det inlästa värdet till ett heltal
            int.TryParse(MaxVString, out MaxVInt);

            //Lägg ut multiplikationstabellen
            for (int i = 1; i <= MaxVInt; i++)
            {
                for (int j = 1; j <= MaxVInt; j++)
                {
                    //Skriv ut multiplikationstabellen
                    Console.Write($"{j,4}", i * j);
                }
                //Byt rad efter varje rad i tabellen
                Console.WriteLine();
            }

        }
    }
}
