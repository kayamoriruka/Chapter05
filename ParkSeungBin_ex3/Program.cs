using System;

namespace ParkSeungBin_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1_while
            int i = 0;
            int j = 0;
            while (i < 5)
            {
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                j = 0;
                
                Console.WriteLine();
                i++;
            }

            Console.WriteLine();


            //ex2_while

            int k = 0;
            int l = 4;
            while (k < 5)
            {
                while (l >= k)
                {
                    Console.Write("*");
                    l--;
                }
                l = 4;

                Console.WriteLine();
                k++;
            }
        }
    }
}
