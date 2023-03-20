using System;

namespace ParkSeungBin_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1_while_do
            int count = 1;
            do
            {
                int starCount = 1;
                do
                {
                    Console.Write("*");
                    starCount++;
                } while (starCount <= count);

                Console.WriteLine();

                count++;

            } while (count <= 5);

            Console.WriteLine();

            //ex2_while_do

            int i = 5;
            while (i > 0)
            {
                int j = 0;
                do
                {
                    Console.Write("*");
                    j++;
                } while (j < i);
                Console.WriteLine();
                i--;
            }
        }
    }
}
