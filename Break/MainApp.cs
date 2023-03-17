using System;

namespace Break
{
    class MainApp
    {
        static void Main(string[] args)
        {
            bool a = true;

            while(a)
            {
                Console.WriteLine("계속할까요?(예/아니오) : ");
                string answer = Console.ReadLine();

                if (answer == "아니오")
                    a = false;
            }
        }
    }
}
