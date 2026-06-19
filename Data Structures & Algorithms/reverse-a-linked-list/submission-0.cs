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
    public ListNode ReverseList(ListNode head) {
        
        if (head == null)
            return null;
            
        ListNode tail = head;
        ListNode newHead = head;
        while (head.next != null) {

            head = head.next;
            newHead = new ListNode(head.val, newHead);

        }

        tail.next = null;

        return newHead;

    }
}
