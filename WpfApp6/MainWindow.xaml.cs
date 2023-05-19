using System.Linq;
using System.Windows;
using WpfApp6.Class;

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
            var user = AppConnectClass.AppData.Admin.ToList().FirstOrDefault(p => p.Login == LoginTB.Text && p.Password == PasswordTb.Text);
            if (user != null)
            {

            }
            else
            {
                MessageBox.Show("Пользователь не найден!");
            }


        }
    }
}
