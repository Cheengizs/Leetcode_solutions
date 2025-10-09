namespace Leetcode;

public class AddTwoNumber
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode res = null!;
        ListNode result = null!;
        int additional = 0;
        while (l1 != null && l2 != null)
        {
            if (res == null)
            {
                res = new ListNode(0);
                result = res;
            }
            else
            {
                res.next = new();
                res = res.next;
            }

            res.val = (l1.val + l2.val + additional) % 10;
            additional = (additional + l1.val + l2.val) / 10;
            l1 = l1.next;
            l2 = l2.next;
        }

        if (l1 == null && l2 == null)
        {
            if (additional != 0) res.next = new ListNode(additional);
            res = res.next;
        }
        else if (l1 == null)
        {
            while (l2 != null)
            {
                res.next = new ListNode((additional + l2.val) % 10);
                additional = (additional + l2.val) / 10;
                l2 = l2.next;
                res = res.next;
            }
        } else if (l2 == null)
        {
            while (l1 != null)
            {
                res.next = new ListNode((additional + l1.val) % 10);
                additional = (additional + l1.val) / 10;
                l2 = l2.next;
                res = res.next;
            }
        }

        return result;
    }
}