namespace GameSetup
{
    partial class highscores
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
            this.scoresToplabel = new System.Windows.Forms.Label();
            this.dataGridTest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTest)).BeginInit();
            this.SuspendLayout();
            // 
            // scoresToplabel
            // 
            this.scoresToplabel.AutoSize = true;
            this.scoresToplabel.BackColor = System.Drawing.Color.Gray;
            this.scoresToplabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoresToplabel.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresToplabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoresToplabel.Location = new System.Drawing.Point(25, 22);
            this.scoresToplabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoresToplabel.Name = "scoresToplabel";
            this.scoresToplabel.Size = new System.Drawing.Size(463, 59);
            this.scoresToplabel.TabIndex = 0;
            this.scoresToplabel.Text = "HIGH ROLLERS";
            this.scoresToplabel.Click += new System.EventHandler(this.scoresToplabel_Click);
            // 
            // dataGridTest
            // 
            this.dataGridTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTest.Location = new System.Drawing.Point(49, 124);
            this.dataGridTest.Name = "dataGridTest";
            this.dataGridTest.Size = new System.Drawing.Size(791, 505);
            this.dataGridTest.TabIndex = 2;
            // 
            // highscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(889, 666);
            this.Controls.Add(this.dataGridTest);
            this.Controls.Add(this.scoresToplabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "highscores";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.highscores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoresToplabel;
        private System.Windows.Forms.DataGridView dataGridTest;
    }
}