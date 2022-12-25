/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head is null)
            return false;
        var buff = head.next;
        while (buff is not null)
        {
            if (head == buff)
                return true;
            head = head.next;
            buff = buff.next?.next;
        }
        return false;
    }
}