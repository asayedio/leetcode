/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
     public Node Connect(Node root) {
        Traverse(root);
        return root;
    }
    
    private void Traverse(Node root)
    {
        if (root == null || (root.left == null && root.right == null)) { return; }
        
        Node nextNode = null;
        
        Node crnt = root.next;
        while (crnt != null && crnt.left == null && crnt.right == null) { crnt = crnt.next; }
       
        if (crnt != null)
        {
           nextNode = (crnt.left != null)? crnt.left: crnt.right; 
        }
        
        if (root.right != null)
        {
            root.right.next = nextNode;
            nextNode = root.right;
        }
        
        if (root.left != null)
        {
             root.left.next = nextNode;
        }
              
        Traverse(root.right);
        Traverse(root.left);
    }
}