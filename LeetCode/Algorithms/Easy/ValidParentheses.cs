using System;
using System.Collections.Generic;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class ValidParentheses : IQuestion
    {
        private const string question = "Valid Parentheses";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const string s = "()[]{}";
            Console.WriteLine(solution(s));
        }

        private static bool solution(string s)
        {
            var stack = new Stack<char>();
            foreach (var item in s)
            {
                switch (item)
                {
                    case '(':
                    case '{':
                    case '[':
                        {
                            stack.Push(item);
                            break;
                        }
                    case ')':
                        {
                            if (stack.Count == 0 || stack.Pop() != '(')
                                return false;
                            break;
                        }
                    case '}':
                        {
                            if (stack.Count == 0 || stack.Pop() != '{')
                                return false;
                            break;
                        }
                    case ']':
                        {
                            if (stack.Count == 0 || stack.Pop() != '[')
                                return false;
                            break;
                        }
                }
            }
            return stack.Count == 0;
        }
    }
}
