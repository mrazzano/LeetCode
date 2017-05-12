using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Medium
{
    public class SearchRotatedArray : IQuestion
    {
        private const string question = "Search in Rotated Sorted Array";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const int target = 0;
            var nums = new[] { 4, 5, 6, 7, 0, 1, 2 };
            Console.WriteLine(solution(nums, target));
        }

        private static int solution(int[] nums, int target)
        {
            int low = 0, high = nums.Length;
            while (low < high)
            {
                var mid = (low + high) / 2;
                double num = (nums[mid] < nums[0]) == (target < nums[0])
                           ? nums[mid]
                           : target < nums[0] ? Int32.MinValue : Int32.MaxValue;

                if (num < target)
                {
                    low = mid + 1;
                }
                else if (num > target)
                {
                    high = mid;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
