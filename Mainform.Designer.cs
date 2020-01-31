namespace GameSetup
{
    partial class Mainform
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
            this.gameLevelChoice = new System.Windows.Forms.ComboBox();
            this.gameLevellabel = new System.Windows.Forms.Label();
            this.playerNamelabel = new System.Windows.Forms.Label();
            this.playernameTextbox = new System.Windows.Forms.TextBox();
            this.standBtn = new System.Windows.Forms.Button();
            this.doubleBtn = new System.Windows.Forms.Button();
            this.newGame = new System.Windows.Forms.Button();
            this.highscoreBtn = new System.Windows.Forms.Button();
            this.middlelabelbox = new System.Windows.Forms.Label();
            this.startGame = new System.Windows.Forms.Button();
            this.chipContainer = new System.Windows.Forms.Label();
            this.dealertest = new System.Windows.Forms.Label();
            this.lowerBetamount = new System.Windows.Forms.Button();
            this.raiseBetamount = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.betContainer = new System.Windows.Forms.Label();
            this.findWinner = new System.Windows.Forms.Button();
            this.dealerHandsum = new System.Windows.Forms.Label();
            this.cardTablePicturebox = new System.Windows.Forms.PictureBox();
            this.deckstate = new System.Windows.Forms.Label();
            this.surrenderBtn = new System.Windows.Forms.Button();
            this.hitBtn = new System.Windows.Forms.Button();
            this.abortGame = new System.Windows.Forms.Button();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardTablePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLevelChoice
            // 
            this.gameLevelChoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameLevelChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLevelChoice.FormattingEnabled = true;
            this.gameLevelChoice.Items.AddRange(new object[] {
            "PLATINUM",
            "GOLD",
            "SILVER",
            "BRONZE"});
            this.gameLevelChoice.Location = new System.Drawing.Point(3, 53);
            this.gameLevelChoice.Name = "gameLevelChoice";
            this.gameLevelChoice.Size = new System.Drawing.Size(155, 28);
            this.gameLevelChoice.TabIndex = 15;
            this.gameLevelChoice.SelectedIndexChanged += new System.EventHandler(this.gameLevelChoice_SelectedIndexChanged);
            // 
            // gameLevellabel
            // 
            this.gameLevellabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameLevellabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.gameLevellabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLevellabel.Location = new System.Drawing.Point(3, 24);
            this.gameLevellabel.Name = "gameLevellabel";
            this.gameLevellabel.Padding = new System.Windows.Forms.Padding(3);
            this.gameLevellabel.Size = new System.Drawing.Size(155, 26);
            this.gameLevellabel.TabIndex = 16;
            this.gameLevellabel.Text = "Select difficulty";
            this.gameLevellabel.Click += new System.EventHandler(this.gameLevellabel_Click);
            // 
            // playerNamelabel
            // 
            this.playerNamelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerNamelabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.playerNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNamelabel.Location = new System.Drawing.Point(4, 119);
            this.playerNamelabel.Margin = new System.Windows.Forms.Padding(3);
            this.playerNamelabel.Name = "playerNamelabel";
            this.playerNamelabel.Padding = new System.Windows.Forms.Padding(3);
            this.playerNamelabel.Size = new System.Drawing.Size(155, 26);
            this.playerNamelabel.TabIndex = 17;
            this.playerNamelabel.Text = "Enter your name";
            this.playerNamelabel.Click += new System.EventHandler(this.playerNamelabel_Click);
            // 
            // playernameTextbox
            // 
            this.playernameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playernameTextbox.Location = new System.Drawing.Point(4, 148);
            this.playernameTextbox.Name = "playernameTextbox";
            this.playernameTextbox.Size = new System.Drawing.Size(155, 26);
            this.playernameTextbox.TabIndex = 18;
            this.playernameTextbox.TextChanged += new System.EventHandler(this.playernameTextbox_TextChanged);
            // 
            // standBtn
            // 
            this.standBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.standBtn.BackColor = System.Drawing.Color.Silver;
            this.standBtn.Enabled = false;
            this.standBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standBtn.ForeColor = System.Drawing.Color.Black;
            this.standBtn.Location = new System.Drawing.Point(1029, 658);
            this.standBtn.Name = "standBtn";
            this.standBtn.Size = new System.Drawing.Size(91, 122);
            this.standBtn.TabIndex = 10;
            this.standBtn.Text = "Stand";
            this.standBtn.UseVisualStyleBackColor = false;
            this.standBtn.Click += new System.EventHandler(this.standBtn_Click);
            // 
            // doubleBtn
            // 
            this.doubleBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doubleBtn.BackColor = System.Drawing.Color.Silver;
            this.doubleBtn.Enabled = false;
            this.doubleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubleBtn.ForeColor = System.Drawing.Color.Black;
            this.doubleBtn.Location = new System.Drawing.Point(834, 720);
            this.doubleBtn.Name = "doubleBtn";
            this.doubleBtn.Size = new System.Drawing.Size(189, 60);
            this.doubleBtn.TabIndex = 9;
            this.doubleBtn.Text = "Double Down";
            this.doubleBtn.UseVisualStyleBackColor = false;
            this.doubleBtn.Click += new System.EventHandler(this.doubleBtn_Click);
            // 
            // newGame
            // 
            this.newGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newGame.BackColor = System.Drawing.Color.Silver;
            this.newGame.Enabled = false;
            this.newGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame.ForeColor = System.Drawing.Color.Black;
            this.newGame.Location = new System.Drawing.Point(191, 658);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(158, 122);
            this.newGame.TabIndex = 6;
            this.newGame.Text = "Let\'s Go!";
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // highscoreBtn
            // 
            this.highscoreBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.highscoreBtn.BackColor = System.Drawing.Color.Transparent;
            this.highscoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreBtn.ForeColor = System.Drawing.Color.Black;
            this.highscoreBtn.Location = new System.Drawing.Point(21, 23);
            this.highscoreBtn.Name = "highscoreBtn";
            this.highscoreBtn.Size = new System.Drawing.Size(155, 88);
            this.highscoreBtn.TabIndex = 5;
            this.highscoreBtn.Text = "High Rollers\r\n";
            this.highscoreBtn.UseVisualStyleBackColor = false;
            this.highscoreBtn.Click += new System.EventHandler(this.highscoreBtn_Click);
            // 
            // middlelabelbox
            // 
            this.middlelabelbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.middlelabelbox.BackColor = System.Drawing.Color.Transparent;
            this.middlelabelbox.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middlelabelbox.Location = new System.Drawing.Point(150, 480);
            this.middlelabelbox.Name = "middlelabelbox";
            this.middlelabelbox.Padding = new System.Windows.Forms.Padding(5);
            this.middlelabelbox.Size = new System.Drawing.Size(117, 53);
            this.middlelabelbox.TabIndex = 19;
            this.middlelabelbox.Visible = false;
            this.middlelabelbox.Click += new System.EventHandler(this.middlelabelbox_Click);
            // 
            // startGame
            // 
            this.startGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startGame.BackColor = System.Drawing.Color.Silver;
            this.startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Location = new System.Drawing.Point(0, 409);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(158, 89);
            this.startGame.TabIndex = 20;
            this.startGame.Text = "Deal me in!";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // chipContainer
            // 
            this.chipContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chipContainer.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipContainer.Location = new System.Drawing.Point(578, 658);
            this.chipContainer.Name = "chipContainer";
            this.chipContainer.Size = new System.Drawing.Size(250, 122);
            this.chipContainer.TabIndex = 21;
            this.chipContainer.Text = "CHIPS:";
            this.chipContainer.Click += new System.EventHandler(this.chipTotallabel_Click);
            // 
            // dealertest
            // 
            this.dealertest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dealertest.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealertest.Location = new System.Drawing.Point(20, 658);
            this.dealertest.Name = "dealertest";
            this.dealertest.Size = new System.Drawing.Size(158, 122);
            this.dealertest.TabIndex = 22;
            this.dealertest.Text = " ";
            this.dealertest.Click += new System.EventHandler(this.dealertest_Click);
            // 
            // lowerBetamount
            // 
            this.lowerBetamount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lowerBetamount.Enabled = false;
            this.lowerBetamount.Location = new System.Drawing.Point(365, 757);
            this.lowerBetamount.Name = "lowerBetamount";
            this.lowerBetamount.Size = new System.Drawing.Size(87, 23);
            this.lowerBetamount.TabIndex = 23;
            this.lowerBetamount.Text = "Lower";
            this.lowerBetamount.UseVisualStyleBackColor = true;
            this.lowerBetamount.Click += new System.EventHandler(this.lowerBetamount_Click);
            // 
            // raiseBetamount
            // 
            this.raiseBetamount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.raiseBetamount.Enabled = false;
            this.raiseBetamount.Location = new System.Drawing.Point(458, 757);
            this.raiseBetamount.Name = "raiseBetamount";
            this.raiseBetamount.Size = new System.Drawing.Size(92, 23);
            this.raiseBetamount.TabIndex = 24;
            this.raiseBetamount.Text = "Raise";
            this.raiseBetamount.UseVisualStyleBackColor = true;
            this.raiseBetamount.Click += new System.EventHandler(this.raiseBetamount_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sidePanel.Controls.Add(this.startGame);
            this.sidePanel.Controls.Add(this.gameLevellabel);
            this.sidePanel.Controls.Add(this.playernameTextbox);
            this.sidePanel.Controls.Add(this.gameLevelChoice);
            this.sidePanel.Controls.Add(this.playerNamelabel);
            this.sidePanel.Location = new System.Drawing.Point(21, 117);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(158, 536);
            this.sidePanel.TabIndex = 25;
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidePanel_Paint);
            // 
            // betContainer
            // 
            this.betContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.betContainer.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betContainer.Location = new System.Drawing.Point(365, 659);
            this.betContainer.Name = "betContainer";
            this.betContainer.Size = new System.Drawing.Size(185, 95);
            this.betContainer.TabIndex = 26;
            this.betContainer.Click += new System.EventHandler(this.betContainer_Click);
            // 
            // findWinner
            // 
            this.findWinner.Location = new System.Drawing.Point(1344, 659);
            this.findWinner.Name = "findWinner";
            this.findWinner.Size = new System.Drawing.Size(75, 23);
            this.findWinner.TabIndex = 28;
            this.findWinner.Text = "button1";
            this.findWinner.UseVisualStyleBackColor = true;
            this.findWinner.Visible = false;
            this.findWinner.Click += new System.EventHandler(this.findWinner_Click);
            // 
            // dealerHandsum
            // 
            this.dealerHandsum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dealerHandsum.BackColor = System.Drawing.Color.Transparent;
            this.dealerHandsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerHandsum.Location = new System.Drawing.Point(1098, 480);
            this.dealerHandsum.Name = "dealerHandsum";
            this.dealerHandsum.Size = new System.Drawing.Size(117, 53);
            this.dealerHandsum.TabIndex = 23;
            this.dealerHandsum.Visible = false;
            // 
            // cardTablePicturebox
            // 
            this.cardTablePicturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardTablePicturebox.BackColor = System.Drawing.Color.DarkGreen;
            this.cardTablePicturebox.Enabled = false;
            this.cardTablePicturebox.Location = new System.Drawing.Point(-5, -9);
            this.cardTablePicturebox.Name = "cardTablePicturebox";
            this.cardTablePicturebox.Size = new System.Drawing.Size(1808, 1039);
            this.cardTablePicturebox.TabIndex = 3;
            this.cardTablePicturebox.TabStop = false;
            this.cardTablePicturebox.Click += new System.EventHandler(this.cardTablePicturebox_Click);
            // 
            // deckstate
            // 
            this.deckstate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deckstate.AutoSize = true;
            this.deckstate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deckstate.Location = new System.Drawing.Point(1224, 575);
            this.deckstate.Name = "deckstate";
            this.deckstate.Size = new System.Drawing.Size(195, 40);
            this.deckstate.TabIndex = 29;
            this.deckstate.Text = "deck state";
            this.deckstate.Click += new System.EventHandler(this.deckstate_Click);
            // 
            // surrenderBtn
            // 
            this.surrenderBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.surrenderBtn.Enabled = false;
            this.surrenderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surrenderBtn.Location = new System.Drawing.Point(1126, 657);
            this.surrenderBtn.Name = "surrenderBtn";
            this.surrenderBtn.Size = new System.Drawing.Size(89, 123);
            this.surrenderBtn.TabIndex = 30;
            this.surrenderBtn.Text = "Give up!";
            this.surrenderBtn.UseVisualStyleBackColor = true;
            this.surrenderBtn.Click += new System.EventHandler(this.surrenderBtn_Click);
            // 
            // hitBtn
            // 
            this.hitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hitBtn.BackColor = System.Drawing.Color.Silver;
            this.hitBtn.Enabled = false;
            this.hitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitBtn.ForeColor = System.Drawing.Color.Black;
            this.hitBtn.Location = new System.Drawing.Point(834, 658);
            this.hitBtn.Name = "hitBtn";
            this.hitBtn.Size = new System.Drawing.Size(189, 56);
            this.hitBtn.TabIndex = 7;
            this.hitBtn.Text = "Hit";
            this.hitBtn.UseVisualStyleBackColor = false;
            this.hitBtn.Click += new System.EventHandler(this.hitBtn_Click);
            // 
            // abortGame
            // 
            this.abortGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.abortGame.Enabled = false;
            this.abortGame.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abortGame.Location = new System.Drawing.Point(1243, 701);
            this.abortGame.Name = "abortGame";
            this.abortGame.Size = new System.Drawing.Size(126, 79);
            this.abortGame.TabIndex = 31;
            this.abortGame.Text = "Stop Game";
            this.abortGame.UseVisualStyleBackColor = true;
            this.abortGame.Click += new System.EventHandler(this.abortGame_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1431, 811);
            this.Controls.Add(this.abortGame);
            this.Controls.Add(this.surrenderBtn);
            this.Controls.Add(this.deckstate);
            this.Controls.Add(this.dealertest);
            this.Controls.Add(this.dealerHandsum);
            this.Controls.Add(this.findWinner);
            this.Controls.Add(this.middlelabelbox);
            this.Controls.Add(this.betContainer);
            this.Controls.Add(this.raiseBetamount);
            this.Controls.Add(this.lowerBetamount);
            this.Controls.Add(this.chipContainer);
            this.Controls.Add(this.standBtn);
            this.Controls.Add(this.doubleBtn);
            this.Controls.Add(this.hitBtn);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.highscoreBtn);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.cardTablePicturebox);
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardTablePicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox cardTablePicturebox;
        private System.Windows.Forms.Button highscoreBtn;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button doubleBtn;
        private System.Windows.Forms.Button standBtn;
        private System.Windows.Forms.ComboBox gameLevelChoice;
        private System.Windows.Forms.Label gameLevellabel;
        private System.Windows.Forms.Label playerNamelabel;
        private System.Windows.Forms.TextBox playernameTextbox;
        private System.Windows.Forms.Label middlelabelbox;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Label chipContainer;
        private System.Windows.Forms.Label dealertest;
        private System.Windows.Forms.Button lowerBetamount;
        private System.Windows.Forms.Button raiseBetamount;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label betContainer;
        private System.Windows.Forms.Button findWinner;
        private System.Windows.Forms.Label dealerHandsum;
        private System.Windows.Forms.Label deckstate;
        private System.Windows.Forms.Button surrenderBtn;
        private System.Windows.Forms.Button hitBtn;
        private System.Windows.Forms.Button abortGame;
    }
}

