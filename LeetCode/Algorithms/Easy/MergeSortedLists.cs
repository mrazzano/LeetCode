using LeetCode.Library;

namespace LeetCode.Algorithms.Easy
{
    public class MergeSortedLists : IQuestion
    {
        private const string question = "Merge Two Sorted Lists";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var l1 = Utility.GetLinkedList(new[] { 1, 3, 5 });
            var l2 = Utility.GetLinkedList(new[] { 2, 4, 6 });

            Utility.PrintLinkedList(solution(l1, l2));
        }

        private static ListNode solution(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;

            if (l1 == null)
                return l2;

            if (l2 == null)
                return l1;

            var result = new ListNode(0, null);
            var prev = result;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    prev.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    prev.next = l2;
                    l2 = l2.next;
                }
                prev = prev.next;
            }

            if (l1 != null)
            {
                prev.next = l1;
            }

            if (l2 != null)
            {
                prev.next = l2;
            }
            return result.next;
        }
    }
}
