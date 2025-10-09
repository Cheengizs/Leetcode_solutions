namespace Leetcode;

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

public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode res = head;

        while (head != null)
        {
            ListNode nextNode = head.next;
            while (nextNode != null && nextNode.val != head.val)
                nextNode = nextNode.next;
            // if(nextNode.val != head.val){
            //     head.next
            // }
            head.next = nextNode;
            head = head.next;
        }

        return res;

        // HashSet<int> set = new();
        // while(head != null){
        //     if(!set.Contains(head.val)){
        //         temp.next = new();
        //         temp = temp.next;
        //         temp.val = head.val;
        //         set.Add(head.val);
        //     }
        //     head = head.next;
        // }

        // return res.next;
    }
}