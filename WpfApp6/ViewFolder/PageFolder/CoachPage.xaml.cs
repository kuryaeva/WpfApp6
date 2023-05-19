using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp6.Class;
using WpfApp6.Models;

namespace WpfApp6.ViewFolder.PageFolder
{
    public partial class CoachPage : Page
    {
        public CoachPage()
        {
            try
            {
                InitializeComponent();
                AppConnectClass.AppData = new TorpedoEntities1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message.ToString(), "Error Exception",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BackHyperlink_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigationClass.bodyFrameClass.Navigate(new PupilsPage());
        }
    }
}
