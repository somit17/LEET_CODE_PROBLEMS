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
    public bool IsPalindrome(ListNode head) {
        List<int> result = new();
        var current=head;
        while(current!=null){
            result.Add(current.val);
            current=current.next;
        }
        int L=0,R=result.Count-1;
        while(L<=R){
            if(result[L]!=result[R])
                return false;
        L++;
        R--;
        }
        return true;
    }
}