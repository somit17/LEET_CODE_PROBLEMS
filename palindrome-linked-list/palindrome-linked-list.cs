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
    
    /*public bool IsPalindrome(ListNode head) {
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
    }*/
    
    
    public bool IsPalindrome(ListNode head) {
        //Approach 2
        var slow=head;var fast=head;
        while(fast!=null && fast.next!=null){
            slow=slow.next;
            fast=fast.next.next;
        }
        var reverseLL = ReverseLinkedList(slow);
        while(head!=null && reverseLL!=null){
            if(head.val!=reverseLL.val){
                return false;
            }
            head=head.next;
            reverseLL=reverseLL.next;
        }
        return true;
    }
    public ListNode ReverseLinkedList(ListNode head){
        if(head==null || head.next==null)
                return head;
        var lastNode = ReverseLinkedList(head.next);
        head.next.next=head;
        head.next=null;
        return lastNode;
    }
}