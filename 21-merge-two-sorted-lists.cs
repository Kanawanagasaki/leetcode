/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
 */

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

// @lc code=start
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 is null && list2 is null)
            return null;
        if (list1 is null)
            return list2;
        if (list2 is null)
            return list1;

        ListNode ret, curr;

        if (list1.val <= list2.val)
        {
            curr = ret = new ListNode(list1.val);
            list1 = list1.next;
        }
        else
        {
            curr = ret = new ListNode(list2.val);
            list2 = list2.next;
        }

        while (list1 is not null || list2 is not null)
        {
            if (list1 is null)
            {
                curr.next = list2;
                break;
            }

            if (list2 is null)
            {
                curr.next = list1;
                break;
            }

            if (list1.val <= list2.val)
            {
                curr = curr.next = new ListNode(list1.val);
                list1 = list1.next;
            }
            else
            {
                curr = curr.next = new ListNode(list2.val);
                list2 = list2.next;
            }
        }

        return ret;
    }
}
// @lc code=end

