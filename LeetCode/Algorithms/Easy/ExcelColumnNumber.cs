using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class ExcelColumnNumber : IQuestion
    {
        private const string question = "Excel Column Number";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const string s = "BA";
            Console.WriteLine(solution(s));
        }

        private static int solution(string s)
        {
            var result = 0;
            foreach (var letter in s)
            {
                result = result * 26 + (letter - 'A' + 1);
            }
            return result;
        }
    }
}
