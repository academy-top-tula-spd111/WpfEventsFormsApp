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

namespace WpfEventsFormsApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox1.Background = new SolidColorBrush(Colors.Aqua);
        }

        private void textBox1_LostFocus(object sender, RoutedEventArgs e)
        {
            textBox1.Background = new SolidColorBrush(Colors.White);
        }
    }
}
