var solution = new Solution();
var root = new TreeNode(1);
root.left = new TreeNode(2);
root.right = new TreeNode(3);
root.left.left = new TreeNode(4);
root.left.right = new TreeNode(5);

root.right.left = new TreeNode(6);

Console.WriteLine(solution.MaxProduct(root));
//    1
// 2    3
//4 5  6
// (2+4+5)*(1+3+6) = 110

// https://leetcode.com/problems/maximum-product-of-splitted-binary-tree/
public class Solution
{
    public int MaxProduct(TreeNode root)
    {
        var weights = new Dictionary<TreeNode, long>();
        var rootWeight = CalcWeights(root, weights);
        long m = 1000000007;
        long max = default;
        foreach (var item in weights)
        {
            //Console.WriteLine($"node:{item.Key.val}, weight:{item.Value}");
            max = Math.Max(item.Value * (rootWeight - item.Value),max);
            //Console.WriteLine($"\tproduct:{productWeight}");
        }
        return (int)(max % m);
    }

    private long CalcWeights(TreeNode node, Dictionary<TreeNode, long> weights){
        if(node==null){
            return 0;
        }
        var weight = node.val+CalcWeights(node.left, weights)+CalcWeights(node.right,weights);
        weights.Add(node, weight);
        return weight;
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
