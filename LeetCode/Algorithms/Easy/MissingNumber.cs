using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class MissingNumber : IQuestion
    {
        private const string question = "Missing Number";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var nums = new[] { 0, 1, 3 };
            Console.WriteLine(solution(nums));
        }

        private static int solution(int[] nums)
        {
            var sum = 0;
            for (var i = 0; i < nums.Length; i++)
                sum += nums[i] - i;
            
            return nums.Length - sum;
        }
    }
}
