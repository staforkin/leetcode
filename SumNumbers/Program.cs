var solution = new Solution();
var root = new TreeNode(1);
root.left = new TreeNode(2);
root.right = new TreeNode(3);
Console.WriteLine(solution.SumNumbers(root));

// https://leetcode.com/problems/sum-root-to-leaf-numbers/
public class Solution {
    public int SumNumbers(TreeNode root) {
        
    }
}

public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }