
namespace _21_PascalsTriangel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa en matris
            int[,] Matris = new int[10, 10];

            // Lägg ut Pascals triangel på skärmen
            for (int i = 0; i < 10; i++)
            {
                // Skriv ut blanksteg
                for (int j = 0; j < 10 - i; j++)
                {
                    Console.Write("  ");
                }

                // Skriv ut värdena i raden
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        Matris[i, j] = 1;
                    }
                    else
                    {
                        Matris[i, j] = Matris[i - 1, j - 1] + Matris[i - 1, j];
                    }
                    Console.Write($"{Matris[i, j]:000} ");
                }
                Console.WriteLine();
            }
        }


        //

    }
}