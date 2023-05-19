using System.Linq;
using System.Windows;
using WpfApp6.Class;
using WpfApp6.Models;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
            AppConnectClass.AppData = new TorpedoEntities1();
            PuplisListBox.ItemsSource = AppConnectClass.AppData.Puplis.ToList();
        }

        private void Sorevend_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
