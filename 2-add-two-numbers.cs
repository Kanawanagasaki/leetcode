
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode current = null;
        ListNode first = null;

        bool carry = false;
        while (l1 is not null || l2 is not null)
        {
            var val = (l1?.val ?? 0) + (l2?.val ?? 0) + (carry ? 1 : 0);
            if (val > 9)
            {
                carry = true;
                val %= 10;
            }
            else
                carry = false;
            if (current is null)
                first = current = new ListNode(val);
            else
            {
                var chlid = new ListNode(val);
                current.next = chlid;
                current = chlid;
            }

            l1 = l1?.next;
            l2 = l2?.next;
        }

        if(carry)
            current.next = new ListNode(1);

        return first;
    }
}
