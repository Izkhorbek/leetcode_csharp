using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeExamle
{
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
         }
       }

    public class MergeTwoSortedLinkedList
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            List<int> data = new List<int>();

            ListNode first = list1;
            ListNode second = list2;

            while (first != null || second != null)
            {
                if(first!=null)
                {
                    data.Add(first.val);
                    first = first.next;
                }
                if(second!=null)
                {
                    data.Add(second.val);
                    second = second.next;

                }
            }

            Console.WriteLine(data.ToString());
            ListNode dda = new ListNode();
            return dda; 
        }
    }
}
