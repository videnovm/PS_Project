using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;
using System.ComponentModel;

namespace StudentInfoSystem
{
    public class Student : INotifyPropertyChanged
    {
        public String name;
        public String lastName;
        public String familyName;
        public String faculty;
        public String specialty;
        public String level;
        public String status;
        public String fakNo;
        public String course;
        public String potok;
        public String group;

        public string FirstName
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(FirstName);
            }
        }
        public string LastName {
            get { return lastName; }
            set {
                lastName = value;
                OnPropertyChanged(LastName);
            }
        }

        public string FamilyName
        {
            get { return familyName; }
            set
            {
                familyName = value;
                OnPropertyChanged(FamilyName);
            }
        }
        public string Faculty
        {
            get { return faculty; }
            set
            {
                faculty = value;
                OnPropertyChanged(Faculty);
            }
        }
        public string Specialty
        {
            get { return specialty; }
            set
            {
                specialty = value;
                OnPropertyChanged(Specialty);
            }
        }

        public string Level
        {
            get { return level; }
            set
            {
                level = value;
                OnPropertyChanged(Level);
            }
        }

        public string Status
        {
            get { return status; }
            set
            {
                status = value;
                OnPropertyChanged(Status);
            }
        }

        public string FakNo
        {
            get { return fakNo; }
            set
            {
                fakNo = value;
                OnPropertyChanged(FakNo);
            }
        }
        public string Course
        {
            get { return course; }
            set
            {
                course = value;
                OnPropertyChanged(Course);
            }
        }

        public string Potok
        {
            get { return potok; }
            set
            {
                potok = value;
                OnPropertyChanged(Potok);
            }
        }
        public string Group
        {
            get { return group; }
            set
            {
                group = value;
                OnPropertyChanged(Group);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public Student(String name, String lastName, String familyName, String faculty, String specialty, String level, String status, String fakNo, String course, String potok, String group)
        {
            FirstName = name;
            LastName = lastName;
            FamilyName = familyName;
            Faculty = faculty;
            Specialty = specialty;
            Level = level;
            Status = status;
            FakNo = fakNo;
            Course = course;
            Potok = potok;
            Group = group;
        }
        public Student() { }

        private void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

