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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }
        
        private void Otprav_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Name.Text) && !string.IsNullOrWhiteSpace(Surname.Text)
               && !string.IsNullOrWhiteSpace(Secondname.Text) && !string.IsNullOrWhiteSpace(Nameschool.Text)
                && !string.IsNullOrWhiteSpace(Adress.Text) && (!string.IsNullOrWhiteSpace(Nameparent.Text) && 
                !string.IsNullOrWhiteSpace(Surnameparent.Text) && !string.IsNullOrWhiteSpace(Secondnameparent.Text) && !string.IsNullOrWhiteSpace(Work.Text)
                && !string.IsNullOrWhiteSpace(Phoneparent.Text) && DateDP.SelectedDate != null))

                {
                    Enrollment enrollment = new Enrollment();
                    enrollment.Name = Name.Text;
                    enrollment.Surname = Surname.Text;
                    enrollment.Secondname = Secondname.Text;
                    enrollment.DateBirth = (DateTime)DateDP.SelectedDate;
                    enrollment.Adress = Adress.Text;
                    enrollment.Nameschool = Nameschool.Text;
                    enrollment.Nameparent = Nameparent.Text;
                    enrollment.Surname = Surnameparent.Text;
                    enrollment.Secondname = Secondname.Text;
                    enrollment.Placeofwork = Work.Text;
                    enrollment.Phone = Phoneparent.Text;
                   

                    AppConnect.database.Enrollment.Add(enrollment);
                    AppConnect.database.SaveChanges();
                    


                    MessageBox.Show("Заявка отправлена!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Сначала заполните все поля!");
                }

        }
        
        
        

        private void Endz_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
    }
}
