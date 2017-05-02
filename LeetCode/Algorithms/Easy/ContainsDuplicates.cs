using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class ContainsDuplicates : IQuestion
    {
        private const string question = "Contains Duplicates";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var nums = new[] { 6, 5, 5 };
            Console.WriteLine(solution(nums));
        }

        private static bool solution(int[] nums)
        {
            var length = nums.Length;
            if (length <= 1)
                return false;

            Array.Sort(nums);
            for (var i = 1; i < length; i++)
            {
                if (nums[i] == nums[i - 1])
                    return true;
            }
            return false;
        }
    }
}
