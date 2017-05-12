using System;
using System.Text;
using LeetCode.Library;

namespace LeetCode.Algorithms.Medium
{
    public class IntegerToRoman : IQuestion
    {
        private const string question = "Integer to Roman";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const int num = 1996;
            Console.WriteLine(solution(num));
        }

        private static string solution(int num)
        {
            var values = new[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            var romans = new[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            var result = new StringBuilder();
            for (var i = 0; i < values.Length; i++)
            {
                while (num >= values[i])
                {
                    num -= values[i];
                    result.Append(romans[i]);
                }
            }
            return result.ToString();
        }
    }
}
