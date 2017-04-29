using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class RotateArray : IQuestion
    {
        private const string question = "Rotate Array";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            const int k = 3;
            var nums = new[] { 1, 2, 3, 4, 5, 6, 7 };
            solution(nums, k);

            Utility.PrintArray(nums);
        }

        private static void solution(int[] nums, int k)
        {
            var length = nums.Length;

            var temp = new int[length];
            nums.CopyTo(temp, 0);

            for (var i = 0; i < length; i++)
            {
                nums[(i + k) % length] = temp[i];
            }

            // alternate solution
            
            //k = k % length;
            //Array.Reverse(nums);
            //Array.Reverse(nums, 0, k);
            //Array.Reverse(nums, k, length - k);

        }
    }
}
