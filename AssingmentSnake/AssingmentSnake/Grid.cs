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
                    if ((xValueObst.Count > 0) && (yValueObst.Count > 0))
                    {
                        if ((xValueObst[counter] == c) && (yValueObst[counter] == i))
                        {
                            //grid[indexer] = new Node(c, i, true);
                            CreateNode(indexer, c, i, true);
                            if (counter < numberOfObstacles - 1)
                            {
                                counter++;
                                //System.Windows.Forms.MessageBox.Show(indexer.ToString());
                            }
                        }
                        else
                        {
                            //grid[indexer].X = c;
                            //grid[indexer].Y = i;
                            CreateNode(indexer, c, i);
                            //grid[indexer] = new Node(c, i);
                            //if ((indexer - X) >= 0) grid[indexer].Edges.Add(indexer - X);//Up
                            //if ((indexer + 1) < (i + 1) * X) grid[indexer].Edges.Add(indexer + 1);//Right
                            //if ((indexer - 1) > (i * X) - 1) grid[indexer].Edges.Add(indexer - 1);//Left
                            //if ((indexer + X) < (X * Y)) grid[indexer].Edges.Add(indexer + X);//Down
                        }
                    }
                    else
                    {
                        //grid[indexer].X = c;
                        //grid[indexer].Y = i;
                        CreateNode(indexer, c, i);
                        //grid[indexer] = new Node(c, i);
                        //if ((indexer - X) >= 0) grid[indexer].Edges.Add(indexer - X);//Up
                        //if ((indexer + 1) < (i+1)*X) grid[indexer].Edges.Add(indexer + 1);//Right
                        //if ((indexer - 1) > (i*X)-1) grid[indexer].Edges.Add(indexer - 1);//Left
                        //if ((indexer + X) < (X*Y)) grid[indexer].Edges.Add(indexer + X);//Down
                    }
                    indexer++;
                }
            }
        }

        private void CreateNode(int index, int x, int y, bool obst = false)
        {
            if (obst)
            {
                grid[index] = new Node(x, y, true);
            }
            else 
            {
                grid[index] = new Node(x, y);
                if ((index - X) >= 0) grid[index].Edges.Add(index - X);//Up
                if ((index + 1) < (y + 1) * X) grid[index].Edges.Add(index + 1);//Right
                if ((index - 1) > (y * X) - 1) grid[index].Edges.Add(index - 1);//Left
                if ((index + X) < (X * Y)) grid[index].Edges.Add(index + X);//Down
            }
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

        public int IntFreeNodes
        {
            get { return (X*Y)-NumberOfObstacles; }
        }
    }
}
