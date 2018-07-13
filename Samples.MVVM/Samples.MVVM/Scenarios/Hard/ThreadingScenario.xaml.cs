using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

namespace Samples.MVVM.Scenarios.Hard
{
    /// <summary>
    /// Interaction logic for ThreadingScenario.xaml
    /// </summary>
    public partial class ThreadingScenario : Window
    {
        public ThreadingScenario()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                HttpClient webclient = new HttpClient();
                var html = webclient.GetStringAsync("http://www.salon51.com.mx/").Result;
                txtResult.Dispatcher.Invoke(() =>
                {
                    txtResult.Text = "Done";
                });
            });
        }


        private async void btnUpdate_Click2(object sender, RoutedEventArgs e)
        {
            string result = string.Empty;
            await Task.Run(async () =>
            {
                HttpClient webclient = new HttpClient();
                var html = webclient.GetStringAsync("http://www.salon51.com.mx/").Result;
                result = html;
            });
            lblMessage.Content = result;
            txtResult.Text = "Done";
        }
    }
}
