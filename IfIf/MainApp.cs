﻿using System;

namespace IfIf
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요: ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number > 0)
            {
                if (number % 2 == 0)
                    Console.WriteLine("0보다 큰 짝수");
                else
                    Console.WriteLine("0보다 큰 홀수");

                Console.WriteLine(number % 2 == 0 ? "0보다 큰 짝수" : "0보다 큰 홀수");

            }
            else
            {
                Console.WriteLine("0보다 작거나 큰 수");
            }
        }
    }
}
