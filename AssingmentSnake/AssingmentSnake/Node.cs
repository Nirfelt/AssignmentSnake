using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingmentSnake
{
    public class Node
    {
        private bool visited, obstacle;
        private int x, y, up = -1, down = -1, left = -1, right = -1;

        public Node(int x, int y, bool obstacle = false)
        {
            X = x;
            Y = y;
            Obstacle = obstacle;
            Visited = false;
        }

        public int Up
        {
            get { return up; }
            set { up = value; }
        }

        public int Down
        {
            get { return down; }
            set { down = value; }
        }

        public int Left
        {
            get { return left; }
            set { left = value; }
        }

        public int Right
        {
            get { return right; }
            set { right = value; }
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
        
        public override string ToString()
        {
            if (obstacle)
            {
                return "X";
            }
            else if (visited)
            {
                return "¤";
            }
            else
            {
                return "O";
            }
        }

        public bool CheckNode()
        {
            if (obstacle || visited)
            {
                return false;
            }
            return true;
        }
    }
}
