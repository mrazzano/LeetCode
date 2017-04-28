using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class RemoveDuplicatesSortedArray : IQuestion
    {
        private const string question = "Remove Duplicates from Sorted Array";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var nums = new[] { 1, 1, 2 };
            Console.WriteLine(solution(nums));
        }

        private static int solution(int[] nums)
        {
            var index = nums.Length > 0 ? 1 : 0;
            foreach (var item in nums)
            {
                if (item > nums[index - 1])
                {
                    nums[index++] = item;
                }
            }
            return index;
        }
    }
}
