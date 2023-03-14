using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("중간고사 점수 합격여부 프로그램.");
            Console.Write("현재 본인의 학년을 숫자만 입력하세요.(ex.2) : ");
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);

            Console.Write("현재 본인의 점수를 입력하세요.(ex.85) : ");
            string input2 = Console.ReadLine();
            int number2 = int.Parse(input2);

            if (number2 > 100 || number2 < 0)
            {
                Console.WriteLine("점수를 잘못 입력하셨습니다. 확인 후 다시 입력해주세요.");
                return;
            }
           
            if (number1 == 4)
            {
                if (number2 >= 70)
                    Console.WriteLine($"입력하신 점수 {number2}는(은) 합격 입니다.");
                else if (number2 >= 0)
                    Console.WriteLine($"입력하신 점수 {number2}는(은) 불합격 입니다.");
            }
            else
            {
                if (number2 >= 60)
                    Console.WriteLine($"입력하신 점수 {number2}는(은) 합격 입니다.");
                else if (number2 >= 0)
                    Console.WriteLine($"입력하신 점수 {number2}는(은) 불합격 입니다.");
            }

        }
    }
}
