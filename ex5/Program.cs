using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("세 개의 정수 중 첫번째 정수를 입력해 주세요: ");
            string input1 = Console.ReadLine();
            int number1 = Int32.Parse(input1);

            Console.Write("세 개의 정수 중 두번째 정수를 입력해 주세요: ");
            string input2 = Console.ReadLine();
            int number2 = Int32.Parse(input2);

            Console.Write("세 개의 정수 중 세번째 정수를 입력해 주세요: ");
            string input3 = Console.ReadLine();
            int number3 = Int32.Parse(input3);

            int min = number1;
            int max = number1;
            int sum = (number1 + number2 + number3);
            int avg = sum / 3;

            if (min > number2)
                min = number2;
            if (min > number3)
                min = number3;

            if (max < number2)
                max = number2;
            if (max < number3)
                max = number3;

            Console.WriteLine($"입력하신 {number1},{number2},{number3} 중 최대값은 {max}이며, 최소값은 {min} 입니다.");
            Console.WriteLine($"입력하신 {number1},{number2},{number3} 의 합은 {sum}이며, 평균은 {avg} 입니다.");

        }
    }
}
