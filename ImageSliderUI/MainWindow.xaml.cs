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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageSliderUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int indexOfImage { get; set; } = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            indexOfImage--;
            if (indexOfImage < 1)
            {
                indexOfImage = 4;
            }

            picHolder.Source = new BitmapImage(new Uri(@"pics/" + indexOfImage + ".jpg", UriKind.Relative));
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            indexOfImage++;
            if (indexOfImage > 4)
            {
                indexOfImage = 1;
            }

            picHolder.Source = new BitmapImage(new Uri(@"pics/" + indexOfImage + ".jpg", UriKind.Relative));
        }
    }
}
