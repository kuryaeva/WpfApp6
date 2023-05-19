using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp6.Class;
using WpfApp6.Models;

namespace WpfApp6.ViewFolder.PageFolder
{
    public partial class ApplicationEnrollmentPage : Page
    {
        public ApplicationEnrollmentPage()
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

        private void SendRequestButton_Click(object sender, RoutedEventArgs e)
        {
            if (SurnameChildTextBox.Text == "" || NameChildTextBox.Text == "" || MiddlenameChildTextBox.Text == "" ||
                DateOfBrochChildDatePicker.Text == "" || AdresAccommodationChildTextBox.Text == "" || NameEducationalInstitutionChildTextBox.Text == "")
            {
                MessageBox.Show(
                    "Строки в 'Сведения о ребенке' не должны быть пустыми", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (SurnameParentTextBox.Text == "" || NameParentTextBox.Text == "" || MiddlenameParentTextBox.Text == "" ||
                    PlaceWorkParentTextBox.Text == "" || NumberPhoneParentTextBox.Text == "" ||
                    (MotherParentRadioButton.IsChecked == false || DadParentRadioButton.IsChecked == false))
                {
                    MessageBox.Show(
                   "Строки в 'Сведения о родителе' не должны быть пустыми", "Error",
                   MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    EventWritingDatabase();
                }
            }
        }

        private void EventWritingDatabase()
        {
            try
            {
                Enrollment enrollment = new Enrollment() // Проверь БД пожалуйста
                {
                    Name = NameChildTextBox.Text,
                    Surname = SurnameChildTextBox.Text,
                    Secondname = MiddlenameChildTextBox.Text,
                    DateBirth = (DateTime)DateOfBrochChildDatePicker.SelectedDate,
                    Adress = AdresAccommodationChildTextBox.Text,
                    Nameschool = NameEducationalInstitutionChildTextBox.Text,

                    Nameparent = NameParentTextBox.Text,
                    Surnameparent = SurnameParentTextBox.Text,
                    Secondnameparent = SurnameParentTextBox.Text,
                    /// Secondname --- мой реакция: "АААААаааааааааа?"
                    Placeofwork = PlaceWorkParentTextBox.Text,
                    Phone = NumberPhoneParentTextBox.Text
                };

                AppConnectClass.AppData.Enrollment.Add(enrollment);
                AppConnectClass.AppData.SaveChanges();

                MessageBox.Show(
                    "Заявка отправлена!", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Information);
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
