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
using WpfApp6.Class;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            FrameNavigationClass.menuFrameClass = MenuFrame;
            FrameNavigationClass.bodyFrameClass = BodyFrame;
        }

        private void EndB_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void DOBVOSPITAN_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void RasB_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window7 window7 = new Window7();
            window7.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //FrameNavigationClass.bodyFrameClass.Navigate(new Puplis());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window8 window8 = new Window8();
            window8.Show();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
