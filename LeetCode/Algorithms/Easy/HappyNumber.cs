using System;
using System.Collections.Generic;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class HappyNumber : IQuestion
    {
        private const string question = "Happy Number";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const int n = 19;
            Console.WriteLine(solution(n));
        }

        private static bool solution(int n)
        {
            var hash = new HashSet<Int32>();
            while (hash.Add(n))
            {
                var squareSum = 0;
                while (n > 0)
                {
                    var remainder = n % 10;
                    squareSum += remainder * remainder;
                    n /= 10;
                }

                if (squareSum == 1)
                    return true;

                n = squareSum;
            }
            return false;
        }
    }
}
