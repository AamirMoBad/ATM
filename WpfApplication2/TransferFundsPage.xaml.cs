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
    /// Interaction logic for TransferFunds.xaml
    /// </summary>
    /// 
    public partial class TransferFunds : Page
    {
        int accountSelect,accountSelect2;
        double transferAmount;

        public TransferFunds()
        {
            InitializeComponent();
            accountSelect = 0;
            accountSelect2 = 0;
            transferAmount = 0;

        }

        // Goes back to Main Menu
        public void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("MainMenu.xaml", UriKind.Relative));

        }

        // For first combobox
        private void account_DropDownClosed(object sender, EventArgs e)
        {

            // Savings account selected
            if (Account_comboBox.SelectedIndex == 1)
            {
                updateBalance(MainWindow.savingBalance,1);
                accountSelect = 1;
            }
            // Checkings account selected
            else if (Account_comboBox.SelectedIndex == 2)
            {
                updateBalance(MainWindow.chequingBalance,1);
                accountSelect = 2;
            }
            else
            {
                balanceAmountLabel.Content = "--------";
            }
        }

        // For second combobox
        private void account_DropDownClosed2(object sender, EventArgs e)
        {
            // Savings account selected
            if (Account_comboBox2.SelectedIndex == 1)
            {
                updateBalance(MainWindow.savingBalance, 2);
                accountSelect2 = 1;
            }
            // Checkings account selected
            else if (Account_comboBox2.SelectedIndex == 2)
            {
                updateBalance(MainWindow.chequingBalance, 2);
                accountSelect2 = 2;
            }
            else
            {
                balanceAmountLabel2.Content = "--------";
            }
        }

        // Updates balance displays
        private void updateBalance(double balance,int comboBox)
        {
            if (comboBox == 1)
            {
                balanceAmountLabel.Content = "$" + balance.ToString();
            }
            else if (comboBox == 2)
            {
                balanceAmountLabel2.Content = "$" + balance.ToString();
            }
        }

        // Transfers the specified of amount of money
        private void transfer_Click(object sender, RoutedEventArgs e)
        {
            if (transferAmount_TextBox.Text.Equals("$0.00"))
            {
                error_Label.Content = "Please input a value";                
            }
            else if (transferAmount_TextBox.Text.Equals(string.Empty)){
                error_Label.Content = "Please input a value";               
            }
            else if (Convert.ToDouble(transferAmount_TextBox.Text) <= 0)
            {
                error_Label.Content = "Please input a value greater than 0";
                
            }
            else if (accountSelect == 0 || accountSelect2 == 0)
            {
                error_Label.Content = "Please specify the accounts for the transaction";          
            }
            else if (accountSelect == accountSelect2)
            {
                error_Label.Content = "You cannot transfer to the same account";
            } 
            else if ((Convert.ToDouble(transferAmount_TextBox.Text) > MainWindow.savingBalance && accountSelect == 1) || (Convert.ToDouble(transferAmount_TextBox.Text) > MainWindow.chequingBalance && accountSelect == 2))
            {
                error_Label.Content = "You do not have enough funds";
            }
            else
            {
                error_Label.Content = "";
                // Rounds to the 2nd decimal place
                transferAmount = Math.Round(Convert.ToDouble(transferAmount_TextBox.Text), 2);

                // Transfers and updates balances
                if (accountSelect == 1 && accountSelect2 == 2)
                {
                    MainWindow.savingBalance -= transferAmount;
                    MainWindow.chequingBalance += transferAmount;

                    updateBalance(MainWindow.savingBalance, 1);
                    updateBalance(MainWindow.chequingBalance, 2);

                    ErrorWindow success = new ErrorWindow("You have transferred $" + (transferAmount) + "\nfrom savings to chequing");
                    success.Show();

                }
                else if (accountSelect == 2 && accountSelect2 == 1)
                {
                    MainWindow.savingBalance += transferAmount;
                    MainWindow.chequingBalance -= transferAmount;

                    updateBalance(MainWindow.savingBalance, 2);
                    updateBalance(MainWindow.chequingBalance, 1);

                    ErrorWindow success = new ErrorWindow("You have transferred $" + (transferAmount) + "\nfrom chequing to savings");
                    success.Show();
                }
            }
        }

        private void transferAmount_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
        }


    }
}
