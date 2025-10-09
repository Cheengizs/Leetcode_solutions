using leetcode_tasks;

namespace Leetcode;

public class Program
{
    public static void Main(string[] args)
    {
        ListNode l1 = new ListNode(9);
        l1.next = new(9);
        l1.next.next = new(9);
        l1.next.next.next = new(9);
        l1.next.next.next.next = new(9);
        l1.next.next.next.next.next = new(9);
        l1.next.next.next.next.next.next = new(9);
        
        ListNode l2 = new ListNode(9);
        l2.next = new(9);
        l2.next.next = new(9);
        l2.next.next.next = new(9);

        AddTwoNumber a = new();
        a.AddTwoNumbers(l1, l2);
    }
}