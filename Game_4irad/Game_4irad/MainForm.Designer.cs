namespace Game_4irad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GamePanel = new System.Windows.Forms.Panel();
            this.pawn_bot = new System.Windows.Forms.PictureBox();
            this.pawn_top = new System.Windows.Forms.PictureBox();
            this.txt_player_name = new System.Windows.Forms.TextBox();
            this.Opponent_lable = new System.Windows.Forms.Label();
            this.Game_titel = new System.Windows.Forms.Label();
            this.Info_Lable = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.challengeRandomPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.list_games = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelGameTime = new System.Windows.Forms.Label();
            this.turnInicator2 = new System.Windows.Forms.PictureBox();
            this.LableYou = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.turnInicator1 = new System.Windows.Forms.PictureBox();
            this.list_history = new System.Windows.Forms.ListView();
            this.lableFun = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lableChangeTime = new System.Windows.Forms.Label();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pawn_bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawn_top)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnInicator2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnInicator1)).BeginInit();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Blue;
            this.GamePanel.Controls.Add(this.pawn_bot);
            this.GamePanel.Controls.Add(this.pawn_top);
            this.GamePanel.Location = new System.Drawing.Point(55, 107);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(529, 430);
            this.GamePanel.TabIndex = 0;
            // 
            // pawn_bot
            // 
            this.pawn_bot.BackColor = System.Drawing.Color.Blue;
            this.pawn_bot.Image = ((System.Drawing.Image)(resources.GetObject("pawn_bot.Image")));
            this.pawn_bot.InitialImage = null;
            this.pawn_bot.Location = new System.Drawing.Point(452, 348);
            this.pawn_bot.Margin = new System.Windows.Forms.Padding(4);
            this.pawn_bot.Name = "pawn_bot";
            this.pawn_bot.Size = new System.Drawing.Size(67, 62);
            this.pawn_bot.TabIndex = 41;
            this.pawn_bot.TabStop = false;
            this.pawn_bot.Visible = false;
            // 
            // pawn_top
            // 
            this.pawn_top.BackColor = System.Drawing.Color.Blue;
            this.pawn_top.Image = ((System.Drawing.Image)(resources.GetObject("pawn_top.Image")));
            this.pawn_top.InitialImage = null;
            this.pawn_top.Location = new System.Drawing.Point(4, 4);
            this.pawn_top.Margin = new System.Windows.Forms.Padding(4);
            this.pawn_top.Name = "pawn_top";
            this.pawn_top.Size = new System.Drawing.Size(67, 62);
            this.pawn_top.TabIndex = 7;
            this.pawn_top.TabStop = false;
            this.pawn_top.Visible = false;
            // 
            // txt_player_name
            // 
            this.txt_player_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_player_name.Location = new System.Drawing.Point(4, 4);
            this.txt_player_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_player_name.MaxLength = 40;
            this.txt_player_name.Name = "txt_player_name";
            this.txt_player_name.ReadOnly = true;
            this.txt_player_name.Size = new System.Drawing.Size(290, 34);
            this.txt_player_name.TabIndex = 3;
            // 
            // Opponent_lable
            // 
            this.Opponent_lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Opponent_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opponent_lable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Opponent_lable.Location = new System.Drawing.Point(345, 6);
            this.Opponent_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Opponent_lable.Name = "Opponent_lable";
            this.Opponent_lable.Size = new System.Drawing.Size(241, 36);
            this.Opponent_lable.TabIndex = 0;
            this.Opponent_lable.Text = "stringOponent";
            this.Opponent_lable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Game_titel
            // 
            this.Game_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_titel.Location = new System.Drawing.Point(55, 49);
            this.Game_titel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Game_titel.Name = "Game_titel";
            this.Game_titel.Size = new System.Drawing.Size(529, 30);
            this.Game_titel.TabIndex = 4;
            this.Game_titel.Text = "Game 1";
            this.Game_titel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Info_Lable
            // 
            this.Info_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_Lable.Location = new System.Drawing.Point(55, 79);
            this.Info_Lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Info_Lable.Name = "Info_Lable";
            this.Info_Lable.Size = new System.Drawing.Size(529, 25);
            this.Info_Lable.TabIndex = 6;
            this.Info_Lable.Text = "Turn/win?";
            this.Info_Lable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1283, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.challengeRandomPlayerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.newGameToolStripMenuItem.Text = "Game";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.startToolStripMenuItem.Text = "Challenge player";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.MenueNewGameChalange);
            // 
            // challengeRandomPlayerToolStripMenuItem
            // 
            this.challengeRandomPlayerToolStripMenuItem.Name = "challengeRandomPlayerToolStripMenuItem";
            this.challengeRandomPlayerToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.challengeRandomPlayerToolStripMenuItem.Text = "Challenge random player";
            this.challengeRandomPlayerToolStripMenuItem.Click += new System.EventHandler(this.MenueNewGameRandomChalange);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.MenueExitProgram);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutPlayerToolStripMenuItem});
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.logOutToolStripMenuItem.Text = "Player";
            // 
            // logOutPlayerToolStripMenuItem
            // 
            this.logOutPlayerToolStripMenuItem.Name = "logOutPlayerToolStripMenuItem";
            this.logOutPlayerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.logOutPlayerToolStripMenuItem.Text = "Log out player";
            this.logOutPlayerToolStripMenuItem.Click += new System.EventHandler(this.MenueLogOut);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.MenueAboutProgram);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(125, 26);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.MenueHelpProgram);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.list_games);
            this.panel1.Controls.Add(this.txt_player_name);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 581);
            this.panel1.TabIndex = 8;
            // 
            // list_games
            // 
            this.list_games.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.list_games.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_games.Location = new System.Drawing.Point(4, 45);
            this.list_games.MultiSelect = false;
            this.list_games.Name = "list_games";
            this.list_games.Size = new System.Drawing.Size(290, 493);
            this.list_games.TabIndex = 11;
            this.list_games.UseCompatibleStateImageBehavior = false;
            this.list_games.View = System.Windows.Forms.View.List;
            this.list_games.SelectedIndexChanged += new System.EventHandler(this.AcctivGameSelected);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lableChangeTime);
            this.panel2.Controls.Add(this.labelGameTime);
            this.panel2.Controls.Add(this.turnInicator2);
            this.panel2.Controls.Add(this.LableYou);
            this.panel2.Controls.Add(this.Game_titel);
            this.panel2.Controls.Add(this.GamePanel);
            this.panel2.Controls.Add(this.Opponent_lable);
            this.panel2.Controls.Add(this.Info_Lable);
            this.panel2.Location = new System.Drawing.Point(314, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 580);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // labelGameTime
            // 
            this.labelGameTime.Location = new System.Drawing.Point(56, 540);
            this.labelGameTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGameTime.Name = "labelGameTime";
            this.labelGameTime.Size = new System.Drawing.Size(232, 17);
            this.labelGameTime.TabIndex = 12;
            this.labelGameTime.Text = "GameTime";
            // 
            // turnInicator2
            // 
            this.turnInicator2.BackColor = System.Drawing.Color.Transparent;
            this.turnInicator2.Image = global::Game_4irad.Properties.Resources.Indicator2;
            this.turnInicator2.Location = new System.Drawing.Point(3, 2);
            this.turnInicator2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.turnInicator2.Name = "turnInicator2";
            this.turnInicator2.Size = new System.Drawing.Size(40, 39);
            this.turnInicator2.TabIndex = 11;
            this.turnInicator2.TabStop = false;
            this.turnInicator2.Visible = false;
            // 
            // LableYou
            // 
            this.LableYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableYou.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LableYou.Location = new System.Drawing.Point(47, 6);
            this.LableYou.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LableYou.Name = "LableYou";
            this.LableYou.Size = new System.Drawing.Size(241, 34);
            this.LableYou.TabIndex = 7;
            this.LableYou.Text = "stringYou";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lableFun);
            this.panel3.Controls.Add(this.list_history);
            this.panel3.Controls.Add(this.turnInicator1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(17, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1259, 588);
            this.panel3.TabIndex = 10;
            // 
            // turnInicator1
            // 
            this.turnInicator1.BackColor = System.Drawing.Color.Transparent;
            this.turnInicator1.Image = global::Game_4irad.Properties.Resources.Indicator1;
            this.turnInicator1.Location = new System.Drawing.Point(912, 6);
            this.turnInicator1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.turnInicator1.Name = "turnInicator1";
            this.turnInicator1.Size = new System.Drawing.Size(40, 39);
            this.turnInicator1.TabIndex = 7;
            this.turnInicator1.TabStop = false;
            this.turnInicator1.Visible = false;
            // 
            // list_history
            // 
            this.list_history.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.list_history.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.list_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_history.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.list_history.Location = new System.Drawing.Point(963, 111);
            this.list_history.MultiSelect = false;
            this.list_history.Name = "list_history";
            this.list_history.Size = new System.Drawing.Size(290, 430);
            this.list_history.TabIndex = 12;
            this.list_history.UseCompatibleStateImageBehavior = false;
            this.list_history.View = System.Windows.Forms.View.Details;
            this.list_history.SelectedIndexChanged += new System.EventHandler(this.HistoryGameSelected);
            // 
            // lableFun
            // 
            this.lableFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableFun.Location = new System.Drawing.Point(958, 8);
            this.lableFun.Name = "lableFun";
            this.lableFun.Size = new System.Drawing.Size(283, 100);
            this.lableFun.TabIndex = 13;
            this.lableFun.Text = "Fun info!\r\n\r\nGames Won 0/0\r\nWin Rate 50%";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Games";
            this.columnHeader1.Width = 200;
            // 
            // lableChangeTime
            // 
            this.lableChangeTime.Location = new System.Drawing.Point(296, 540);
            this.lableChangeTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableChangeTime.Name = "lableChangeTime";
            this.lableChangeTime.Size = new System.Drawing.Size(288, 17);
            this.lableChangeTime.TabIndex = 13;
            this.lableChangeTime.Text = "GameTime";
            this.lableChangeTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1283, 625);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Connect four!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1Load);
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pawn_bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawn_top)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.turnInicator2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.turnInicator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.TextBox txt_player_name;
        private System.Windows.Forms.Label Opponent_lable;
        private System.Windows.Forms.Label Game_titel;
        private System.Windows.Forms.Label Info_Lable;
        private System.Windows.Forms.PictureBox pawn_bot;
        private System.Windows.Forms.PictureBox pawn_top;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem challengeRandomPlayerToolStripMenuItem;
        private System.Windows.Forms.Label LableYou;
        private System.Windows.Forms.PictureBox turnInicator1;
        private System.Windows.Forms.PictureBox turnInicator2;
        private System.Windows.Forms.Label labelGameTime;
        private System.Windows.Forms.ListView list_games;
        private System.Windows.Forms.ListView list_history;
        private System.Windows.Forms.Label lableFun;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lableChangeTime;
    }
}

