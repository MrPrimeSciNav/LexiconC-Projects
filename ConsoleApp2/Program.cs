using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _5_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Räkna upp (i) från 0 till 100
            for (int i = 1; i <= 100; i++)
            {
                //Skriv värden på (i) utan att byta rad
                Console.Write($"{i,4}");

                //Kolla om (i) är delbart med 10
                if (i % 10 == 0)
                {
                    //Skriv en tab och värdet på (i) till höger
                    Console.WriteLine("\t{0,4}", i);
                }
            }

            // Vänta på användarens inmatning innan programmet avslutas
            Console.ReadLine();
        }
    }
}
