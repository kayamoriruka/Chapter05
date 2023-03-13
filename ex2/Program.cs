using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("점수를 입력하세요: ");

            string input = Console.ReadLine();
            int score = Int32.Parse(input);
            char grade;

            if (score >= 90)
                grade = 'A';
            else if (score >= 80)
                grade = 'B';
            else if (score >= 70)
                grade = 'C';
            else grade = 'F';

            Console.WriteLine($"입력하신 점수 {score}는(은) {grade} 학점 입니다.");

        }
    }
}
