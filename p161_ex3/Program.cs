using System;

namespace p161_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("몇월이 궁금하세요? ");
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);
            int day = 0;
            

            switch (number1)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 4: case 6: case 9: case 11:
                    day = 30;
                    break;
                case 2:
                    day = 28;
                    break;
                default:
                    Console.WriteLine("정상적인 입력값이 아닙니다. 다시 실행하여 주세요.");
                    return;

            }

            Console.WriteLine($"{input1}월은 {day}일 까지 있습니다.");
        }
    }
}
