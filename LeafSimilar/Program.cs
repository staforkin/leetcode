var solution = new Solution();
var root1 = new TreeNode(1);
root1.left = new TreeNode(2);
root1.right = new TreeNode(3);
var root2 = new TreeNode(1);
root2.left = new TreeNode(3);
root2.right = new TreeNode(2);
Console.WriteLine(solution.LeafSimilar(root1, root2));

// https://leetcode.com/problems/leaf-similar-trees
public class Solution {
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        var arr1 = new List<int>();
        var arr2 = new List<int>();
        Helper(root1, arr1);
        Helper(root2, arr2);
        return arr1.SequenceEqual(arr2);
    }

    private void Helper(TreeNode root, List<int> arr){
        if(root==null){
            return;
        }
        Helper(root.left, arr);
        Helper(root.right, arr);
        if(root.left == null && root.right==null){
            arr.Add(root.val);
        }
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}