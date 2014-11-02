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
                path = openFileDialog1.FileName;
                if (!grid.ReadFromTextFile(path, out errorMessage))
                {
                    MessageBox.Show(errorMessage);
                }
            }
        }
    }
}
