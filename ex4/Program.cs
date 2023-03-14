using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수 한 개를 입력하세요: ");

            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number%3 == 0)
                Console.WriteLine($"입력하신 정수 {number}는(은) 3의 배수 입니다.");
            else
                Console.WriteLine($"입력하신 정수 {number}는(은) 3의 배수가 아닙니다.");

            Console.WriteLine("입력하신 정수 {0}는(은) {1}"
               , number, number % 3 == 0 ? "3의 배수 입니다." : "3의 배수가 아닙니다");
        }
    }
}
