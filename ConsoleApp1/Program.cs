using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _2_TestaKonstanter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definiera en konstanter
            const int Fryspunkt = 0;
            const int Kokpunkt = 100;

            Console.WriteLine("Fryspunkt vatten: {0}, Kokpunkt vatten: {1}", Fryspunkt, Kokpunkt);


            // Vänta på användarens inmatning innan programmet avslutas
            Console.ReadLine();
        }
    }
}
