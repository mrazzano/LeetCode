using LeetCode.Library;

namespace LeetCode.Algorithms.Medium
{
    public class AddTwoNumbers : IQuestion
    {
        private const string question = "Add Two Numbers";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var l1 = Utility.GetLinkedList(new[] { 2, 4, 3 });
            var l2 = Utility.GetLinkedList(new[] { 5, 6, 4 });
            Utility.PrintLinkedList(solution(l1, l2));
        }

        private static ListNode solution(ListNode l1, ListNode l2)
        {
            var previous = new ListNode(0);
            var head = previous;
            var carry = 0;
            while (l1 != null || l2 != null || carry != 0)
            {
                var current = new ListNode(0);
                var sum = ((l2 == null) ? 0 : l2.val) + ((l1 == null) ? 0 : l1.val) + carry;
                current.val = sum % 10;
                carry = sum / 10;
                previous.next = current;
                previous = current;

                l1 = (l1 == null) ? null : l1.next;
                l2 = (l2 == null) ? null : l2.next;
            }
            return head.next;
        }
    }
}
