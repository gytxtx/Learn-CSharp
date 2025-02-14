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

            Window_Test Window_Test = new Window_Test();

            Window_Test.Show();

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (SnackbarThree.MessageQueue is { } messageQueue)
            {
                // Use the message queue to send a message.
                var message = "Hello, World!";
                // The message queue can be called from any thread.
                Task.Factory.StartNew(() => messageQueue.Enqueue(message));
            }
        }
    }

}