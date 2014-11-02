using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingmentSnake
{
    public partial class Grid
    {
        private Node[,] grid;
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
            grid = new Node[X, Y];
            for (int i = 0; i < Y; i++)
            {
                for (int c = 0; c < X; c++)
                {
                    if ((xValueObst[counter] == c) && (yValueObst[counter] == i))
                    {
                        grid[c, i] = new Node(true);
                        if (counter < numberOfObstacles - 1)
                        {
                            counter++;
                        }
                    }
                    else
                    {
                        grid[c, i] = new Node();
                    }
                    //System.Windows.Forms.MessageBox.Show(xValueObst.IndexOf(counter).ToString() + ", " + yValueObst.IndexOf(counter).ToString());
                }
            }
        }

        public string GetNodeString(int x, int y)
        {
            return grid[y, x].ToString();
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
    }
}
