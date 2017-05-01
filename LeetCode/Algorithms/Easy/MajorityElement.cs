using System;
using System.Collections.Generic;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class MajorityElement : IQuestion
    {
        private const string question = "Majority Element";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var nums = new[] { 6,5,5 };
            Console.WriteLine(solution(nums));
        }

        private static int solution(int[] nums)
        {
            var length = nums.Length;
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], 1);
                }
                else
                {
                    dict[nums[i]]++;
                }

                if (dict[nums[i]] > length / 2)
                {
                    return nums[i];
                }
            }
            return 0;
        }
    }
}
