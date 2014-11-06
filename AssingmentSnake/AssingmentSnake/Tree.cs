using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingmentSnake
{
    public class Tree
    {
        private TreeNode root;
        private Node[] gridMap;
        private List<int> checkPath;
        private int longestPath;
        public int pathsTried = 0; //temp
        public int nodesCovered = 0;

        public Tree(Node[] gridMap, int longestPath)
        {
            this.root = null;
            this.gridMap = gridMap;
            this.longestPath = longestPath;
            checkPath = new List<int>();
            GenerateTree(this.root);
        }

        private void GenerateTree(TreeNode node)
        {
            if (this.root == null)
            {
                this.root = new TreeNode(0);
                checkPath.Add(this.root.Value);
                GenerateTree(this.root);
            }
            if (node == null) return;
            if (pathsTried > 100000) return; //temp
            for (int i = 0; i < gridMap[node.Value].Edges.Count; i++)
            {
                TreeNode child = new TreeNode(gridMap[node.Value].Edges[i]);
                if (CheckNodeInPath(child.Value))
                {
                    checkPath.Add(child.Value);
                    GenerateTree(child);
                    node.Children.Add(child);
                }
                if (checkPath.Count == longestPath)
                {
                    return;
                }
                else
                {
                    UpdateCheckPath(node.Value);
                    if (nodesCovered < checkPath.Count)
                        nodesCovered = checkPath.Count;
                    pathsTried++;//temp
                }
            }
        }

        private void UpdateCheckPath(int value)
        {
            int tmp = checkPath.IndexOf(value);
            checkPath.RemoveRange((tmp + 1), ((checkPath.Count - tmp) - 1));
        }

        private bool CheckNodeInPath(int q)
        {
            bool ok = true;
            for (int i = 0; i < checkPath.Count; i++)
            {
                if (q == checkPath[i])
                {
                    ok = false;
                }
            }
            return ok;
        }

        public List<int> Search()
        {
            if (this.root == null) return null;
            return SearchPath(this.root);
        }

        private List<int> SearchPath(TreeNode node)
        {
            List<int> listToReturn = new List<int>();
            List<TreeNode> tmp = this.root.Depth;
            foreach (TreeNode item in tmp)
            {
                listToReturn.Add(item.Value);
            }
            return listToReturn;
        }
    }
}
