using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class MovingZeros : IQuestion
    {
        private const string question = "Moving Zeros";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var nums = new[] { 0, 1, 0, 3, 12 };
            Utility.PrintArray(solution(nums));
        }

        private static int[] solution(int[] nums)
        {
            var length = nums.Length;
            for (var i = 0; i < length; i++)
            {
                if (nums[i] != 0) continue;
                for (var j = i + 1; j < length; j++)
                {
                    if (nums[j] != 0)
                    {
                        swap(nums, i, j);
                        break;
                    }
                }
            }
            return nums;
        }

        private static void swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
