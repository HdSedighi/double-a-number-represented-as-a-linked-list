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
    public ListNode DoubleLinkedList(ListNode head) {
        // Initialize the current node as the head and carry as 0
        ListNode current = head;
        int carry = 0;
        
        // Iterate through the list
        while (current != null) {
            // Double the value of the current node and add the carry from the previous iteration
            int newVal = current.val * 2 + carry;
            
            // Calculate the new value of the current node and the carry for the next iteration
            current.val = newVal % 10;
            carry = newVal / 10;
            
            // Move to the next node
            if (current.next == null && carry > 0) {
                // If we reach the end of the list and there is still a carry, add a new node
                current.next = new ListNode(carry);
                carry = 0; // Reset carry since it is now added to the list
            }
            
            // Move to the next node
            current = current.next;
        }
        
        // Return the head of the list
        return head;
    }
}
