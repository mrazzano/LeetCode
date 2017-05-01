using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class NumberOfOneBits : IQuestion
    {
        private const string question = "Number of 1 Bits";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const uint n = 11;
            Console.WriteLine(solution(n));
        }

        private static int solution(uint n)
        {
            var s = Convert.ToString(n, 2);

            var result = 0;
            foreach (var item in s)
            {
                result += item == '0' ? 0 : 1;
            }
            return result;
        }
    }
}
