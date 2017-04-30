using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class ReverseInteger : IQuestion
    {
        private const string question = "Reverse Integer";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const int x = -123;
            Console.WriteLine(solution(x));
        }

        private static int solution(int x)
        {
            long result = 0;
            while (x != 0)
            {
                result *= 10;
                result += x % 10;
                x /= 10;
            }

            if (result > Int32.MaxValue || result < Int32.MinValue)
                return 0;

            return (int)result;
        }
    }
}
