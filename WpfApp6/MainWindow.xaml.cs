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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AvtorizB_Click(object sender, RoutedEventArgs e)

        {
            var user = AppConnect.database.Admin.ToList().FirstOrDefault(p => p.Login == LoginTB.Text && p.Password == PasswordTb.Text);
            if(user != null)
            {
                Window1 window1 = new Window1();
                window1.Show();
            } else
            {
                MessageBox.Show("Пользователь не найден!");
            }
            

        }
    }
}
