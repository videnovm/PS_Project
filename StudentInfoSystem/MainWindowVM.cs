using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using UserLogin;

namespace StudentInfoSystem
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        private bool enabled = true;
       
        private Student student;

        public Student Student
        {
            get { return student; }
            set { student = value; OnPropertyChanged("Student"); }
        }

        public bool EnableControls
        {
            get { return enabled; }
            set
            {
                enabled = value;
                OnPropertyChanged(nameof(EnableControls));
            }
        }
        public MainWindowVM (Student student, MainWindow main)
        {
            if (student == null)
            {
                student = new Student();
                main = new MainWindow();
                LoadStudentData(main);
            }
           
            
            Student = student;
            LoadStudentData(main);
        }

        public MainWindowVM()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
       
        public ICommand LoadStudentDataCommand
        {
            get { return new RelayCommand(LoadStudentData); }
        }


        private void LoadStudentData(MainWindow main)
        {;
            main.nameBox.Text = Student.FirstName;
            main.prezimeBox.Text = Student.LastName;
            main.familyBox.Text = Student.FamilyName;
            main.facultyBox.Text = Student.Faculty;
            main.specialityBox.Text = Student.Specialty;
            main.levelBox.Text = Student.Level;
            main.statusBox.Text = Student.Status.ToString();
            main.courseBox.Text = Student.Course.ToString();
            main.potokBox.Text = Student.Potok.ToString();
            main.groupBox.Text = Student.Group.ToString();
            main.fakNoBox.Text = Student.FakNo.ToString();
        }

        public ICommand ClearStudentDataCommand
        {
            get { return new RelayCommand(ClearStudentData); }
        }

        private void ClearStudentData()
        {
            this.Student = new Student();
            MessageBox.Show("Dannite sa izchisteni!");
        }

        public ICommand DisableEditCommand
        {
            get { return new RelayCommand(DisableEdit); }
        }

        private void DisableEdit()
        {
            EnableControls = false;
           // MessageBox.Show("Ne moye edit!");
        }

        public ICommand EnableEditCommand
        {
            get { return new RelayCommand(EnableEdit); }
        }

        private void EnableEdit()
        {
            EnableControls = true;
        }

        private void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
