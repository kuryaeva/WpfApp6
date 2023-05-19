using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp6.Models;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void zap_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameTb.Text) && !string.IsNullOrWhiteSpace(SecondName.Text)
               && !string.IsNullOrWhiteSpace(Fullyears.Text) && !string.IsNullOrWhiteSpace(Phone.Text)
                && !string.IsNullOrWhiteSpace(PhoneTb.Text) && Datedp.SelectedDate != null)
            {
                Vieviw vieviw = new Vieviw();
                vieviw.Name = NameTb.Text;
                vieviw.Surname = SecondName.Text;
                vieviw.Full_years = Fullyears.Text;
                vieviw.Datevieviwing = (DateTime)Datedp.SelectedDate;
                vieviw.Phone = Phone.Text;
                vieviw.Phonemaintainers = PhoneTb.Text;

                AppConnect.database.Vieviw.Add(vieviw);
                AppConnect.database.SaveChanges();

                MessageBox.Show("Запись создана!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("Сначала заполните все поля!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EndH_Click(object sender, RoutedEventArgs e)
        {

            Window1 window1 = new Window1();
            window1.Show();
        }

        private void Phone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
