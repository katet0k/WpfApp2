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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordBox.Password;

            bool isValidCredentials = IsValidCredentials(username, password);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                if (string.IsNullOrEmpty(username))
                {
                    usernameValidationTextBlockL.Text = "Поле username повинно бути заповненим!";
                }
                if (string.IsNullOrEmpty(password))
                {
                    usernameValidationTextBlockP.Text = "Поле password повинно бути заповненим!";
                }
                else
                {
                    usernameValidationTextBlockL.Text = string.Empty;
                    usernameValidationTextBlockP.Text = string.Empty;
                }
            }
            else if (!isValidCredentials)
            {
                usernameValidationTextBlockP.Text = "Невірний пароль!";
            }
            else
            {
                usernameValidationTextBlockL.Text = string.Empty; 
                usernameValidationTextBlockP.Text = string.Empty;
            }
        }

        private bool IsValidCredentials(string username, string password)
        {
            return username == "admin" && password == "admin";
        }
    }

    }

