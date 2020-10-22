using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace leetcode.Easy
{
    /// <summary>
    /// 104. Maximum Depth of Binary Tree
    /// https://leetcode.com/problems/maximum-depth-of-binary-tree/
    /// </summary>
    class MaximumDepthBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            var depth = 1;
            var left = 0;
            var right = 0;
            if (root.left != null)
                left += MaxDepth(root.left);
            if (root.right != null)
                right += MaxDepth(root.right);

            return left > right ? depth + left : depth + right;
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
}