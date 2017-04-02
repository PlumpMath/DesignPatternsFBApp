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
            this.pictureCoverPhoto = new System.Windows.Forms.PictureBox();
            this.pictureProfilePic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGetCommonFriend = new System.Windows.Forms.Button();
            this.pictureCommonFriend = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCommonFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.likedPagesListBox.Location = new System.Drawing.Point(12, 477);
            this.likedPagesListBox.Name = "likedPagesListBox";
            this.likedPagesListBox.Size = new System.Drawing.Size(112, 180);
            this.likedPagesListBox.TabIndex = 2;
            // 
            // likedPagesLinkLabel
            // 
            this.likedPagesLinkLabel.AutoSize = true;
            this.likedPagesLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.likedPagesLinkLabel.Location = new System.Drawing.Point(9, 457);
            this.likedPagesLinkLabel.Name = "likedPagesLinkLabel";
            this.likedPagesLinkLabel.Size = new System.Drawing.Size(107, 17);
            this.likedPagesLinkLabel.TabIndex = 3;
            this.likedPagesLinkLabel.TabStop = true;
            this.likedPagesLinkLabel.Text = "Get liked pages";
            this.likedPagesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likedPages_LinkClicked);
            // 
            // pictureCoverPhoto
            // 
            this.pictureCoverPhoto.Location = new System.Drawing.Point(12, 56);
            this.pictureCoverPhoto.Name = "pictureCoverPhoto";
            this.pictureCoverPhoto.Size = new System.Drawing.Size(851, 383);
            this.pictureCoverPhoto.TabIndex = 4;
            this.pictureCoverPhoto.TabStop = false;
            // 
            // pictureProfilePic
            // 
            this.pictureProfilePic.Location = new System.Drawing.Point(13, 280);
            this.pictureProfilePic.Name = "pictureProfilePic";
            this.pictureProfilePic.Size = new System.Drawing.Size(190, 158);
            this.pictureProfilePic.TabIndex = 5;
            this.pictureProfilePic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "WELCOME";
            // 
            // buttonGetCommonFriend
            // 
            this.buttonGetCommonFriend.Location = new System.Drawing.Point(241, 448);
            this.buttonGetCommonFriend.Name = "buttonGetCommonFriend";
            this.buttonGetCommonFriend.Size = new System.Drawing.Size(75, 23);
            this.buttonGetCommonFriend.TabIndex = 8;
            this.buttonGetCommonFriend.Text = "button1";
            this.buttonGetCommonFriend.UseVisualStyleBackColor = true;
            this.buttonGetCommonFriend.Click += new System.EventHandler(this.buttonGetCommonFriend_Click);
            // 
            // pictureCommonFriend
            // 
            this.pictureCommonFriend.Location = new System.Drawing.Point(170, 477);
            this.pictureCommonFriend.Name = "pictureCommonFriend";
            this.pictureCommonFriend.Size = new System.Drawing.Size(207, 180);
            this.pictureCommonFriend.TabIndex = 9;
            this.pictureCommonFriend.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(439, 477);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 180);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(875, 669);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureCommonFriend);
            this.Controls.Add(this.buttonGetCommonFriend);
            this.Controls.Add(this.pictureProfilePic);
            this.Controls.Add(this.pictureCoverPhoto);
            this.Controls.Add(this.likedPagesLinkLabel);
            this.Controls.Add(this.likedPagesListBox);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCommonFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListBox likedPagesListBox;
        private System.Windows.Forms.LinkLabel likedPagesLinkLabel;
        private System.Windows.Forms.PictureBox pictureCoverPhoto;
        private System.Windows.Forms.PictureBox pictureProfilePic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetCommonFriend;
        private System.Windows.Forms.PictureBox pictureCommonFriend;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

