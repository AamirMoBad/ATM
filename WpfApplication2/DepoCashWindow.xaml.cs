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
        int input;
        double input2;
        public DepoCashWindow()
        {
            InitializeComponent();
            input = 0;
            input2 = 0;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            input2 = Convert.ToDouble(label1.Text);
            if (DepositPage.accountSelect == 1)
            {
                MainWindow.savingBalance = MainWindow.savingBalance + input + input2;
            }
            else if (DepositPage.accountSelect == 2)
            {
                MainWindow.totalBalance = MainWindow.totalBalance + input + input2;
            }
            input = 0;
            input2 = 0;
            label1.Text = "0.00";
            updateText();
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

        private void add100(object sender, RoutedEventArgs e)
        {
            input += 100;
            updateText();
        }

        private void updateText()
        {
            String temp = String.Concat("$ ", input.ToString());
            totalCash.Content = temp;
        }
    }
}
