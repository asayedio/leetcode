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
    public ListNode MiddleNode(ListNode head) {
        ListNode tempHead = head;
        int numOfNode = 0;

        while(tempHead != null){
            numOfNode++;
            tempHead = tempHead.next;
        }

        numOfNode = (numOfNode/2);

        while(numOfNode > 0){
            numOfNode--;
            head = head.next;
        }

        return head;
    }
}