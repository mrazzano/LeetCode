using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class SumOfTwoIntegers : IQuestion
    {
        private const string question = "Sum of Two Integers";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const int a = 1;
            const int b = 2;
            Console.WriteLine(solution(a, b));
        }

        private static int solution(int a, int b)
        {
            while (true)
            {
                if (b == 0) 
                    return a;

                var a1 = a;
                a = a ^ b;
                b = (a1 & b) << 1;
            }
        }
    }
}
