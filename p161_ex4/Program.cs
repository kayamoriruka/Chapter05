using System;

namespace p161_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("몇월이 궁금하세요? ");
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);
            string season = "";


            switch (number1)
            {
                case 3:
                case 4:
                case 5:
                    season = "봄";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "여름";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "가을";
                    break;
                case 12:
                case 1:
                case 2:
                    season = "겨울";
                    break;

                default:
                    Console.WriteLine("정상적인 입력값이 아닙니다. 확인 후 다시 실행하여 주세요.");
                    return;

            }

            Console.WriteLine($"입력하신 {input1}월은 {season} 입니다.");
        }
    }
}
