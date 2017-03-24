using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = k_CollectionLimit;
            FacebookWrapper.FacebookService.s_FbApiVersion = k_FbApiVersion;
        }

        User m_LoggedInUser;
        private const int k_CollectionLimit = 200;
        private const float k_FbApiVersion = 2.8f;

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login("1470264299671719",
                "public_profile",
                "user_birthday",
                "user_friends",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts"
                );

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            logoutAndReset();
        }

        private void logoutAndReset()
        {
            //TODO reset the page (and record user settings?)
        }

        private void getLikedPages()
        {
            likedPagesListBox.Items.Clear();
            likedPagesListBox.DisplayMember = "Name";

            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                likedPagesListBox.Items.Add(page);
            }

            if (m_LoggedInUser.LikedPages.Count == 0)
            {
                MessageBox.Show("You have no liked pages to show");
            }
        }

        private void likedPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            getLikedPages();
        }
              

    }
}
