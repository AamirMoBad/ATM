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
    /// Interaction logic for WithdrawPage.xaml
    /// </summary>
    public partial class WithdrawPage : Page
    {
        // 0 = no account selected, 1 = savings account selected, 2 = chequing account selected
        int accountSelect;

        public WithdrawPage()
        {
            InitializeComponent();
            accountSelect = 0;
        }

        // Goes back to Main Menu
        public void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("MainMenu.xaml", UriKind.Relative));

        }

        private void account_DropDownClosed(object sender, EventArgs e)
        {

            // Savings account selected
            if (Account_comboBox.SelectedIndex == 1)
            {
                updateBalance(MainWindow.savingBalance);
                accountSelect = 1;
            }
            // Checkings account selected
            else if (Account_comboBox.SelectedIndex == 2)
            {
                updateBalance(MainWindow.chequingBalance);
                accountSelect = 2;
            }
            else
            {
                balanceAmountLabel.Content = "--------";
            }

        }

        private void updateBalance(int balance)
        {
            balanceAmountLabel.Content = "$" + balance.ToString() + ".00";
        }


        private void withdraw10_Click(object sender, RoutedEventArgs e)
        {
            if (accountSelect == 1)
            {
                MainWindow.savingBalance -= 10;
                updateBalance(MainWindow.savingBalance);
            }
            else if (accountSelect == 2)
            {
                MainWindow.chequingBalance -= 10;
                updateBalance(MainWindow.chequingBalance);
            }
            else
            {

            }
        }
    
        private void withdraw20_Click(object sender, RoutedEventArgs e)
        {
            if (accountSelect == 1)
            {
                MainWindow.savingBalance -= 20;
                updateBalance(MainWindow.savingBalance);
            }
            else if (accountSelect == 2)
            {
                MainWindow.chequingBalance -= 20;
                updateBalance(MainWindow.chequingBalance);
            }
            else
            {

            }
        }

        private void withdraw50_Click(object sender, RoutedEventArgs e)
        {
            if (accountSelect == 1)
            {
                MainWindow.savingBalance -= 50;
                updateBalance(MainWindow.savingBalance);
            }
            else if (accountSelect == 2)
            {
                MainWindow.chequingBalance -= 50;
                updateBalance(MainWindow.chequingBalance);
            }
            else
            {

            }
        }

        private void withdraw100_Click(object sender, RoutedEventArgs e)
        {
            if (accountSelect == 1)
            {
                MainWindow.savingBalance -= 100;
                updateBalance(MainWindow.savingBalance);
            }
            else if (accountSelect == 2)
            {
                MainWindow.chequingBalance -= 100;
                updateBalance(MainWindow.chequingBalance);
            }
            else
            {

            }
        }

        private void withdraw200_Click(object sender, RoutedEventArgs e)
        {
            if (accountSelect == 1)
            {
                MainWindow.savingBalance -= 200;
                updateBalance(MainWindow.savingBalance);
            }
            else if (accountSelect == 2)
            {
                MainWindow.chequingBalance -= 200;
                updateBalance(MainWindow.chequingBalance);
            }
            else
            {

            }
        }

        private void withdraw500_Click(object sender, RoutedEventArgs e)
        {
            if (accountSelect == 1)
            {
                MainWindow.savingBalance -= 500;
                updateBalance(MainWindow.savingBalance);
            }
            else if (accountSelect == 2)
            {
                MainWindow.chequingBalance -= 500;
                updateBalance(MainWindow.chequingBalance);
            }
            else
            {

            }
        }
    }
}
