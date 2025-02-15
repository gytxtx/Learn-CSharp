using ClassIsland.ViewModels;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

namespace KMCL
{
    /// <summary>
    /// Window_Test.xaml 的交互逻辑
    /// </summary>
    public partial class Window_Test : Window
    {
        public WelcomeViewModel ViewModel { get; } = new();

        public Window_Test()
        {
            InitializeComponent();
            MessageBox.Show($"ViewModel.DialogId: {ViewModel.DialogId}");
            DataContext = ViewModel; // 必须设置 DataContext
        }
        //public WelcomeViewModel ViewModel
        //{
        //    get;
        //    set;
        //} = new();


        // private async void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        // private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        private async void Window_Closing(object? sender, CancelEventArgs e)
        {
            if (ViewModel.IsExitConfirmed) return;

            e.Cancel = true;

            // 使用 ViewModel 中的动态 DialogId
            var dialogId = ViewModel.DialogId;

            if (DialogHost.IsDialogOpen(dialogId)) return;

            var result = await DialogHost.Show(
                FindResource("ExitAppConfirmDialog"),
                dialogId // 使用绑定的动态标识符
            );

            if (result is true)
            {
                ViewModel.IsExitConfirmed = true;
                Close();
            }
        }
    }
}
