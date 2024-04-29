/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
        public bool IsPalindrome(ListNode head)
    {
        if (head == null || head.next == null) return true;
        var slow = head;
        var fast = head;
        ListNode prev = null;
        while (fast != null && fast.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        prev.next = null;
        var tail = ReverseList(slow);
        while (head != null && tail != null)
        {
            if (head.val != tail.val)
                return false;
            head=head.next;
            tail=tail.next;
        }

        return true;
    }
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next==null) return head;
        ListNode lastNode = ReverseList(head.next);
        head.next.next = head;
        head.next = null;
        return lastNode;
    }
}