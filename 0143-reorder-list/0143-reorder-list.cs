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
    public void ReorderList(ListNode head)
    {
        ListNode fast = head, slow = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        var reverseListHead = ReverseLinkedList(slow);
        var current = head;
        while (reverseListHead.next != null)
        {
            var temp = current.next;
            current.next = reverseListHead;
            
            var reverseTemp = reverseListHead.next;
            reverseListHead.next = temp;
            
            current = temp;
            reverseListHead = reverseTemp;
        }
    }

    public ListNode ReverseLinkedList(ListNode head)
    {
        if (head == null || head.next==null) return head;
        ListNode lastNode = ReverseLinkedList(head.next);
        head.next.next = head;
        head.next = null;
        return lastNode;
    }
}