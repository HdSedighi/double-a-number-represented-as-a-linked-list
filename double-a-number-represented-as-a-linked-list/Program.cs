// Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    // Method to double each node's value and handle carry-over recursively
    private int DoubleNodeValues(ListNode head) {
        // Base case: if head is null, return 0
        if (head == null) {
            return 0;
        }
        
        // Calculate the doubled value of the current node plus carry from the next nodes
        int doubledValue = head.val * 2 + DoubleNodeValues(head.next);
        
        // Update the current node's value with the unit digit of the result
        head.val = doubledValue % 10;
        
        // Return the carry (tens digit of the result)
        return doubledValue / 10;
    }
    
    // Method to double the linked list and handle carry
    public ListNode DoubleLinkedList(ListNode head) {
        // Calculate carry from doubling the linked list
        int carry = DoubleNodeValues(head);
        
        // If there is carry left, insert a new node at the beginning with the carry value
        if (carry > 0) {
            head = new ListNode(carry, head);
        }
        
        // Return the updated head of the linked list
        return head;
    }
}
