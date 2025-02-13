using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KMCL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // 处理 "返回" 按钮的点击事件
        private void ButtonGoBack_OnClick(object sender, RoutedEventArgs e)
        {
            // 这里写你的返回逻辑
            MessageBox.Show("返回按钮被点击");
        }

        // 处理 "导航栏" 按钮的点击事件
        private void ButtonBaseToggleNavigationDrawer_OnClick(object sender, RoutedEventArgs e)
        {
            // 这里写你的导航栏切换逻辑
            MessageBox.Show("导航栏按钮被点击");
        }
    }

}