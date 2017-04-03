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

            pictureBoxCommonFriends.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCommonLikedPages.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureCoverPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureCoverPhoto.LoadAsync(m_LoggedInUser.Cover.SourceURL);
            pictureProfilePic.LoadAsync(m_LoggedInUser.PictureLargeURL);
            labelGreeting.Text = "WELCOME " + m_LoggedInUser.Name + "!!!";
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

        private void buttonGetCommonFriend_Click(object sender, EventArgs e)
        {
            int nMaxPages = 0;
            int nMaxFriends = 0;

            // Set as self, in case no one has anything in common with user.
            User MaxPagesFriend = m_LoggedInUser;
            User MaxFriendsFriend = m_LoggedInUser;

            foreach (User friend in m_LoggedInUser.Friends)
            {
                int nCommonLikes = GetCommonLikes(friend);
                int nCommonFriends = GetCommonFriends(friend);

                if (nCommonLikes > nMaxPages)
                {
                    nMaxPages = nCommonLikes;
                    MaxPagesFriend = friend;
                }

                if (nCommonFriends > nMaxPages)
                {
                    nMaxFriends = nCommonFriends;
                    MaxFriendsFriend = friend;
                }
            }

            pictureBoxCommonFriends.LoadAsync(MaxFriendsFriend.PictureNormalURL);
            labelFriendsInCommon.Text = "Most friends in common with:\n" + MaxFriendsFriend.Name;
            pictureBoxCommonLikedPages.LoadAsync(MaxPagesFriend.PictureNormalURL);
            labelLikePagesInCommon.Text = "Most liked pages in common with:\n" + MaxPagesFriend.Name;
        }

        private int GetCommonFriends(User friend)
        {
            int count = 0;

            foreach (User userFriend in m_LoggedInUser.Friends)
            {
                foreach (User friendFriend in friend.Friends)
                {
                    if (userFriend.Id == friendFriend.Id)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private int GetCommonLikes(User friend)
        {
            int count = 0;

            foreach (Page likedPage in m_LoggedInUser.LikedPages)
            {
                foreach (Page friendLikedPage in friend.LikedPages)
                {
                    if (likedPage.Id == friendLikedPage.Id)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void likedPageDescriptor_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxCommonFriend_Click(object sender, EventArgs e)
        {

        }
    }
}
