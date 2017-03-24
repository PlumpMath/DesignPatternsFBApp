namespace FacebookApp
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.likedPagesListBox = new System.Windows.Forms.ListBox();
            this.likedPagesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(93, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // likedPagesListBox
            // 
            this.likedPagesListBox.FormattingEnabled = true;
            this.likedPagesListBox.ItemHeight = 16;
            this.likedPagesListBox.Location = new System.Drawing.Point(16, 62);
            this.likedPagesListBox.Name = "likedPagesListBox";
            this.likedPagesListBox.Size = new System.Drawing.Size(227, 180);
            this.likedPagesListBox.TabIndex = 2;
            // 
            // likedPagesLinkLabel
            // 
            this.likedPagesLinkLabel.AutoSize = true;
            this.likedPagesLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.likedPagesLinkLabel.Location = new System.Drawing.Point(13, 42);
            this.likedPagesLinkLabel.Name = "likedPagesLinkLabel";
            this.likedPagesLinkLabel.Size = new System.Drawing.Size(107, 17);
            this.likedPagesLinkLabel.TabIndex = 3;
            this.likedPagesLinkLabel.TabStop = true;
            this.likedPagesLinkLabel.Text = "Get liked pages";
            this.likedPagesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likedPages_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 486);
            this.Controls.Add(this.likedPagesLinkLabel);
            this.Controls.Add(this.likedPagesListBox);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListBox likedPagesListBox;
        private System.Windows.Forms.LinkLabel likedPagesLinkLabel;
    }
}

