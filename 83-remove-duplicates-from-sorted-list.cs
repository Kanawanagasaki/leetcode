
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
    public ListNode DeleteDuplicates(ListNode head)
    {
        var buff = head;
        while(buff is not null)
        {
            while(buff.val == buff.next?.val)
                buff.next = buff.next.next;
            buff = buff.next;
        }
        return head;
    }
}