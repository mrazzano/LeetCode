using System;
using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class BestTimeToBuyAndSellStockI : IQuestion
    {
        private const string question = "Best Time to Buy and Sell Stock I";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var prices = new[] { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(solution(prices));
        }

        private static int solution(int[] prices)
        {
            var result = 0;
            var minPrice = Int32.MaxValue;
            foreach (var price in prices)
            {
                minPrice = Math.Min(minPrice, price);
                result = Math.Max(result, price - minPrice);
            }
            return result;
        }
    }
}
