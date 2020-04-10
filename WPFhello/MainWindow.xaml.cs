using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            peopleListBox.Items.Add(james);

            ListBoxItem david = new ListBoxItem();
            david.Content = "James";
            peopleListBox.Items.Add(david);

            peopleListBox.SelectedItem = james;
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            String inputResult = "";

            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    inputResult = inputResult + ((TextBox)item).Text;
                    inputResult = inputResult + '\n';
                }
            }
            if (txtName1.Text.Length < 2)
            {
                MessageBox.Show("Името " + txtName1.Text + " не отговаря на условията (поне 2 симбола).");
            }
            if (txtName2.Text.Length < 2)
            {
                MessageBox.Show("Името " + txtName2.Text + " не отговаря на условията (поне 2 симбола).");
            }
            if (txtName3.Text.Length < 2)
            {
                MessageBox.Show("Името " + txtName3.Text + " не отговаря на условията (поне 2 симбола).");
            }

            MessageBox.Show("Здравей " + inputResult + " \nТова е твоята първа програма на Visual Studio 2012!");
        }
        void Window_Closing(object sender, CancelEventArgs e)
        {
            string msg = "Сигурни ли сте че искате да излезете?";
            MessageBoxResult result = MessageBox.Show(msg, "HelloWPF", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyMessage anotherWindow = new MyMessage();
            anotherWindow.Show();
            textBlock1.Text = DateTime.Now.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string greetingMsg;
            greetingMsg = (peopleListBox.SelectedItem as ListBoxItem).Content.ToString();
            MessageBox.Show("Hi, " + greetingMsg);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int n, y;
            int m = 1;

            n = int.Parse(nText.Text);
            y = int.Parse(nText_Copy.Text);
            if (n <= 0 || y <= 0)
            {
                MessageBox.Show("N и Y трябва да са по-голями от 0.");
            }
            else
            {
                int f = 1;
                for (int i = 1; i <= n; i++)
                {
                    f = f * i;
                }
                for (int i = 1; i <= y; i++)
                {
                    m = m * n;
                }

                MessageBox.Show("Factorial of N = " + f + "\nN^Y =" + m + ".");
            }
        }
    }
}
