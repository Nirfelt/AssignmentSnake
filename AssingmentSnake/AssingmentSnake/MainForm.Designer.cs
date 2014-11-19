namespace AssingmentSnake
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReadTxtFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txbDisplay = new System.Windows.Forms.RichTextBox();
            this.txbSolution = new System.Windows.Forms.RichTextBox();
            this.btnGetSolution = new System.Windows.Forms.Button();
            this.lblNodes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReadTxtFile
            // 
            this.btnReadTxtFile.Location = new System.Drawing.Point(400, 369);
            this.btnReadTxtFile.Name = "btnReadTxtFile";
            this.btnReadTxtFile.Size = new System.Drawing.Size(75, 23);
            this.btnReadTxtFile.TabIndex = 0;
            this.btnReadTxtFile.Text = "Läs in textfil";
            this.btnReadTxtFile.UseVisualStyleBackColor = true;
            this.btnReadTxtFile.Click += new System.EventHandler(this.btnReadTxtFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txbDisplay
            // 
            this.txbDisplay.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDisplay.Location = new System.Drawing.Point(12, 13);
            this.txbDisplay.Name = "txbDisplay";
            this.txbDisplay.ReadOnly = true;
            this.txbDisplay.Size = new System.Drawing.Size(380, 337);
            this.txbDisplay.TabIndex = 1;
            this.txbDisplay.Text = "";
            this.txbDisplay.WordWrap = false;
            // 
            // txbSolution
            // 
            this.txbSolution.Location = new System.Drawing.Point(400, 13);
            this.txbSolution.Name = "txbSolution";
            this.txbSolution.ReadOnly = true;
            this.txbSolution.Size = new System.Drawing.Size(75, 337);
            this.txbSolution.TabIndex = 2;
            this.txbSolution.Text = "";
            // 
            // btnGetSolution
            // 
            this.btnGetSolution.Location = new System.Drawing.Point(12, 369);
            this.btnGetSolution.Name = "btnGetSolution";
            this.btnGetSolution.Size = new System.Drawing.Size(75, 23);
            this.btnGetSolution.TabIndex = 3;
            this.btnGetSolution.Text = "Visa lösning";
            this.btnGetSolution.UseVisualStyleBackColor = true;
            this.btnGetSolution.Click += new System.EventHandler(this.btnGetSolution_Click);
            // 
            // lblNodes
            // 
            this.lblNodes.AutoSize = true;
            this.lblNodes.Location = new System.Drawing.Point(93, 374);
            this.lblNodes.Name = "lblNodes";
            this.lblNodes.Size = new System.Drawing.Size(24, 13);
            this.lblNodes.TabIndex = 4;
            this.lblNodes.Text = "0/0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 404);
            this.Controls.Add(this.lblNodes);
            this.Controls.Add(this.btnGetSolution);
            this.Controls.Add(this.txbSolution);
            this.Controls.Add(this.txbDisplay);
            this.Controls.Add(this.btnReadTxtFile);
            this.Name = "MainForm";
            this.Text = "Snake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadTxtFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox txbDisplay;
        private System.Windows.Forms.RichTextBox txbSolution;
        private System.Windows.Forms.Button btnGetSolution;
        private System.Windows.Forms.Label lblNodes;
    }
}

