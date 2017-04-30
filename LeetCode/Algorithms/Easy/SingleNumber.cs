using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class SingleNumber : IQuestion
    {
        private const string question = "Single Number";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var nums = new[] { 1, 2, 2, 1, 3 };
            Console.WriteLine(solution(nums));
        }

        private static int solution(int[] nums)
        {
            var result = 0;
            foreach (var num in nums)
            {
                result ^= num;
            }
            return result;
        }
    }
}
