using System.Collections.Generic;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class FizBuzz : IQuestion
    {
        private const string question = "Fizz Buzz";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const int n = 15;
            Utility.PrintArray(solution(n).ToArray());
        }

        private static List<string> solution(int n)
        {
            var result = new List<string>();
            for (var i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;
        }
    }
}
