using System;

namespace _161_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수 2개와 연산기호를 입력해주세요");

            Console.Write("첫 번째 정수를 입력해주세요. : ");
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);

            Console.Write("두 번째 정수를 입력해주세요. : ");
            string input2 = Console.ReadLine();
            int number2 = int.Parse(input2);

            Console.Write("연산기호를 입력해주세요. ex)+,-,*,/,% : ");
            string input3 = Console.ReadLine();

            int result = 0;

            switch(input3)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                case "%":
                    result = number1 % number2;
                    break;
                default:
                    Console.Write("error");
                    return;

            }
            Console.WriteLine($"입력하신 {input1}{input3}{input2}의 결과값은 {result} 입니다.");

        }
    }
}
