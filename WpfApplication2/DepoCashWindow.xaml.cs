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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for DepoCashWindow.xaml
    /// </summary>
    public partial class DepoCashWindow : Window
    {
        public static int input = 0;
        public DepoCashWindow()
        {
            InitializeComponent();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.saving = MainWindow.saving + input;
            MainWindow.balance = MainWindow.balance + input;
            input = 0;
            this.Close();
        }

        private void add5(object sender, RoutedEventArgs e)
        {
            input += 5;
            updateText();
        }

        private void add10(object sender, RoutedEventArgs e)
        {
            input += 10;
            updateText();
        }

        private void add20(object sender, RoutedEventArgs e)
        {
            input += 20;
            updateText();
        }

        private void add50(object sender, RoutedEventArgs e)
        {
            input += 50;
            updateText();
        }

        private void updateText()
        {
            String temp = String.Concat("$ ", input.ToString());
            label1.Content = temp;
            //throw new NotImplementedException();
        }
    }
}
