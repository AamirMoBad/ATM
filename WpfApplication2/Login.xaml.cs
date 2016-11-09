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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checklog(object sender, RoutedEventArgs e)
        {
            
            if(textBox.Text == "789")
            {
                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new Uri("Page1.xaml", UriKind.Relative));
            }
            else
            {
                label1.Content = "Invalid Account Number. Please Try Again.";
            }
            textBox.Text = "Account Number";
        }

        private void textBox_GotFocus_1(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("Page1.xaml", UriKind.Relative));
        }
    }
}
