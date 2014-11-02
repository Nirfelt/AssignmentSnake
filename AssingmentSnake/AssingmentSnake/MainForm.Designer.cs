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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 404);
            this.Controls.Add(this.btnReadTxtFile);
            this.Name = "MainForm";
            this.Text = "Snake";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadTxtFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

