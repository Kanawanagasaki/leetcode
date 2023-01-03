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
    public bool IsPalindrome(ListNode head)
    {
        var list = new List<int>();
        while (head is not null)
        {
            list.Add(head.val);
            head = head.next;
        }
        for (int i = 0; i < list.Count; i++)
            if (list[i] != list[list.Count - i - 1])
                return false;
        return true;
    }
}