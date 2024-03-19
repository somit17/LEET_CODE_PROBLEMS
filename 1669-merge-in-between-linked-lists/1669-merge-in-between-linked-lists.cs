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
        ListNode prev = list1;
        for (int i = 0; i < a - 1; i++) {
            prev = prev.next;
        }

        ListNode temp = prev.next;
        prev.next = list2;

        while (list2.next != null) {
            list2 = list2.next;
        }

        for (int i = 0; i < b - a + 1; i++) {
            temp = temp.next;
        }

        list2.next = temp;
        return list1;
    }
}