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
        // if (head != null)
        // {
        //     //Find middle
        //     ListNode slow = head, fast = head.next;
        //     while (fast !=null)
        //     {
        //         slow = slow.next;
        //         fast = fast.next.next;
        //     }
        //     
        //     //Split the Linked List
        //     ListNode second = slow.next,prev=null,temp=second;
        //     slow.next = null;
        //     //Logic to reverse Linked List
        //     while (second!=null)
        //     {
        //         temp = second.next;
        //         second.next = prev;
        //         prev = second;
        //         second = temp;
        //     }
        //     
        //     
        //     //Merge 
        //     ListNode first = head;
        //     second = prev;
        //     while (second!=null)
        //     {
        //         var temp1 = first.next;
        //         var temp2 = second.next;
        //         first.next = second;
        //         second.next = temp1;
        //         first = temp1;
        //         second = temp2;
        //     }
        // }


        if (head == null || head.next == null) return;
        // find middle
        var slow = head;
        var fast = head.next;
        var nodeCount = 1;
        while (true)
        {
            if (fast == null || fast.next == null) break;
            slow = slow.next;
            nodeCount++;
            fast = fast.next.next;
        }

        var middle = slow.next;
        slow.next = null;


        var secondHead = revList(middle);

        // merge two lists
        var first = head;
        var second = secondHead;
        while (second != null)
        {
            var temp1 = first.next;
            var temp2 = second.next;
            first.next = second;
            second.next = temp1;
            first = temp1;
            second = temp2;
        }

        return;
    }

    private ListNode revList(ListNode head)
    {
        ListNode prev = null;

        var cur = head;

        while (cur != null)
        {
            var temp = cur.next;
            cur.next = prev;
            prev = cur;
            cur = temp;
        }

        return prev;
    }
}