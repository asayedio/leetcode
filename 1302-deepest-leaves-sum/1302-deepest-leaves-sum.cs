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
    public int DeepestLeavesSum(TreeNode root) {
        var queue = new Queue<(TreeNode node, int level)>();
			queue.Enqueue((root,0));
			var levelSum = new Dictionary<int, int>();
			var highestLevel = 0;

			while (queue.Count > 0)
			{
				var n = queue.Dequeue();
				if (n.node.left != null)
					queue.Enqueue((n.node.left, n.level + 1));
				if (n.node.right != null)
					queue.Enqueue((n.node.right, n.level + 1));

				if (n.level > highestLevel)
					highestLevel = n.level;

				if (levelSum.ContainsKey(n.level))
					levelSum[n.level] += n.node.val;
				else
					levelSum[n.level] = n.node.val;

			}


			return levelSum[highestLevel];
    }
}