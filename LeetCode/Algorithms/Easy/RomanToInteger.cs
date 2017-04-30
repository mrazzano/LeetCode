using System;
using System.Collections.Generic;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class RomanToInteger : IQuestion
    {
        private const string question = "Roman to Integer";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const string s = "MCMXCVI";
            Console.WriteLine(solution(s));
        }

        private static int solution(string s)
        {
            var dict = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            var result = 0;
            for (var i = 0; i < s.Length; i++)
            {
                var s1 = dict[s[i]];
                if (i + 1 < s.Length)
                {
                    var s2 = dict[s[i + 1]];
                    if (s1 >= s2)
                    {
                        result += s1;
                    }
                    else
                    {
                        result = result + s2 - s1;
                        i++;
                    }
                }
                else
                {
                    result += s1;
                }
            }
            return result;
        }
    }
}
