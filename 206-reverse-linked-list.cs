// using System;
// using System.Linq;
// using System.Collections.Generic;

// public class ListNode
// {
//     public int val;
//     public ListNode next;
//     public ListNode(int val = 0, ListNode next = null)
//     {
//         this.val = val;
//         this.next = next;
//     }
// }

public class Solution
{
    public ListNode ReverseList(ListNode head, ListNode prev = null)
    {
        if (head is null)
            return prev;
        var last = ReverseList(head.next, head);
        head.next = prev;
        return last;
    }
}