using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _6_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            //Repetera så länge (i) är mindre än 10            
            while (i < 10)
            {
                //Skriv värden på (i) utan att byta rad
                Console.Write($"i: {i,1}");
                i++;

            }

            // Vänta på användarens inmatning innan programmet avslutas
            Console.ReadLine();
        }
    }
}
