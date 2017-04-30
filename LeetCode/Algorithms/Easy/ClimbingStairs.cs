using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class ClimbingStairs : IQuestion
    {
        private const string question = "Climbing Stairs";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const int n = 4;
            Console.WriteLine(solution(n));
        }

        private static int solution(int n)
        {
            if (n <= 0)
                return 0;

            if (n == 1)
                return 1;

            if (n == 2)
                return 2;

            var oneStep = 2;
            var twoStep = 1;
            var result = 0;

            for (var i = 2; i < n; i++)
            {
                result = oneStep + twoStep;
                twoStep = oneStep;
                oneStep = result;
            }
            return result;
        }
    }
}
