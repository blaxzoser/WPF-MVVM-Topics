using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace Samples.MVVM.Scenarios.Medium
{
    /// <summary>
    /// Interaction logic for ResourcesScenario.xaml
    /// </summary>
    public partial class ResourcesScenario : Window
    {
        public ResourcesScenario()
        {
            InitializeComponent();
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Samples.MVVM.Resources.Image.sample3.jpg";

            //string[] resourceNames = assembly.GetManifestResourceNames();

            Stream stream = assembly.GetManifestResourceStream(resourceName);
            byte[] result = new byte[stream.Length];
            stream.Read(result, 0, result.Length);
            image.Source = LoadImage(result);


        }

        private BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0)
                return null;
            var image = new BitmapImage();
            using(var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }

        /// <summary>
        /// it's only for lab propose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.Resources["localColorBrush"] = new SolidColorBrush(Colors.Pink);
            lblStaticResource.Background = new SolidColorBrush(Colors.Pink);
            var localColorBrush = new SolidColorBrush(Colors.Pink);
        }


    }
}
