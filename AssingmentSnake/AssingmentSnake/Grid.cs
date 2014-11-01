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
        private int[,] obstacles;
        private int x, y, numberOfObstacles;

        public Grid()
        {
            grid = new Node[X, Y];
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
    }
}
