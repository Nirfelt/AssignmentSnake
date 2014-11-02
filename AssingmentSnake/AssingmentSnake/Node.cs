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

        public Node(bool obstacle = false)
        {
            Obstacle = obstacle;
            Visited = false;
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
    }
}
