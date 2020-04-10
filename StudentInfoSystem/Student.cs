using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

public enum Status
{
    ЗАВЕРИЛ,
    ПРЕКЪСНАЛ,
    СЕМЕСТРИАЛНО_ЗАВЪРШИЛ
}

namespace StudentInfoSystem
{
    class Student
    {
        public String name { get; set; }
        public String lastName { get; set; }
        public String familyName { get; set; }
        public String faculty { get; set; }
        public String speciality { get; set; }
        public String level { get; set; }
        public Status status { get; set; }
        public String fakNo { get; set; }
        public String course { get; set; }
        public String potok { get; set; }
        public String group { get; set; }

        public Student(String name, String lastName, String familyName, String faculty, String speciality, String level, Status status, String fakNo, String course, String potok, String group)
        {
            this.name = name;
            this.lastName = lastName;
            this.familyName = familyName;
            this.faculty = faculty;
            this.speciality = speciality;
            this.level = level;
            this.status = status;
            this.fakNo = fakNo;
            this.course = course;
            this.potok = potok;
            this.group = group;
        }
        public Student() { }
    }
}

