using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Firebrand.Demos.Demo23_AsyncAwait
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

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
            Task.Factory.StartNew(() => ExecuteLongRunningJob("Sam"));

            lblMessage.Content = ExecuteLongRunningJob("Sam");
        }

        private void UpdateButton(string name)
        {
            var result = ExecuteLongRunningJob(name);
            lblMessage.Content = result;
        }

        private string ExecuteLongRunningJob(string name)
        {
            Thread.Sleep(10000);
            return "Hello, " + name;
        }
    }
}
