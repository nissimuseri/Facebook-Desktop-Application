using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AppLogic;
using AppLogic.LocationsMap;
using AppLogic.Strategy;
using FacebookWrapper.ObjectModel;
using Microsoft.Win32;

namespace AppUI
{
    internal partial class FormLocationsMap : Form
    {
        private const string k_GoogleMapsUrl = "https://www.google.co.il/maps/search/?api=1&query=";
        private FacebookDataFacade m_UserData;

        private List<KeyValuePair<string, VisitedLocation>> m_UserLocations;

        private ISortMethod<string, VisitedLocation> m_SortMethod = new AlphabeticSort();

        private Dictionary<string, ISortMethod<string, VisitedLocation>> m_radioButtonsMethods;

        public FormLocationsMap(User i_User)
        {
            InitializeComponent();
            m_UserData = new FacebookDataFacade(i_User);
            m_radioButtonsMethods = new Dictionary<string, ISortMethod<string, VisitedLocation>>();
            updateBrowserVersion();
            addRadioButtonsToDictionary();
            addRadioButtonsToEvent();
        }

        private void addRadioButtonsToDictionary()
        {
            m_radioButtonsMethods["radioButtonName"] = new AlphabeticSort();
            m_radioButtonsMethods["radioButtonPosts"] = new PostsSort();
            m_radioButtonsMethods["radioButtonCheckIns"] = new CheckInsSort();
            m_radioButtonsMethods["radioButtonPhotos"] = new PhotosSort();
        }

        private void addRadioButtonsToEvent()
        {
            IEnumerable<RadioButton> radioButtons = this.Controls.OfType<RadioButton>();
            foreach(RadioButton rb in radioButtons)
            {
                rb.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            listBoxLocations.Items.Clear();
            loadLocationsList();
        }

        private void updateBrowserVersion()
        {
            string appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            using (RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
            {
                Key.SetValue(appName, 99999, RegistryValueKind.DWord);
            }
        }

        private void loadLocationsList()
        {
            listBoxLocations.Items.Clear();
            listBoxLocations.DisplayMember = "LocationName";
            m_UserLocations = m_UserData.GetAllLocations(m_SortMethod);
            if (m_UserLocations.Count == 0)
            {
                m_UserLocations = m_UserData.HardcodedLocation(m_SortMethod);
            }

            foreach (KeyValuePair<string, VisitedLocation> location in m_UserLocations)
            {
                listBoxLocations.Items.Add(location.Value);
            }
        }

        private void buttonLoadMap_Click(object sender, EventArgs e)
        {
            if(listBoxLocations.SelectedItems.Count == 1)
            {
                VisitedLocation chosenLocation = listBoxLocations.SelectedItem as VisitedLocation;
                string url = string.Format("{0}{1},{2}", k_GoogleMapsUrl, chosenLocation.Latitude, chosenLocation.Longitude);
                webBrowserMap.ScriptErrorsSuppressed = true;
                webBrowserMap.Navigate(url);
                updateStatistics(chosenLocation);
            }
        }

        private void updateStatistics(VisitedLocation i_ChosenLocation)
        {
            labelName.Text = "Name: " + i_ChosenLocation.LocationName;
            labelPosts.Text = "Posts from this location: " + i_ChosenLocation.NumOfPosts;
            labelCheckins.Text = "Checkins from this location: " + i_ChosenLocation.NumOfCheckins;
            labelPhotos.Text = "Photos from this location: " + i_ChosenLocation.NumOfTaggedPhotos;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StartApp.MainPage.Visible = true;
        }

        private void listBoxLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLocations.SelectedItems.Count == 1)
            {
                VisitedLocation chosenLocation = listBoxLocations.SelectedItem as VisitedLocation;
                updateStatistics(chosenLocation);
            }
        }

        private void PictureBoxAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Welcome to Location Map!
With this feature you can see your latest locations,
see statistics about them
and even see them on Google Maps.");
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                m_SortMethod = m_radioButtonsMethods[radioButton.Name];
                loadLocationsList();
            }
        }
    }
}
