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
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {
         ListNode dummyNode = new(0);
        dummyNode.next = list1;
        var prev = dummyNode;
        int start = a, len = 0;
        var current = list1;
        while (current != null)
        {
            current = current.next;
            len++;
        }

        current = list1;
        while (start > 0)
        {
            current = current.next;
            prev = prev.next;
            start--;
        }

        prev.next = null;
        //prev = list2;
        while (list2 != null)
        {
            prev.next = list2;
            list2 = list2.next;
            prev = prev.next;
        }

        int diff = b - a;
        while (diff > 0 && current != null)
        {
            current = current.next;
            diff--;
        }

        //prev = list1;
        while (current != null)
        {
            prev.next = current.next;
            current = current.next;
            prev = prev.next;
        }

        return dummyNode.next;
    }
}