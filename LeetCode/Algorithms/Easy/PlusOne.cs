using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class PlusOne : IQuestion
    {
        private const string question = "Plus One";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var digits = new[] { 9, 9, 9 };
            Utility.PrintArray(solution(digits));
        }

        private static int[] solution(int[] digits)
        {
            var count = digits.Length;
            for (var i = count - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            var result = new int[count + 1];
            result[0] = 1;

            return result;
        }
    }
}
