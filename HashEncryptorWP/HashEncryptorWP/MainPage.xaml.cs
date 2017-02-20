using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using HashEncryptorWP.Resources;

namespace HashEncryptorWP
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void btnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            HashEncrypt he = new HashEncrypt(this.tbMsg.Text, this.tbKey.Password);
            he.RunEncrypt();
            this.tbResultHex.Text = he.ResultHex;
            this.tbResultBase64.Text = he.ResultBase64;
            this.tbPassword.Text = (he.GetPassword());
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            this.tbMsg.Text = "";
            this.tbKey.Password = "";
            this.tbResultHex.Text = "";
            this.tbResultBase64.Text = "";
            this.tbPassword.Text = "";
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}