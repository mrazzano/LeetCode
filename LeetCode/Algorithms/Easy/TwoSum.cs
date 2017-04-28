using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class TwoSum : IQuestion
    {
        private const string question = "Two Sum";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            const int target = 9;
            var nums = new[] { 2, 7, 11, 15 };
            Utility.PrintArray(solution(nums, target));
        }

        private static int[] solution(int[] nums, int target)
        {
            var count = nums.Length;
            for (var i = 0; i < count; i++)
            {
                for (var j = i + 1; j < count; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] { i, j };
                    }
                }
            }
            return new int[0];
        }
    }
}
