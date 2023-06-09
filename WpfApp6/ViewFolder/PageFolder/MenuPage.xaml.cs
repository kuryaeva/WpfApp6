﻿using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp6.Class;

namespace WpfApp6.ViewFolder.PageFolder
{
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message.ToString(), "Error Exception",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PupilsButton_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigationClass.bodyFrameClass.Navigate(new PupilsPage());
        }

        private void CoachButton_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigationClass.bodyFrameClass.Navigate(new CoachPage());
        }

        private void ApplicationEnrollmentButton_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigationClass.bodyFrameClass.Navigate(new ApplicationEnrollmentPage());
        }

        private void ViewingScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigationClass.bodyFrameClass.Navigate(new ViewingSchedulePage());
        }

        private void EquipmentAccountingButton_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigationClass.bodyFrameClass.Navigate(new EquipmentAccountingPage());
        }
    }
}
