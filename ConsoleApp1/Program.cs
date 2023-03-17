using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int count = 1;
        while (count <= 5)
        {
            int starCount = 1;
            while (starCount <= count)
            {
                Console.Write("*");
                starCount++;
            }
            Console.WriteLine();
            count++;
        }
    }