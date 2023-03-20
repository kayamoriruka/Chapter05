using System;

namespace ParkSeungBin_ex4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("반복 횟수를 입력하세요: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
                return;
            }          

            int i = 1;
            while (i <= n)
            {
                int j = 0;
                while (j < i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }

        }
    }
}