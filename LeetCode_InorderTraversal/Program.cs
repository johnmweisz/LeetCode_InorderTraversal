using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_InorderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }

    public class Solution
    {
        /*public IList<int> InorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            if (root != null) helper(root, list);
            return list;
        }
        private void helper(TreeNode node, List<int> list)
        {
            if (node == null) return;
            if (node.left != null)
            {
                helper(node.left, list);
            }
            list.Add(node.val);
            if (node.right != null)
            {
                helper(node.right, list);
            }
        }*/

        public IList<int> InorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            var stack = new Stack<TreeNode>();
            var runner = root;
            while (runner != null || stack.Count != 0)
            {
                while (runner != null)
                {
                    stack.Push(runner);
                    runner = runner.left;
                }

                runner = stack.Pop();
                list.Add(runner.val);
                runner = runner.right;
            }

            return list;
        }

    }
}
