// using System;
// using System.Linq;
// using System.Collections.Generic;

// public class ListNode
// {
//     public int val;
//     public ListNode next;
//     public ListNode(int x) { val = x; }
// }

public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var set = new HashSet<ListNode>();
        while (headA is not null || headB is not null)
        {
            if (headA is not null)
            {
                if (!set.Contains(headA))
                {
                    set.Add(headA);
                    headA = headA.next;
                }
                else return headA;
            }
            if (headB is not null)
            {
                if (!set.Contains(headB))
                {
                    set.Add(headB);
                    headB = headB.next;
                }
                else return headB;
            }
        }
        return null;
    }
}