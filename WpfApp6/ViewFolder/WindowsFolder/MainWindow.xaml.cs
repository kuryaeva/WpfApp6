using System.Windows;
using WpfApp6.Class;
using WpfApp6.ViewFolder.PageFolder;

namespace WpfApp6.ViewFolder.WindowsFolder
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameNavigationClass.menuFrameClass = MenuFrame;
            FrameNavigationClass.bodyFrameClass = BodyFrame;

            FrameNavigationClass.bodyFrameClass.Navigate(new AuthorizationPage());
        }
    }
}
