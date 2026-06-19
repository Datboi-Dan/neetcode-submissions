/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public TreeNode InvertTree(TreeNode root) 
    {

        TreeNode curr;
        Stack<TreeNode> stack = new Stack<TreeNode>(new TreeNode[] {root});

        while (stack.Count > 0 && stack.Peek() != null)
        {
            
            curr = stack.Pop();
            if (curr.left != null)
                stack.Push(curr.left);
            if (curr.right != null)
                stack.Push(curr.right);
            TreeNode temp = curr.left;
            curr.left = curr.right;
            curr.right = temp;

        }
        
        return root;
        
    }
}
