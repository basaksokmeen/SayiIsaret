using System;

namespace SayiIsaret
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 11, -73, 0, 6, -8, 22, 51, 7, -40, 9, 3, -11 };
            foreach (var sayi in sayilar)
            {
                if (sayi > 0 && sayi % 2 == 0)
                {
                    Console.WriteLine("{0} sayısı pozitif ve çifttir.", sayi);
                }
                if (sayi > 0 && sayi % 2 != 0)
                {
                    Console.WriteLine("{0} sayısı pozitif ve tektir.", sayi);
                }
                else if (sayi < 0 && sayi % 2 != 0)
                {
                    Console.WriteLine("{0} sayısı negatif ve tektir.", sayi);
                }
                else if (sayi < 0 && sayi % 2 == 0)
                {
                    Console.WriteLine("{0} sayısı negatif ve çifttir.", sayi);
                }
                else if (sayi == 0)
                    Console.WriteLine("{0} sayısı nötr ve işaretsizdir.", sayi);
            }
        }
    }
}
