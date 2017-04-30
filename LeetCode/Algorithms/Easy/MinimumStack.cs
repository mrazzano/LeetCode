using System;
using System.Collections.Generic;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class MinimumStack : IQuestion
    {
        private const string question = "Minimum Stack";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var nums = new[] { 2, 4, 3, 1 };
            Console.WriteLine(solution(nums));
        }

        private static int solution(int[] nums)
        {
            var stack = new MinStack();

            foreach (var num in nums)
            {
                stack.Push(num);
            }
            stack.Pop();
            return stack.GetMin();
        }

        public class MinStack
        {
            private int min = Int32.MaxValue;
            private readonly Stack<int> stack = new Stack<int>();

            public void Push(int x)
            {
                if (x < min)
                {
                    stack.Push(min);
                    min = x;
                }
                stack.Push(x);
            }

            public void Pop()
            {
                if (stack.Pop() == min)
                {
                    min = stack.Pop();
                }

                if (stack.Count == 0)
                {
                    min = Int32.MaxValue;
                }
            }

            public int Top()
            {
                return stack.Peek();
            }

            public int GetMin()
            {
                return min;
            }
        }
    }
}
