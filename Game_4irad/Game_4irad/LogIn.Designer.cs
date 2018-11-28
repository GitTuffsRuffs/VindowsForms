namespace Game_4irad
{
    partial class LogIn
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
            this.text_Login = new System.Windows.Forms.TextBox();
            this.butt_LogIn = new System.Windows.Forms.Button();
            this.butt_MakeAccount = new System.Windows.Forms.Button();
            this.lab_username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_Login
            // 
            this.text_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Login.Location = new System.Drawing.Point(16, 49);
            this.text_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_Login.MaxLength = 255;
            this.text_Login.Name = "text_Login";
            this.text_Login.Size = new System.Drawing.Size(341, 34);
            this.text_Login.TabIndex = 0;
            // 
            // butt_LogIn
            // 
            this.butt_LogIn.Location = new System.Drawing.Point(17, 94);
            this.butt_LogIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butt_LogIn.Name = "butt_LogIn";
            this.butt_LogIn.Size = new System.Drawing.Size(341, 55);
            this.butt_LogIn.TabIndex = 1;
            this.butt_LogIn.Text = "Log In";
            this.butt_LogIn.UseVisualStyleBackColor = true;
            this.butt_LogIn.Click += new System.EventHandler(this.buttonLogIn_ClickAsync);
            // 
            // butt_MakeAccount
            // 
            this.butt_MakeAccount.Location = new System.Drawing.Point(16, 156);
            this.butt_MakeAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butt_MakeAccount.Name = "butt_MakeAccount";
            this.butt_MakeAccount.Size = new System.Drawing.Size(341, 55);
            this.butt_MakeAccount.TabIndex = 2;
            this.butt_MakeAccount.Text = "Make Account";
            this.butt_MakeAccount.UseVisualStyleBackColor = true;
            this.butt_MakeAccount.Click += new System.EventHandler(this.butt_MakeAccount_ClickAsync);
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_username.Location = new System.Drawing.Point(17, 16);
            this.lab_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(130, 29);
            this.lab_username.TabIndex = 3;
            this.lab_username.Text = "Username:";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 236);
            this.Controls.Add(this.lab_username);
            this.Controls.Add(this.butt_MakeAccount);
            this.Controls.Add(this.butt_LogIn);
            this.Controls.Add(this.text_Login);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Login;
        private System.Windows.Forms.Button butt_LogIn;
        private System.Windows.Forms.Button butt_MakeAccount;
        private System.Windows.Forms.Label lab_username;
    }
}