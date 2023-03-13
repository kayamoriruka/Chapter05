using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요: ");

            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number >= 50)
                Console.WriteLine($"입력하신 숫자 {number}는(은) 50 이상의 수 입니다.");
            else
                Console.WriteLine($"입력하신 숫자 {number}는(은) 50 미만의 수 입니다.");

            Console.WriteLine("입력하신 숫자 {0}는(은) {1} 입니다."
                , number, number >= 50 ? "50 이상의 수" : "50 미만의 수");

        }
    }
}
