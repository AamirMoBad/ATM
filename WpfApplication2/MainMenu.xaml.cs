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
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void withdraw_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("WithdrawPage.xaml", UriKind.Relative));
        }

        private void deposit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("WithdrawPage.xaml", UriKind.Relative));

           
        }

        private void balance_Click(object sender, RoutedEventArgs e)
        {
            BalanceWindow win2 = new BalanceWindow();
            win2.Show();
        }

        private void transferFunds_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("TransferFundsPage.xaml", UriKind.Relative));
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.chequingBalance = 100;
            MainWindow.savingBalance = 100;
            MainWindow.totalBalance = MainWindow.chequingBalance + MainWindow.savingBalance;

            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("Login.xaml", UriKind.Relative));
        }
    }
}
