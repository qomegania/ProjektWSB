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

namespace RCP_Client
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string auth_string
        {
            get;
            set;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string temp = textBox_login.Text + ";" + textBox_passwd.Text;
            string crypto_temp = temp;
            auth_string = temp;

            LogIn client = new LogIn(textBox_login.Text, textBox_passwd.Text);

        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
