using System.Collections.Generic;
using LeetCode.Library;
using LeetCode.Algorithms.Easy;

namespace LeetCode.Algorithms
{
    public class AlgorithmModule : IModule
    {
        const string ModuleHeader = "Algorithms: {0}";

        public void Execute()
        {
            // execute all modules
            RunEasyQuestions();
        }

        private static void RunEasyQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Easy"), new List<IQuestion>()
            {
               new TwoSum(),
               new ReverseInteger(),
               new RomanToInteger(),
               new LongestCommonPrefix(),
               new ValidParentheses(),
               new MergeSortedLists(),
               new RemoveDuplicatesSortedArray(),
               new ImplementStrStr(),
               new CountAndSay(),
               new PlusOne(),
               new ImplementSqrt(),
               new ClimbingStairs(),
               new MergeSortedArrays(),
               new PascalsTriangle(),
               new BestTimeToBuyAndSellStockI(),
               new BestTimeToBuyAndSellStockII(),
               new ValidPalindrome(),
               new SingleNumber()
            });
        }
    }
}
