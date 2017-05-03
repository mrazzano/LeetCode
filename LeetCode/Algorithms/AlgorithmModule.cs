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
    }
}
