using System.Collections.Generic;
using LeetCode.Library;
using LeetCode.Algorithms.Easy;
using LeetCode.Algorithms.Medium;

namespace LeetCode.Algorithms
{
    public class AlgorithmModule : IModule
    {
        private const string ModuleHeader = "Algorithms: {0}";

        public void Execute()
        {
            // execute all modules
            RunEasyQuestions();
            RunMediumQuestions();
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
                new SymmetricTree(),
                new SortedArrayToBST(),
                new MaximumDepthBinaryTree(),
                new PascalsTriangle(),
                new BestTimeToBuyAndSellStockI(),
                new BestTimeToBuyAndSellStockII(),
                new ValidPalindrome(),
                new SingleNumber(),
                new LinkedListCycle(),
                new MinimumStack(),
                new RotateArray(),
                new ReverseBits(),
                new MajorityElement(),
                new ExcelColumnNumber(),
                new NumberOfOneBits(),
                new HouseRobber(),
                new HappyNumber(),
                new CountPrimes(),
                new ReverseLinkedList(),
                new ContainsDuplicates(),
                new DeleteLinkedListNode(),
                new PalindromeLinkedList(),
                new ValidAnagram(),
                new MissingNumber(),
                new MovingZeros(),
                new IsPowerOfThree(),
                new ReverseString(),
                new IntersectionOfTwoArrays(),
                new SumOfTwoIntegers(),
                new FirstUniqueCharacter(),
                new FizBuzz()
            });
        }

        private static void RunMediumQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Medium"), new List<IQuestion>()
            {
                new AddTwoNumbers(),
                new LongestSubstringWithoutRepeats(),
                new LongestPalindromicSubstring(),
                new SearchRotatedArray(),
                new ProductOfArrayExceptSelf(),
                new ZigZagConversion(),
                new IntegerToRoman()
            });
        }
    }
}
