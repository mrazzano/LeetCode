using System;
using System.Text;
using LeetCode.Library;

namespace LeetCode.Algorithms.Medium
{
    public class ZigZagConversion : IQuestion
    {
        private const string question = "ZigZag Conversion";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const int numRows = 3;
            const string s = "PAYPALISHIRING";

            Console.WriteLine(solution(s, numRows));
        }

        private static string solution(string s, int numRows)
        {
            var sb = new StringBuilder[numRows];
            for (var i = 0; i < numRows; i++)
            {
                sb[i] = new StringBuilder();
            }

            var index = 0;
            var length = s.Length;
            while (index < length)
            {
                for (var i = 0; i < numRows && index < length; i++)
                {
                    sb[i].Append(s[index++]);
                }
                for (var i = numRows - 2; i >= 1 && index < length; i--)
                {
                    sb[i].Append(s[index++]);
                }
            }

            var result = "";
            foreach (var item in sb)
            {
                result += item;
            }
            return result;
        }
    }
}
