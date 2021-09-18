/*
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.
*/


public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int x = 0;
        int y = 0;
        int z = 1;

        while(l1 != null){
            x += z*l1.val;
            z*=10;
            l1 = l1.next;
        }

        z = 1;
        while(l2 != null){
            y += z*l2.val;
            z*=10;
            l2 = l2.next;
        }

        int sum = x + y;
        if (sum == 0) {
            return new ListNode(0);
        }

        ListNode node = null, head = null;
        while(sum > 0){
            int digit = sum % 10;
            ListNode n = new ListNode(digit);
            if (node == null) {
                head = node = n;
            } else {
                node.next = n;
                node = node.next;
            }
            
            sum = sum / 10;
        }

        return head;
    }
}