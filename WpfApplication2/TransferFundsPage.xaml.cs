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
            accountSelect = 0;
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

        private void updateBalance(int balance,int comboBox)
        {
            if (comboBox == 1)
            {
                balanceAmountLabel.Content = "$" + balance.ToString() + ".00";
            }
            else if (comboBox == 2)
            {
                balanceAmountLabel2.Content = "$" + balance.ToString() + ".00";
            }
        }

        private void transfer_Click(object sender, RoutedEventArgs e)
        {

        }

        // For second combobox
        private void account_DropDownClosed2(object sender, EventArgs e)
        {
            // Savings account selected
            if (Account_comboBox2.SelectedIndex == 1)
            {
                updateBalance(MainWindow.savingBalance,2);
                accountSelect2 = 1;
            }
            // Checkings account selected
            else if (Account_comboBox2.SelectedIndex == 2)
            {
                updateBalance(MainWindow.chequingBalance,2);
                accountSelect2 = 2;
            }
            else
            {
                balanceAmountLabel2.Content = "--------";
            }
        }

        
    }
}
