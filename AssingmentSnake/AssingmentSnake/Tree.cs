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
        private bool[] values;

        public Tree(Node[] gridMap)
        {
            root = null;
            values = new bool[gridMap.Length];
            this.gridMap = gridMap;
            for (int i = 0; i < gridMap.Length; i++)
            {
                values[i] = true;
                if (!gridMap[i].CheckNode())
                {
                    values[i] = false;
                }
            }
        }

        private void GenerateTree(TreeNode node)
        {
            if (node == null)
            {
                this.root = new TreeNode(0);
                GenerateTree(this.root);
            }
            else
            {
                if ((gridMap[node.Value].Right >= 0) && values[gridMap[node.Value].Right])
                {
                    node.Right = new TreeNode(gridMap[node.Value].Right);
                    values[gridMap[node.Value].Right] = false;
                    GenerateTree(node.Right);
                }
                else if ((gridMap[node.Value].Left >= 0) && values[gridMap[node.Value].Left])
                {
                    node.Left = new TreeNode(gridMap[node.Value].Left);
                    values[gridMap[node.Value].Left] = false;
                    GenerateTree(node.Left);
                }
                else if ((gridMap[node.Value].Up >= 0) && values[gridMap[node.Value].Up])
                {
                    node.Up = new TreeNode(gridMap[node.Value].Up);
                    values[gridMap[node.Value].Up] = false;
                    GenerateTree(node.Up);
                }
                else if ((gridMap[node.Value].Down >= 0) && values[gridMap[node.Value].Down])
                {
                    node.Down = new TreeNode(gridMap[node.Value].Down);
                    values[gridMap[node.Value].Down] = false;
                    GenerateTree(node.Down);
                }
                else 
                { 

                }
            }
        }
    }
}
