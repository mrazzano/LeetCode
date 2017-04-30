using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class ImplementSqrt : IQuestion
    {
        private const string question = "Implement Sqrt(x)";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const int x = 256;
            Console.WriteLine(solution(x));
        }

        private static int solution(int x)
        {
            long result = x;
            while (result * result > x)
            {
                result = (result + x / result) / 2;
            }
            return (int)result;
        }
    }
}
