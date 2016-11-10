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
    /// Interaction logic for PinVerificationPage.xaml
    /// </summary>
    public partial class PinVerificationPage : Page
    {
        public PinVerificationPage()
        {
            InitializeComponent();
        }

        public void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("Login.xaml", UriKind.Relative));

        }

        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Equals(MainWindow.pin)){
                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new Uri("MainMenu.xaml", UriKind.Relative));
                error_Label.Content = "";
            } else
            {
                error_Label.Content = "Wrong Pin. Please try again";
            }
        }
    }
}
