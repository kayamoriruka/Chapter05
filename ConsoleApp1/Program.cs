using System;

class MainClass
{
    public static void Main(string[] args)
    {
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
    }
}