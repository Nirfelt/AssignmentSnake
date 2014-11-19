using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AssingmentSnake
{
    public partial class MainForm : Form
    {
        private Grid grid;
        private Tree tree;
        private Timer timer;
        private List<int> path;
        private int timerCount = 0;

        public MainForm()
        {
            InitializeComponent();
            grid = new Grid();
            timer = new Timer();
            path = new List<int>();
            timer.Enabled = false;
            timer.Interval = 50;
            this.timer.Tick += new EventHandler(timer_Tick);
            btnGetSolution.Enabled = false;
        }

        private void btnReadTxtFile_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            string errorMessage = string.Empty;
            if (result == DialogResult.OK)
            {
                grid = new Grid();
                filePath = openFileDialog1.FileName;
                if (!grid.ReadFromTextFile(filePath, out errorMessage))
                {
                    MessageBox.Show(errorMessage);
                }
                grid.GenerateGrid();
                tree = new Tree(grid.GridMap, grid.IntFreeNodes);
                this.path = tree.Search();
                UpdateTxbDisplay();
                btnGetSolution.Enabled = true;
                lblNodes.Text = this.path.Count.ToString() + "/" + grid.IntFreeNodes.ToString();
                //MessageBox.Show(tree.PathsTried + " " + this.path.Count.ToString() + "/" + grid.IntFreeNodes.ToString());
            }
        }

        private void btnGetSolution_Click(object sender, EventArgs e)
        {
            UpdateTxbSolution(this.path);
            timer.Enabled = true;
            btnGetSolution.Enabled = false;
        }

        public void UpdateTxbDisplay()
        {
            string output = string.Empty;
            int index = 0;
            for (int i = 0; i < grid.Y; i++)
            {
                for (int c = 0; c < grid.X; c++)
                {
                    output += " " + grid.GetNodeString(index);
                    index++;
                }
                output += "\n";
            }
            txbDisplay.Text = output;
        }

        public void UpdateTxbSolution(List<int> tmp)
        {
            string output = string.Empty;
            for (int i = 0; i < tmp.Count; i++)
            {
                output += grid.GridMap[tmp[i]].ToStringXY + "\n";
            }
            txbSolution.Text = output;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timerCount < path.Count)
            {
                grid.GridMap[path[timerCount]].Visited = true;
                UpdateTxbDisplay();
                timerCount++;
            }
            else 
            {
                timer.Enabled = false;
                timerCount = 0;
            }
        }
    }
}
