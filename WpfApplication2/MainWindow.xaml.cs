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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int chequing = 100, saving=100, balance=saving+chequing;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            WithdrawCheq win2 = new WithdrawCheq();
            win2.Show();
            this.Close();
        }
        private void button_copy_Click(object sender, RoutedEventArgs e)
        {
            WithdrawSav win2 = new WithdrawSav();
            win2.Show();
            this.Close();
        }

        private void balance_Click(object sender, RoutedEventArgs e)
        {
            WithdrawSav win2 = new WithdrawSav();
            win2.Show();
            this.Close();
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
