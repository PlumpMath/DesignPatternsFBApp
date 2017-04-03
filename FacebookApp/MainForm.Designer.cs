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
            this.labelGreeting = new System.Windows.Forms.Label();
            this.buttonGetCommonFriend = new System.Windows.Forms.Button();
            this.pictureBoxCommonFriends = new System.Windows.Forms.PictureBox();
            this.pictureBoxCommonLikedPages = new System.Windows.Forms.PictureBox();
            this.labelFriendsInCommon = new System.Windows.Forms.Label();
            this.labelLikePagesInCommon = new System.Windows.Forms.Label();
            this.pictureLikedPage = new System.Windows.Forms.PictureBox();
            this.likedPageDescriptor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonLikedPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLikedPage)).BeginInit();
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
            this.likedPagesListBox.Location = new System.Drawing.Point(12, 672);
            this.likedPagesListBox.Name = "likedPagesListBox";
            this.likedPagesListBox.Size = new System.Drawing.Size(191, 180);
            this.likedPagesListBox.TabIndex = 2;
            // 
            // likedPagesLinkLabel
            // 
            this.likedPagesLinkLabel.AutoSize = true;
            this.likedPagesLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.likedPagesLinkLabel.Location = new System.Drawing.Point(9, 652);
            this.likedPagesLinkLabel.Name = "likedPagesLinkLabel";
            this.likedPagesLinkLabel.Size = new System.Drawing.Size(107, 17);
            this.likedPagesLinkLabel.TabIndex = 3;
            this.likedPagesLinkLabel.TabStop = true;
            this.likedPagesLinkLabel.Text = "Get liked pages";
            this.likedPagesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likedPages_LinkClicked);
            // 
            // pictureCoverPhoto
            // 
            this.pictureCoverPhoto.Location = new System.Drawing.Point(12, 45);
            this.pictureCoverPhoto.Name = "pictureCoverPhoto";
            this.pictureCoverPhoto.Size = new System.Drawing.Size(828, 315);
            this.pictureCoverPhoto.TabIndex = 4;
            this.pictureCoverPhoto.TabStop = false;
            // 
            // pictureProfilePic
            // 
            this.pictureProfilePic.Location = new System.Drawing.Point(12, 190);
            this.pictureProfilePic.Name = "pictureProfilePic";
            this.pictureProfilePic.Size = new System.Drawing.Size(170, 170);
            this.pictureProfilePic.TabIndex = 5;
            this.pictureProfilePic.TabStop = false;
            // 
            // labelGreeting
            // 
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.Font = new System.Drawing.Font("Lucida Console", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreeting.Location = new System.Drawing.Point(183, 9);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(162, 33);
            this.labelGreeting.TabIndex = 7;
            this.labelGreeting.Text = "WELCOME";
            // 
            // buttonGetCommonFriend
            // 
            this.buttonGetCommonFriend.Location = new System.Drawing.Point(301, 389);
            this.buttonGetCommonFriend.Name = "buttonGetCommonFriend";
            this.buttonGetCommonFriend.Size = new System.Drawing.Size(272, 23);
            this.buttonGetCommonFriend.TabIndex = 8;
            this.buttonGetCommonFriend.Text = "Most in Common With";
            this.buttonGetCommonFriend.UseVisualStyleBackColor = true;
            this.buttonGetCommonFriend.Click += new System.EventHandler(this.buttonGetCommonFriend_Click);
            // 
            // pictureBoxCommonFriends
            // 
            this.pictureBoxCommonFriends.Location = new System.Drawing.Point(209, 465);
            this.pictureBoxCommonFriends.Name = "pictureBoxCommonFriends";
            this.pictureBoxCommonFriends.Size = new System.Drawing.Size(207, 181);
            this.pictureBoxCommonFriends.TabIndex = 9;
            this.pictureBoxCommonFriends.TabStop = false;
            this.pictureBoxCommonFriends.Click += new System.EventHandler(this.pictureBoxCommonFriend_Click);
            // 
            // pictureBoxCommonLikedPages
            // 
            this.pictureBoxCommonLikedPages.Location = new System.Drawing.Point(439, 466);
            this.pictureBoxCommonLikedPages.Name = "pictureBoxCommonLikedPages";
            this.pictureBoxCommonLikedPages.Size = new System.Drawing.Size(215, 180);
            this.pictureBoxCommonLikedPages.TabIndex = 10;
            this.pictureBoxCommonLikedPages.TabStop = false;
            // 
            // labelFriendsInCommon
            // 
            this.labelFriendsInCommon.AutoSize = true;
            this.labelFriendsInCommon.Location = new System.Drawing.Point(206, 421);
            this.labelFriendsInCommon.Name = "labelFriendsInCommon";
            this.labelFriendsInCommon.Size = new System.Drawing.Size(0, 17);
            this.labelFriendsInCommon.TabIndex = 11;
            this.labelFriendsInCommon.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLikePagesInCommon
            // 
            this.labelLikePagesInCommon.AutoSize = true;
            this.labelLikePagesInCommon.Location = new System.Drawing.Point(436, 421);
            this.labelLikePagesInCommon.Name = "labelLikePagesInCommon";
            this.labelLikePagesInCommon.Size = new System.Drawing.Size(0, 17);
            this.labelLikePagesInCommon.TabIndex = 12;
            this.labelLikePagesInCommon.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureLikedPage
            // 
            this.pictureLikedPage.Location = new System.Drawing.Point(209, 672);
            this.pictureLikedPage.Name = "pictureLikedPage";
            this.pictureLikedPage.Size = new System.Drawing.Size(170, 170);
            this.pictureLikedPage.TabIndex = 13;
            this.pictureLikedPage.TabStop = false;
            // 
            // likedPageDescriptor
            // 
            this.likedPageDescriptor.AutoSize = true;
            this.likedPageDescriptor.Location = new System.Drawing.Point(385, 672);
            this.likedPageDescriptor.Name = "likedPageDescriptor";
            this.likedPageDescriptor.Size = new System.Drawing.Size(0, 17);
            this.likedPageDescriptor.TabIndex = 14;
            this.likedPageDescriptor.Click += new System.EventHandler(this.likedPageDescriptor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(864, 866);
            this.Controls.Add(this.likedPageDescriptor);
            this.Controls.Add(this.pictureLikedPage);
            this.Controls.Add(this.labelLikePagesInCommon);
            this.Controls.Add(this.labelFriendsInCommon);
            this.Controls.Add(this.pictureBoxCommonLikedPages);
            this.Controls.Add(this.pictureBoxCommonFriends);
            this.Controls.Add(this.buttonGetCommonFriend);
            this.Controls.Add(this.pictureProfilePic);
            this.Controls.Add(this.pictureCoverPhoto);
            this.Controls.Add(this.likedPagesLinkLabel);
            this.Controls.Add(this.likedPagesListBox);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelGreeting);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonLikedPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLikedPage)).EndInit();
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
        private System.Windows.Forms.Label labelGreeting;
        private System.Windows.Forms.Button buttonGetCommonFriend;
        private System.Windows.Forms.PictureBox pictureBoxCommonFriends;
        private System.Windows.Forms.PictureBox pictureBoxCommonLikedPages;
        private System.Windows.Forms.Label labelFriendsInCommon;
        private System.Windows.Forms.Label labelLikePagesInCommon;
        private System.Windows.Forms.PictureBox pictureLikedPage;
        private System.Windows.Forms.Label likedPageDescriptor;
    }
}

