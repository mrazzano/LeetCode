using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class BestTimeToBuyAndSellStockII : IQuestion
    {
        private const string question = "Best Time to Buy and Sell Stock II";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var prices = new[] { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(solution(prices));
        }

        private static int solution(int[] prices)
        {
            var result = 0;
            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    result += prices[i] - prices[i - 1];
            }
            return result;
        }
    }
}
