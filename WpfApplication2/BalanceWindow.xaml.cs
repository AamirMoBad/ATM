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
    /// Interaction logic for BalanceWindow.xaml
    /// </summary>
    public partial class BalanceWindow : Window
    {
        public BalanceWindow()
        {
            InitializeComponent();

            String temp = String.Concat("$ ", MainWindow.chequingBalance.ToString());
            label1.Content = temp;

            temp = String.Concat("$ ", MainWindow.savingBalance.ToString());
            label1_Copy.Content = temp;

            temp = String.Concat("$ ", MainWindow.totalBalance.ToString());
            label1_Copy1.Content = temp;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
