var solution = new Solution();
var tree = solution.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 , 10 });
//var tree = new TreeNode(0, new TreeNode(-10), new TreeNode(5, new TreeNode(4)));
Print(tree);

void Print(TreeNode node)
{
    if (node.left != null)
    {
        Print(node.left);
    }
    Console.WriteLine(node.val);
    if (node.right != null)
    {
        Print(node.right);
    }
    return;
}

//https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree
public class Solution
{
    // [-10,-3,0,5,9] L = 5
    // middle index is L/2 = 2
    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums.Length == 0)
        {
            return null;
        }
        var root = Build(nums, 0, nums.Length-1);
        return root;
    }

    public TreeNode Build(int[] nums, int low, int high){
        if(low>high){
            return null;
        }
        int mid = (low + high)/2;
        var node = new TreeNode(nums[mid]);
        node.left = Build(nums, low, mid-1);
        node.right = Build(nums, mid+1, high);
        return node;
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