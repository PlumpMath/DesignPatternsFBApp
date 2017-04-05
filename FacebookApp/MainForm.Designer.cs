namespace FacebookApp
{
    public partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureCoverPhoto = new System.Windows.Forms.PictureBox();
            this.pictureProfilePic = new System.Windows.Forms.PictureBox();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelLikePagesInCommon = new System.Windows.Forms.Label();
            this.labelFriendsInCommon = new System.Windows.Forms.Label();
            this.pictureBoxCommonLikedPages = new System.Windows.Forms.PictureBox();
            this.pictureBoxCommonFriends = new System.Windows.Forms.PictureBox();
            this.buttonGetCommonFriend = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.likedPageDescriptor = new System.Windows.Forms.Label();
            this.pictureBoxLikedPage = new System.Windows.Forms.PictureBox();
            this.likedPagesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonChartButton = new System.Windows.Forms.Button();
            this.comboChartType = new System.Windows.Forms.ComboBox();
            this.friendsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePic)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonLikedPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonFriends)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureCoverPhoto
            // 
            this.pictureCoverPhoto.Location = new System.Drawing.Point(12, 46);
            this.pictureCoverPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureCoverPhoto.Name = "pictureCoverPhoto";
            this.pictureCoverPhoto.Size = new System.Drawing.Size(828, 315);
            this.pictureCoverPhoto.TabIndex = 4;
            this.pictureCoverPhoto.TabStop = false;
            // 
            // pictureProfilePic
            // 
            this.pictureProfilePic.Location = new System.Drawing.Point(12, 190);
            this.pictureProfilePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureProfilePic.Name = "pictureProfilePic";
            this.pictureProfilePic.Size = new System.Drawing.Size(171, 170);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 366);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 488);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelLikePagesInCommon);
            this.tabPage1.Controls.Add(this.labelFriendsInCommon);
            this.tabPage1.Controls.Add(this.pictureBoxCommonLikedPages);
            this.tabPage1.Controls.Add(this.pictureBoxCommonFriends);
            this.tabPage1.Controls.Add(this.buttonGetCommonFriend);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(832, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Common";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelLikePagesInCommon
            // 
            this.labelLikePagesInCommon.AutoSize = true;
            this.labelLikePagesInCommon.Location = new System.Drawing.Point(229, 61);
            this.labelLikePagesInCommon.Name = "labelLikePagesInCommon";
            this.labelLikePagesInCommon.Size = new System.Drawing.Size(0, 17);
            this.labelLikePagesInCommon.TabIndex = 17;
            // 
            // labelFriendsInCommon
            // 
            this.labelFriendsInCommon.AutoSize = true;
            this.labelFriendsInCommon.Location = new System.Drawing.Point(-2, 61);
            this.labelFriendsInCommon.Name = "labelFriendsInCommon";
            this.labelFriendsInCommon.Size = new System.Drawing.Size(0, 17);
            this.labelFriendsInCommon.TabIndex = 16;
            // 
            // pictureBoxCommonLikedPages
            // 
            this.pictureBoxCommonLikedPages.Location = new System.Drawing.Point(232, 106);
            this.pictureBoxCommonLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCommonLikedPages.Name = "pictureBoxCommonLikedPages";
            this.pictureBoxCommonLikedPages.Size = new System.Drawing.Size(215, 180);
            this.pictureBoxCommonLikedPages.TabIndex = 15;
            this.pictureBoxCommonLikedPages.TabStop = false;
            // 
            // pictureBoxCommonFriends
            // 
            this.pictureBoxCommonFriends.Location = new System.Drawing.Point(2, 105);
            this.pictureBoxCommonFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCommonFriends.Name = "pictureBoxCommonFriends";
            this.pictureBoxCommonFriends.Size = new System.Drawing.Size(207, 181);
            this.pictureBoxCommonFriends.TabIndex = 14;
            this.pictureBoxCommonFriends.TabStop = false;
            // 
            // buttonGetCommonFriend
            // 
            this.buttonGetCommonFriend.Location = new System.Drawing.Point(94, 29);
            this.buttonGetCommonFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGetCommonFriend.Name = "buttonGetCommonFriend";
            this.buttonGetCommonFriend.Size = new System.Drawing.Size(272, 23);
            this.buttonGetCommonFriend.TabIndex = 13;
            this.buttonGetCommonFriend.Text = "Most in Common With";
            this.buttonGetCommonFriend.UseVisualStyleBackColor = true;
            this.buttonGetCommonFriend.Click += new System.EventHandler(this.buttonGetCommonFriend_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.likedPageDescriptor);
            this.tabPage2.Controls.Add(this.pictureBoxLikedPage);
            this.tabPage2.Controls.Add(this.likedPagesLinkLabel);
            this.tabPage2.Controls.Add(this.listBoxLikedPages);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(832, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // likedPageDescriptor
            // 
            this.likedPageDescriptor.AutoSize = true;
            this.likedPageDescriptor.Location = new System.Drawing.Point(604, 149);
            this.likedPageDescriptor.Name = "likedPageDescriptor";
            this.likedPageDescriptor.Size = new System.Drawing.Size(0, 17);
            this.likedPageDescriptor.TabIndex = 18;
            // 
            // pictureBoxLikedPage
            // 
            this.pictureBoxLikedPage.Location = new System.Drawing.Point(428, 149);
            this.pictureBoxLikedPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLikedPage.Name = "pictureBoxLikedPage";
            this.pictureBoxLikedPage.Size = new System.Drawing.Size(171, 170);
            this.pictureBoxLikedPage.TabIndex = 17;
            this.pictureBoxLikedPage.TabStop = false;
            // 
            // likedPagesLinkLabel
            // 
            this.likedPagesLinkLabel.AutoSize = true;
            this.likedPagesLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.likedPagesLinkLabel.Location = new System.Drawing.Point(228, 129);
            this.likedPagesLinkLabel.Name = "likedPagesLinkLabel";
            this.likedPagesLinkLabel.Size = new System.Drawing.Size(107, 17);
            this.likedPagesLinkLabel.TabIndex = 16;
            this.likedPagesLinkLabel.TabStop = true;
            this.likedPagesLinkLabel.Text = "Get liked pages";
            this.likedPagesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likedPages_LinkClicked);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 16;
            this.listBoxLikedPages.Location = new System.Drawing.Point(231, 149);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(191, 180);
            this.listBoxLikedPages.TabIndex = 15;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonChartButton);
            this.tabPage3.Controls.Add(this.comboChartType);
            this.tabPage3.Controls.Add(this.friendsChart);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(832, 459);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Graph";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonChartButton
            // 
            this.buttonChartButton.Location = new System.Drawing.Point(268, 20);
            this.buttonChartButton.Name = "buttonChartButton";
            this.buttonChartButton.Size = new System.Drawing.Size(119, 24);
            this.buttonChartButton.TabIndex = 2;
            this.buttonChartButton.Text = "Build Chart";
            this.buttonChartButton.UseVisualStyleBackColor = true;
            this.buttonChartButton.Click += new System.EventHandler(this.buttonChartButton_Click);
            // 
            // comboChartType
            // 
            this.comboChartType.FormattingEnabled = true;
            this.comboChartType.Location = new System.Drawing.Point(98, 20);
            this.comboChartType.Name = "comboChartType";
            this.comboChartType.Size = new System.Drawing.Size(121, 24);
            this.comboChartType.TabIndex = 1;
            this.comboChartType.Text = "Choose type";
            // 
            // FriendsChart
            // 
            chartArea2.Name = "ChartArea1";
            this.friendsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.friendsChart.Legends.Add(legend2);
            this.friendsChart.Location = new System.Drawing.Point(19, 64);
            this.friendsChart.Name = "FriendsChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.friendsChart.Series.Add(series2);
            this.friendsChart.Size = new System.Drawing.Size(771, 392);
            this.friendsChart.TabIndex = 0;
            this.friendsChart.Text = "chartFriendsChart";
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(FacebookApp.MainForm);
            // 
            // mainFormBindingSource1
            // 
            this.mainFormBindingSource1.DataSource = typeof(FacebookApp.MainForm);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(864, 866);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureProfilePic);
            this.Controls.Add(this.pictureCoverPhoto);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelGreeting);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Facebook App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePic)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonLikedPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonFriends)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.friendsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureCoverPhoto;
        private System.Windows.Forms.PictureBox pictureProfilePic;
        private System.Windows.Forms.Label labelGreeting;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelLikePagesInCommon;
        private System.Windows.Forms.Label labelFriendsInCommon;
        private System.Windows.Forms.PictureBox pictureBoxCommonLikedPages;
        private System.Windows.Forms.PictureBox pictureBoxCommonFriends;
        private System.Windows.Forms.Button buttonGetCommonFriend;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label likedPageDescriptor;
        private System.Windows.Forms.PictureBox pictureBoxLikedPage;
        private System.Windows.Forms.LinkLabel likedPagesLinkLabel;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonChartButton;
        private System.Windows.Forms.ComboBox comboChartType;
        private System.Windows.Forms.DataVisualization.Charting.Chart friendsChart;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private System.Windows.Forms.BindingSource mainFormBindingSource1;
    }
}
