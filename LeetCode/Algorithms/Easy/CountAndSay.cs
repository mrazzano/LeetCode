using System;
using System.Text;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class CountAndSay : IQuestion
    {
        private const string question = "Count and Say";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            const int n = 3;
            Console.WriteLine(solution(n));
        }

        private static string solution(int n)
        {
            if (n <= 0) return "-1";

            var result = "1";
            for (var i = 1; i < n; i++)
            {
                result = build(result);
            }
            return result;
        }

        private static string build(string result)
        {
            var index = 0;
            var sb = new StringBuilder();
            while (index < result.Length)
            {
                var val = result[index];
                var count = 0;

                while (index < result.Length && result[index] == val)
                {
                    index++;
                    count++;
                }
                sb.Append(count);
                sb.Append(val);
            }
            return sb.ToString();
        }
    }
}
