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
    /// Interaction logic for DepositPage.xaml
    /// </summary>
    public partial class DepositPage : Page
    {
        public static int accountSelect;
        DepoCashWindow hardDeposit;

        public DepositPage()
        {
            InitializeComponent();
            accountSelect = 0;
            hardDeposit = new DepoCashWindow();
        }

        // Goes back to Main Menu
        public void back_Click(object sender, RoutedEventArgs e)
        {
            hardDeposit.Hide();
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
                hardDeposit.Show();
                hardDeposit.button1.IsEnabled = true;
            }
            // Checkings account selected
            else if (Account_comboBox.SelectedIndex == 2)
            {
                updateBalance(MainWindow.chequingBalance);
                accountSelect = 2;
                hardDeposit.Show();
                hardDeposit.button1.IsEnabled = true;
            }
            else
            {
                balanceAmountLabel.Content = "--------";
                hardDeposit.button1.IsEnabled = false;
            }
        }

        private void updateBalance(double balance)
        {
            balanceAmountLabel.Content = "$" + balance.ToString() + ".00";
        }
    }
}
