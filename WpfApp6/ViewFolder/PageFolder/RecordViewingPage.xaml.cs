using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp6.Class;
using WpfApp6.Models;

namespace WpfApp6.ViewFolder.PageFolder
{
    public partial class RecordViewingPage : Page
    {
        public RecordViewingPage()
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

        private void RecordButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text == "" || SurnameTextBox.Text == "" || FullYearsTextBox.Text == "" ||
                DateViewDatePicker.Text == "" || NumberPhoneTextBox.Text == "" || NumberMaintainerTextBox.Text == "")
            {
                MessageBox.Show(
                        "Невозможно сделать запись, так как нужные поля пустые", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                EventMakeRecord();
            }
        }

        private void EventMakeRecord()
        {
            /// Тот метод который был, он годится для редактирования информации, что-то типо того, что пользователю доступно
            /// изменить 5 атрибутов, а в БД 12 атрибутов. В данном случае, нужно вводить все данные.
            try
            {
                Vieviw vieviw = new Vieviw()
                {
                    Name = NameTextBox.Text,
                    Surname = SurnameTextBox.Text,
                    Full_years = FullYearsTextBox.Text,
                    Datevieviwing = (DateTime)DateViewDatePicker.SelectedDate,
                    Phone = NumberPhoneTextBox.Text,
                    Phonemaintainers = NumberMaintainerTextBox.Text
                };

                AppConnectClass.AppData.Vieviw.Add(vieviw);
                AppConnectClass.AppData.SaveChanges();

                MessageBox.Show(
                    "Запись создана!", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Information);

                FrameNavigationClass.bodyFrameClass.Navigate(new PupilsPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message.ToString(), "Error Exception",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
