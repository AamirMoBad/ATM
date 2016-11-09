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
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for DepoChqWindow.xaml
    /// </summary>
    public partial class DepoChqWindow : Window
    {
        public DepoChqWindow()
        {
            InitializeComponent();
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
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int value;
            if (int.TryParse(textBox.Text, out value))
            {
                MainWindow.saving = MainWindow.saving + value;
                MainWindow.balance = MainWindow.balance + value;
            }
            else
            {
                
                //parsing failed. 
            }

           
            this.Close();
        }
    }
}
