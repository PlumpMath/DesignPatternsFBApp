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
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.likedPagesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureCoverPhoto = new System.Windows.Forms.PictureBox();
            this.pictureProfilePic = new System.Windows.Forms.PictureBox();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.buttonGetCommonFriend = new System.Windows.Forms.Button();
            this.pictureBoxCommonFriends = new System.Windows.Forms.PictureBox();
            this.pictureBoxCommonLikedPages = new System.Windows.Forms.PictureBox();
            this.labelFriendsInCommon = new System.Windows.Forms.Label();
            this.labelLikePagesInCommon = new System.Windows.Forms.Label();
            this.pictureBoxLikedPage = new System.Windows.Forms.PictureBox();
            this.likedPageDescriptor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonLikedPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(9, 10);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(56, 19);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(70, 10);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(56, 19);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.Location = new System.Drawing.Point(9, 546);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(144, 147);
            this.listBoxLikedPages.TabIndex = 2;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // likedPagesLinkLabel
            // 
            this.likedPagesLinkLabel.AutoSize = true;
            this.likedPagesLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.likedPagesLinkLabel.Location = new System.Drawing.Point(7, 530);
            this.likedPagesLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.likedPagesLinkLabel.Name = "likedPagesLinkLabel";
            this.likedPagesLinkLabel.Size = new System.Drawing.Size(81, 13);
            this.likedPagesLinkLabel.TabIndex = 3;
            this.likedPagesLinkLabel.TabStop = true;
            this.likedPagesLinkLabel.Text = "Get liked pages";
            this.likedPagesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likedPages_LinkClicked);
            // 
            // pictureCoverPhoto
            // 
            this.pictureCoverPhoto.Location = new System.Drawing.Point(9, 37);
            this.pictureCoverPhoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureCoverPhoto.Name = "pictureCoverPhoto";
            this.pictureCoverPhoto.Size = new System.Drawing.Size(621, 256);
            this.pictureCoverPhoto.TabIndex = 4;
            this.pictureCoverPhoto.TabStop = false;
            // 
            // pictureProfilePic
            // 
            this.pictureProfilePic.Location = new System.Drawing.Point(9, 154);
            this.pictureProfilePic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureProfilePic.Name = "pictureProfilePic";
            this.pictureProfilePic.Size = new System.Drawing.Size(128, 138);
            this.pictureProfilePic.TabIndex = 5;
            this.pictureProfilePic.TabStop = false;
            // 
            // labelGreeting
            // 
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.Font = new System.Drawing.Font("Lucida Console", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreeting.Location = new System.Drawing.Point(137, 7);
            this.labelGreeting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(131, 27);
            this.labelGreeting.TabIndex = 7;
            this.labelGreeting.Text = "WELCOME";
            // 
            // buttonGetCommonFriend
            // 
            this.buttonGetCommonFriend.Location = new System.Drawing.Point(226, 316);
            this.buttonGetCommonFriend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGetCommonFriend.Name = "buttonGetCommonFriend";
            this.buttonGetCommonFriend.Size = new System.Drawing.Size(204, 19);
            this.buttonGetCommonFriend.TabIndex = 8;
            this.buttonGetCommonFriend.Text = "Most in Common With";
            this.buttonGetCommonFriend.UseVisualStyleBackColor = true;
            this.buttonGetCommonFriend.Click += new System.EventHandler(this.buttonGetCommonFriend_Click);
            // 
            // pictureBoxCommonFriends
            // 
            this.pictureBoxCommonFriends.Location = new System.Drawing.Point(157, 378);
            this.pictureBoxCommonFriends.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxCommonFriends.Name = "pictureBoxCommonFriends";
            this.pictureBoxCommonFriends.Size = new System.Drawing.Size(155, 147);
            this.pictureBoxCommonFriends.TabIndex = 9;
            this.pictureBoxCommonFriends.TabStop = false;
            // 
            // pictureBoxCommonLikedPages
            // 
            this.pictureBoxCommonLikedPages.Location = new System.Drawing.Point(329, 379);
            this.pictureBoxCommonLikedPages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxCommonLikedPages.Name = "pictureBoxCommonLikedPages";
            this.pictureBoxCommonLikedPages.Size = new System.Drawing.Size(161, 146);
            this.pictureBoxCommonLikedPages.TabIndex = 10;
            this.pictureBoxCommonLikedPages.TabStop = false;
            // 
            // labelFriendsInCommon
            // 
            this.labelFriendsInCommon.AutoSize = true;
            this.labelFriendsInCommon.Location = new System.Drawing.Point(154, 342);
            this.labelFriendsInCommon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendsInCommon.Name = "labelFriendsInCommon";
            this.labelFriendsInCommon.Size = new System.Drawing.Size(0, 13);
            this.labelFriendsInCommon.TabIndex = 11;
            // 
            // labelLikePagesInCommon
            // 
            this.labelLikePagesInCommon.AutoSize = true;
            this.labelLikePagesInCommon.Location = new System.Drawing.Point(327, 342);
            this.labelLikePagesInCommon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLikePagesInCommon.Name = "labelLikePagesInCommon";
            this.labelLikePagesInCommon.Size = new System.Drawing.Size(0, 13);
            this.labelLikePagesInCommon.TabIndex = 12;
            // 
            // pictureBoxLikedPage
            // 
            this.pictureBoxLikedPage.Location = new System.Drawing.Point(157, 546);
            this.pictureBoxLikedPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLikedPage.Name = "pictureBoxLikedPage";
            this.pictureBoxLikedPage.Size = new System.Drawing.Size(128, 138);
            this.pictureBoxLikedPage.TabIndex = 13;
            this.pictureBoxLikedPage.TabStop = false;
            // 
            // likedPageDescriptor
            // 
            this.likedPageDescriptor.AutoSize = true;
            this.likedPageDescriptor.Location = new System.Drawing.Point(289, 546);
            this.likedPageDescriptor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.likedPageDescriptor.Name = "likedPageDescriptor";
            this.likedPageDescriptor.Size = new System.Drawing.Size(0, 13);
            this.likedPageDescriptor.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(648, 704);
            this.Controls.Add(this.likedPageDescriptor);
            this.Controls.Add(this.pictureBoxLikedPage);
            this.Controls.Add(this.labelLikePagesInCommon);
            this.Controls.Add(this.labelFriendsInCommon);
            this.Controls.Add(this.pictureBoxCommonLikedPages);
            this.Controls.Add(this.pictureBoxCommonFriends);
            this.Controls.Add(this.buttonGetCommonFriend);
            this.Controls.Add(this.pictureProfilePic);
            this.Controls.Add(this.pictureCoverPhoto);
            this.Controls.Add(this.likedPagesLinkLabel);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelGreeting);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonLikedPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.LinkLabel likedPagesLinkLabel;
        private System.Windows.Forms.PictureBox pictureCoverPhoto;
        private System.Windows.Forms.PictureBox pictureProfilePic;
        private System.Windows.Forms.Label labelGreeting;
        private System.Windows.Forms.Button buttonGetCommonFriend;
        private System.Windows.Forms.PictureBox pictureBoxCommonFriends;
        private System.Windows.Forms.PictureBox pictureBoxCommonLikedPages;
        private System.Windows.Forms.Label labelFriendsInCommon;
        private System.Windows.Forms.Label labelLikePagesInCommon;
        private System.Windows.Forms.PictureBox pictureBoxLikedPage;
        private System.Windows.Forms.Label likedPageDescriptor;
    }
}

