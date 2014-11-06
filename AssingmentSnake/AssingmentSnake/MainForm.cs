using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssingmentSnake
{
    public partial class MainForm : Form
    {
        private Grid grid;
        private Tree tree;

        public MainForm()
        {
            InitializeComponent();
            grid = new Grid();
        }

        private void btnReadTxtFile_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            string errorMessage = string.Empty;
            if (result == DialogResult.OK)
            {
                grid = new Grid();
                path = openFileDialog1.FileName;
                if (!grid.ReadFromTextFile(path, out errorMessage))
                {
                    MessageBox.Show(errorMessage);
                }
                grid.GenerateGrid();
                UpdateTxbDisplay();
                tree = new Tree(grid.GridMap, grid.IntFreeNodes);
                //MessageBox.Show(tree.pathsTried.ToString() + " " + tree.nodesCovered.ToString() + "/" + grid.IntFreeNodes.ToString());
            }
        }

        private void btnGetSolution_Click(object sender, EventArgs e)
        {
            List<int> tmp = tree.Search();
            //for (int i = 0; i < tmp.Count; i++)
            //{
            //    MessageBox.Show(tmp[i].ToString());
            //}
            //MessageBox.Show(tmp.Count.ToString());
            MessageBox.Show(tree.pathsTried.ToString() + " " + tmp.Count.ToString() + "/" + grid.IntFreeNodes.ToString());
        }

        public void UpdateTxbDisplay()
        {
            string output = null;
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
    }
}
