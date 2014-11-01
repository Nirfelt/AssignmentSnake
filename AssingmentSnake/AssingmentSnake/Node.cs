using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingmentSnake
{
    public class Node
    {
        private int x, y;
        private bool visited, obstacle;

        public Node(int x, int y, bool obstacle = false)
        {
            this.x = x;
            this.y = y;
            Obstacle = obstacle;
        }

        public int Y
        {
            get { return y; }
        }

        public int X
        {
            get { return x; }
        }

        public bool Visited
        {
            get { return visited; }
            set { visited = value; }
        }

        public bool Obstacle
        {
            get { return obstacle; }
            set { obstacle = value; }
        }

    }
}
