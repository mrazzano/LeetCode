using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class IsPowerOfThree : IQuestion
    {
        private const string question = "Power of Three";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const int n = 9;
            Console.WriteLine(solution(n));
        }

        private static bool solution(int n)
        {
            if (n < 1)
                return false;

            while (n%3 == 0)
            {
                n /= 3;
            }
            return n == 1;
        }
    }
}
