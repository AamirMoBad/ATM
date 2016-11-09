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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            

            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("Chequing.xaml", UriKind.Relative));

            //WithdrawCheq win2 = new WithdrawCheq();
            //win2.Show();
            //this.Close();
        }
        private void depocash(object sender, RoutedEventArgs e)
        { 

            DepoCashWindow win2 = new DepoCashWindow();
            win2.Show();
            //this.Close();
        }

        private void button_copy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("Savings.xaml", UriKind.Relative));

            //WithdrawSav win2 = new WithdrawSav();
            //win2.Show();
            //this.Close();
        }

        private void balance_Click(object sender, RoutedEventArgs e)
        {
            BalanceWindow win2 = new BalanceWindow();
            win2.Show();
        }

        private void depocheq(object sender, RoutedEventArgs e)
        {
            DepoChqWindow win2 = new DepoChqWindow();
            win2.Show();
        }

        private void transfer(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("Page2.xaml", UriKind.Relative));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.chequing = 100;
            MainWindow.saving = 100;
            MainWindow.balance = MainWindow.chequing + MainWindow.saving;

            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("Login.xaml", UriKind.Relative));
        }
    }
}
