﻿using System;
using System.Text;
using System.Collections.Generic;

namespace LeetCode.Library
{
    public static class Utility
    {
        private const int LineLength = 60;

        #region Output Methods

        public static void PrintProgramHeader(string header)
        {
            var separator = new string('*', LineLength);

            var sb = new StringBuilder();
            sb.AppendLine(separator);
            sb.AppendFormat("* {0}", header);
            sb.Append(Environment.NewLine);
            sb.AppendLine(separator);
            sb.AppendLine();

            Console.WriteLine(sb.ToString());
        }

        public static void PrintLessonHeader(string header)
        {
            var separator = new string('-', LineLength);

            var sb = new StringBuilder();
            sb.AppendLine(separator);
            sb.AppendLine(header);
            sb.Append(separator);

            Console.WriteLine(sb.ToString());
        }

        public static void PrintQuestionHeader(int order, string question)
        {
            const string FormatString = "Question {0} - {1}";
            Console.WriteLine(FormatString, order, question);
        }

        public static void PrintArray(int[] array)
        {
            var sb = new StringBuilder();
            sb.Append("[");
            foreach (var item in array)
            {
                sb.AppendFormat("{0}, ", item);
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }

        public static void PrintLinkedList(ListNode head)
        {
            var sb = new StringBuilder();
            var node = head;
            while (node != null)
            {
                sb.AppendFormat("{0}->", node.val);
                node = node.next;
            }
            Console.WriteLine(sb.ToString().Remove(sb.Length - 2, 2));
        }

        public static void PrintTreePreOrder(TreeNode root)
        {
            if (root == null)
                return;

            Console.Write(root.val + " ");
            PrintTreePreOrder(root.left);
            PrintTreePreOrder(root.right);
        }
        #endregion

        #region Initialization Methods

        public static ListNode GetLinkedList(int[] nodes)
        {
            ListNode lastListNode = null;
            for (var i = nodes.Length - 1; i >= 0; i--)
            {
                var node = new ListNode(nodes[i], lastListNode);
                lastListNode = node;
            }
            return lastListNode;
        }

        public static TreeNode GetBinaryTree(int[] treeNodes, int index)
        {
            if (index > treeNodes.Length)
                return null;

            var value = treeNodes[index - 1];
            var node = new TreeNode(value)
            {
                left = GetBinaryTree(treeNodes, index * 2),
                right = GetBinaryTree(treeNodes, index * 2 + 1)
            };
            return node;
        }
        #endregion

        #region Implementation Methods

        public static void RunQuestions(string header, IReadOnlyList<IQuestion> questions)
        {
            PrintLessonHeader(header);
            for (var i = 0; i < questions.Count; i++)
            {
                questions[i].Run(i + 1);
                Console.WriteLine();
            }
        }
        #endregion
    }
}