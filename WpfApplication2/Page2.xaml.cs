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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public bool show = false;
        public Page2()
        {
            InitializeComponent();
            updatetext();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            //tb.GotFocus -= textBox_GotFocus;
        }
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("Page1.xaml", UriKind.Relative));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void toCheq(object sender, RoutedEventArgs e)
        {
            int value;
            if (int.TryParse(textBox.Text, out value))
            {
                if (MainWindow.saving >= value)
                {
                    MainWindow.saving -= value;
                    MainWindow.chequing += value;
                    updatetext();
                    status.Content = "Transferred to Chequing";
                }
                else
                {
                    status.Content = "Insufficient Funds in Savings";
                }
            }
            else
            {
                status.Content = "Input an amount please";
                //parsing failed. 
            }
            textBox.Text = "$ ";
        }

        private void updatetext()
        {
            if (show)
            {
                String temp = String.Concat("Chequing: $", MainWindow.chequing.ToString());
                temp = String.Concat(temp, "\nSavings: $");
                temp = String.Concat(temp, MainWindow.saving.ToString());
                balancelabel.Content = temp;
            }
            else
                balancelabel.Content = "Chequing: HIDDEN\nSaving: HIDDEN";

        }

        private void toSaving(object sender, RoutedEventArgs e)
        {
            int value;
            if (int.TryParse(textBox.Text, out value))
            {
                if (MainWindow.chequing >= value)
                {
                    MainWindow.chequing -= value;
                    MainWindow.saving += value;
                    updatetext();
                    status.Content = "Transferred to Savings";
                }
                else
                {
                    status.Content = "Insufficient Funds in Chequing";
                }
            }
            else
            {
                status.Content = "Input an amount please";
                //parsing failed. 
            }
            textBox.Text = "$ ";
        }

        private void showhide(object sender, RoutedEventArgs e)
        {
            show = !show;
            if (show)
                updatetext();

            else
                balancelabel.Content = "Chequing: HIDDEN\nSaving: HIDDEN";
            
        }
    }
}
