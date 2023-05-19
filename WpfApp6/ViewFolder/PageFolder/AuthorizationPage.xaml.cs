using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfApp6.Class;
using WpfApp6.Models;

namespace WpfApp6.ViewFolder.PageFolder
{
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
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

        private void EventSuccessfulAuthorization()
        {
            FrameNavigationClass.menuFrameClass.Navigate(new MenuPage());
            FrameNavigationClass.bodyFrameClass.Navigate(new PupilsPage());
        }

        private void EventAuthorizationUser()
        {
            var user = AppConnectClass.AppData.Admin.FirstOrDefault(
                p => p.Login == LoginTextBox.Text &&
                p.Password == PasswoedPasswprdBox.Password);

            if (user != null)
            {
                EventSuccessfulAuthorization();
            }
            else
            {
                MessageBox.Show(
                    "Пользователь не найден", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text == "" || PasswoedPasswprdBox.Password == "")
            {
                MessageBox.Show(
                    "Поля для авторизации не должны быть пустыми", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                EventAuthorizationUser();
            }
        }
    }
}
