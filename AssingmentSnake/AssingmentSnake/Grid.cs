using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingmentSnake
{
    public partial class Grid
    {
        private Node[] grid;
        private List<int> xValueObst;
        private List<int> yValueObst;
        private int x, y, numberOfObstacles;

        public Grid()
        {
            xValueObst = new List<int>();
            yValueObst = new List<int>();
        }

        public void GenerateGrid()
        {
            int counter = 0;
            int indexer = 0;
            grid = new Node[X*Y];
            for (int i = 0; i < Y; i++)
            {
                for (int c = 0; c < X; c++)
                {
                    if ((xValueObst[counter] == c) && (yValueObst[counter] == i))
                    {
                        grid[indexer] = new Node(c, i, true);
                        if (counter < numberOfObstacles - 1)
                        {
                            counter++;
                            //System.Windows.Forms.MessageBox.Show(indexer.ToString());
                        }
                    }
                    else
                    {
                        grid[indexer] = new Node(c, i);
                        if ((indexer + 1) < (i+1)*X) grid[indexer].Right = indexer + 1;
                        if ((indexer - 1) > (i*X)-1) grid[indexer].Left = indexer - 1;
                        if ((indexer + X) < (X*Y)) grid[indexer].Down = indexer + X;
                        if ((indexer - X) >= 0) grid[indexer].Up = indexer - X;
                    }
                    indexer++;
                }
            }
            //System.Windows.Forms.MessageBox.Show("Right: " + grid[14].Right.ToString() + " Left: " + grid[14].Left.ToString() + " Up: " + grid[14].Up.ToString() + " Down: " + grid[14].Down.ToString());
        }

        public List<int[]> SearchPath()
        {
            int[] pathCord = new int[2];
            List<int[]> path= new List<int[]>();


            return path;
        }

        public string GetNodeString(int index)
        {
            return grid[index].ToString();
        }

        public bool CheckNode(int index)
        {
            return (grid[index].CheckNode());            
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int NumberOfObstacles
        {
            get { return numberOfObstacles; }
            set { numberOfObstacles = value; }
        }

        public List<int> XValueObst
        {
            get { return xValueObst; }
            set { xValueObst = value; }
        }

        public List<int> YValueObst
        {
            get { return yValueObst; }
            set { yValueObst = value; }
        }

        public Node[] GridMap
        {
            get { return grid; }
            set { grid = value; }
        }
    }
}
