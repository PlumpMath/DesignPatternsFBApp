using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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

            resetButtons();

            foreach (eChartType item in Enum.GetValues(typeof(eChartType)))
            {
                comboChartType.Items.Add(item);
            }
        }

        private void resetButtons()
        {
            buttonChartButton.Enabled = false;
            buttonGetCommonFriend.Enabled = false;
            labelFriendsInCommon.Enabled = false;
            labelLikePagesInCommon.Enabled = false;
            likedPagesLinkLabel.Enabled = false;
            buttonLogout.Enabled = false;
            buttonLogin.Enabled = true;
        }

        private enum eChartType
        {
            City,
            Gender,
            Relationship_Status
        }

        private User m_LoggedInUser;
        private const int k_CollectionLimit = 200;
        private const float k_FbApiVersion = 2.8f;

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login(
                "1470264299671719",
                "public_profile",
                "user_birthday",
                "user_friends",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;

                pictureBoxCommonFriends.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxCommonLikedPages.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureCoverPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureCoverPhoto.LoadAsync(m_LoggedInUser.Cover.SourceURL);
                pictureProfilePic.LoadAsync(m_LoggedInUser.PictureLargeURL);
                labelGreeting.Text = "WELCOME " + m_LoggedInUser.Name + "!!!";
                friendsChart.Series.Clear();

                buttonChartButton.Enabled = true;
                buttonGetCommonFriend.Enabled = true;
                labelFriendsInCommon.Enabled = true;
                labelLikePagesInCommon.Enabled = true;
                likedPagesLinkLabel.Enabled = true;
                buttonLogout.Enabled = true;
                buttonLogin.Enabled = false;
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
            FacebookService.Logout(logoutFinished);
        }

        private void logoutFinished()
        {
            friendsChart.Series.Clear();
            listBoxLikedPages.Items.Clear();

            // Clear all pictures of user
            foreach (PictureBox pic in this.Controls.OfType<PictureBox>())
            {
                pic.Image = null;
            }

            pictureBoxCommonFriends.Image = null;
            pictureBoxCommonLikedPages.Image = null;
            pictureBoxLikedPage.Image = null;
            likedPageDescriptor.Text = string.Empty;
            labelFriendsInCommon.Text = string.Empty;
            labelLikePagesInCommon.Text = string.Empty;
            labelGreeting.Text = string.Empty;
            resetButtons();
        }

        private void getLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";

            // Add all liked pages to listbox
            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                listBoxLikedPages.Items.Add(page);
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
            int maxPages = 0;
            int maxFriends = 0;

            // Set as self, in case no one has anything in common with user.
            User maxPagesFriend = m_LoggedInUser;
            User maxFriendsFriend = m_LoggedInUser;

            // Get friend with max common friends and max common likes
            foreach (User friend in m_LoggedInUser.Friends)
            {
                int commonLikes = getCommonLikes(friend);
                int commonFriends = GetCommonFriends(friend);

                if (commonLikes > maxPages)
                {
                    maxPages = commonLikes;
                    maxPagesFriend = friend;
                }

                if (commonFriends > maxPages)
                {
                    maxFriends = commonFriends;
                    maxFriendsFriend = friend;
                }
            }

            pictureBoxCommonFriends.LoadAsync(maxFriendsFriend.PictureNormalURL);
            labelFriendsInCommon.Text = "Most friends in common with:\n" + maxFriendsFriend.Name;
            pictureBoxCommonLikedPages.LoadAsync(maxPagesFriend.PictureNormalURL);
            labelLikePagesInCommon.Text = "Most liked pages in common with:\n" + maxPagesFriend.Name;
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

        private int getCommonLikes(User friend)
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

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            diplaySelectedLikedPage();
        }

        private void diplaySelectedLikedPage()
        {
            if (listBoxLikedPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxLikedPages.SelectedItem as Page;

                // Make sure a url exists
                if (selectedPage.PictureNormalURL != null)
                {
                    try
                    {
                        likedPageDescriptor.Text = "Page name: " + selectedPage.Name;
                        pictureBoxLikedPage.LoadAsync(selectedPage.PictureNormalURL);
                    }
                    catch (Exception)
                    {
                        // If infomation is not null, display it
                    }
                }
                else
                {
                    pictureBoxLikedPage.Image = pictureBoxLikedPage.ErrorImage;
                }
            }
        }

        private void buttonChartButton_Click(object sender, EventArgs e)
        {
            friendsChart.Series.Clear();

            switch (comboChartType.SelectedItem)
            {
                case eChartType.Gender:
                {
                        updateGraphWithGender();
                        break;
                }
                case eChartType.Relationship_Status:
                {
                        updateGraphWithRelationship();
                        break;
                }
                case eChartType.City:
                {
                        updateGraphWithCity();
                        break;
                }
                default:
                {
                    MessageBox.Show("Please chose chart type");
                    break;
                }
            }
        }

        private void updateGraphWithCity()
        {
            Dictionary<string, int> chartValues =
                new Dictionary<string, int>();

            // Add all cities
            foreach (User friend in m_LoggedInUser.Friends)
            {
                try
                {
                    chartValues.Add(friend.Location.Name, 0);
                }
                catch (Exception)
                {
                    // IF failed for a friend, just ignore and continue to the next friend
                }
            }

            // Count friends location
            foreach (User friend in m_LoggedInUser.Friends)
            {
                try
                { 
                    chartValues[friend.Location.Name]++;
                }
                catch (Exception)
                {
                    // IF failed for a friend, just ignore and continue to the next friend
                }
            }

            foreach (KeyValuePair<string, int> item in chartValues)
            {
                Series seriesCity = friendsChart.Series.Add(item.Key.ToString());
                seriesCity.Points.Add(item.Value);
            }
        }

        private void updateGraphWithRelationship()
        {
            Dictionary<User.eRelationshipStatus, int> chartValues = 
                new Dictionary<User.eRelationshipStatus, int>();

            foreach (User.eRelationshipStatus item in Enum.GetValues(typeof(User.eRelationshipStatus)))
            {
                chartValues.Add(item, 0);
            }

            foreach (User friend in m_LoggedInUser.Friends)
            {
                try
                {
                    chartValues[friend.RelationshipStatus.Value]++;
                }
                catch (Exception)
                {
                    // IF failed for a friend, just ignore and continue to the next friend
                }
            }

            foreach (KeyValuePair<User.eRelationshipStatus, int> item in chartValues)
            {
                Series seriesStatus = friendsChart.Series.Add(item.Key.ToString());
                seriesStatus.Points.Add(item.Value);
            }
        }

        private void updateGraphWithGender()
        {
            Dictionary<User.eGender, int> chartValues = 
                new Dictionary<User.eGender, int>();

            foreach (User.eGender item in Enum.GetValues(typeof(User.eGender)))
            {
                chartValues.Add(item, 0);
            }

            foreach (User friend in m_LoggedInUser.Friends)
            {
                try
                {
                    chartValues[friend.Gender.Value]++;
                }
                catch (Exception)
                {
                    // IF failed for a friend, just ignore and continue to the next friend
                }
            }

            foreach (KeyValuePair<User.eGender, int> item in chartValues)
            {
                Series seriesGender = friendsChart.Series.Add(item.Key.ToString());
                seriesGender.Points.Add(item.Value);
            }
        }
    }
}
