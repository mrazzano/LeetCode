using LeetCode.Library;

namespace LeetCode.Algorithms.Medium
{
    public class ProductOfArrayExceptSelf : IQuestion
    {
        private const string question = "Product of Array Except Self";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var nums = new[] { 1, 2, 3, 4 };
            Utility.PrintArray(solution(nums));
        }

        private static int[] solution(int[] nums)
        {
            var length = nums.Length;
            var result = new int[length];

            result[0] = 1;
            for (var i = 1; i < length; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }
            return result;
        }
    }
}
