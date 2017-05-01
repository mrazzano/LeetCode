using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class HouseRobber : IQuestion
    {
        private const string question = "House Robber";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var nums = new[] { 1, 2, 2, 1, 3 };
            Console.WriteLine(solution(nums));
        }

        private static int solution(int[] nums)
        {
            var sumOdd = 0;
            var sumEven = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven = Math.Max(sumEven + nums[i], sumOdd);
                }
                else
                {
                    sumOdd = Math.Max(sumOdd + nums[i], sumEven);
                }
            }

            return Math.Max(sumOdd, sumEven);
        }
    }
}
