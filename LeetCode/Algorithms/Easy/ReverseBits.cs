using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class ReverseBits : IQuestion
    {
        private const string question = "Reverse Bits";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const uint n = 43261596;
            Console.WriteLine(solution(n));
        }

        private static uint solution(uint n)
        {
            long result = 0;
            for (var i = 0; i < 32; i++)
            {
                result = (result << 1) | (n & 1);
                n = n >> 1;
            }
            return (uint)result;
        }
    }
}
