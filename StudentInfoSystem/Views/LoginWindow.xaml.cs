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
using UserLogin;

namespace StudentInfoSystem
{
    // USERNAME i PAROLA ZA TESTVANE
    //Username: Hristijan | parola: qwerty
    //ili Username: Milosh | parola: asdfg

    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        public static String temp;

        private void LoginButton(object sender, RoutedEventArgs e)
        {
            User user = new User();
            LoginWindow lv = new LoginWindow();
            LoginValidation loginValidation = new LoginValidation(nameBox.Text, passwordBox.Text, printError);

            temp = nameBox.Text;

            if (loginValidation.ValidateUserInput(ref user))
            {
                this.Close();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Грешни данни.");
                nameBox.Text = String.Empty;
                passwordBox.Text = String.Empty;
            }
        }
        public static void printError(String message)
        {
            Console.WriteLine(message);
        }
    }
}
