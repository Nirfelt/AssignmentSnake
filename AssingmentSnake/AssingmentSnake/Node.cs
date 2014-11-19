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
        private int x, y;
        private List<int> edges;

        public Node(bool obstacle = false)
        {
            Obstacle = obstacle;
            Visited = false;
            edges = new List<int>();
        }

        public Node(int x, int y, bool obstacle = false)
        {
            X = x;
            Y = y;
            Obstacle = obstacle;
            Visited = false;
            edges = new List<int>();
        }

        public List<int> Edges
        {
            get { return edges; }
            set { edges = value; }
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

        public string ToStringXY
        {
            get { return X + ", " + Y; }
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
