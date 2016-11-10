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

        private void updateBalance(double balance)
        {
            balanceAmountLabel.Content = "$" + balance.ToString() + ".00";
        }

        // Withdraws specified amount within reasonable limits
        public void withdraw(double amount) {
            if (accountSelect == 1)
            {
                if (amount > MainWindow.savingBalance)
                {
                    error_Label.Content = "You do not have enough funds";
                } else
                {
                    MainWindow.savingBalance -= amount;
                    updateBalance(MainWindow.savingBalance);

                    ErrorWindow success = new ErrorWindow("You have withdrawn $" + (amount) + "\nfrom your savings account");
                    success.Show();

                    error_Label.Content = "";
                }
            }
            else if (accountSelect == 2)
            {
                if (amount > MainWindow.chequingBalance)
                {
                    error_Label.Content = "You do not have enough funds";

                }
                else
                {
                    MainWindow.chequingBalance -= amount;
                    updateBalance(MainWindow.chequingBalance);

                    ErrorWindow success = new ErrorWindow("You have withdrawn $" + (amount) + "\nfrom your chequing account");
                    success.Show();

                    error_Label.Content = "";
                }
            } else if (accountSelect == 0)
            {
                error_Label.Content = "Please select an Account";
            }
        }

        public static void withdraw(double amount,int accountSelect)
        {
            if (accountSelect == 1)
            {
                MainWindow.savingBalance -= amount;

            }
            else if (accountSelect == 2)
            {
                MainWindow.chequingBalance -= amount;
            }    
        }

        private void withdraw10_Click(object sender, RoutedEventArgs e)
        {
            withdraw(10);
        }
    
        private void withdraw20_Click(object sender, RoutedEventArgs e)
        {
            withdraw(20);
        }

        private void withdraw50_Click(object sender, RoutedEventArgs e)
        {
            withdraw(50);
        }

        private void withdraw100_Click(object sender, RoutedEventArgs e)
        {
            withdraw(100);
        }

        private void withdraw200_Click(object sender, RoutedEventArgs e)
        {
            withdraw(200);
        }

        private void withdraw500_Click(object sender, RoutedEventArgs e)
        {
            withdraw(500);
        }
    }
}
