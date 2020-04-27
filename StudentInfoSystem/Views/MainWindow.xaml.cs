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

namespace StudentInfoSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.Title = "Студентска информационна система";
        }
        /*
        private void RemoveContentButton(object sender, RoutedEventArgs e)
        {
            foreach (var item in this.FirstGroupGrid.Children)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Text = " ";
                }
            }
            foreach (var item in this.SecondGroupGrid.Children)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Text = " ";
                }
            }
        }

        private void FillInfoButton(object sender, RoutedEventArgs e)
        {
            StudentData sd = new StudentData();
            sd.TestStudents();
            for (int i = 0; i < sd._TestStudents.Count; i++)
            {
                if(sd._TestStudents.ElementAt(i).name.Equals(LoginWindow.temp))
                {
                    nameBox.Text = sd._TestStudents.ElementAt(i).name;
                    prezimeBox.Text = sd._TestStudents.ElementAt(i).lastName;
                    familyBox.Text = sd._TestStudents.ElementAt(i).familyName;
                    facultyBox.Text = sd._TestStudents.ElementAt(i).faculty;
                    specialityBox.Text = sd._TestStudents.ElementAt(i).specialty;
                    levelBox.Text = sd._TestStudents.ElementAt(i).level;
                    statusBox.Text = sd._TestStudents.ElementAt(i).status.ToString();
                    fakNoBox.Text = sd._TestStudents.ElementAt(i).fakNo;
                    courseBox.Text = sd._TestStudents.ElementAt(i).course;
                    potokBox.Text = sd._TestStudents.ElementAt(i).potok;
                    groupBox.Text = sd._TestStudents.ElementAt(i).group;
                }
            }
        }

        private void DisableButton(object sender, RoutedEventArgs e)
        {
            foreach (var item in this.FirstGroupGrid.Children)
            {
                if (item is TextBox)
                {
                    (item as TextBox).IsEnabled = false;
                }
            }
            foreach (var item in this.SecondGroupGrid.Children)
            {
                if (item is TextBox)
                {
                    (item as TextBox).IsEnabled = false;
                }
            }
        }

        private void EnableButton(object sender, RoutedEventArgs e)
        {
            foreach (var item in this.FirstGroupGrid.Children)
            {
                if (item is TextBox)
                {
                    (item as TextBox).IsEnabled = true;
                }
            }
            foreach (var item in this.SecondGroupGrid.Children)
            {
                if (item is TextBox)
                {
                    (item as TextBox).IsEnabled = true;
                }
            }
        }
        */
    }
}
