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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1==null && list2==null) return null;
        ListNode dummyNode = new(0);
        var prev=dummyNode;
        while(list1!=null && list2!=null){
            ListNode newNode= new();
            if(list1.val<list2.val){
                newNode.val=list1.val;
                list1=list1.next;
            }else{
                 newNode.val=list2.val;
                list2=list2.next;
            }
            prev.next = newNode;
            prev=prev.next;
        }
        if (list1 is not null) prev.next = list1;
        else if (list2 is not null) prev.next = list2;
        return dummyNode.next;
    }
}