using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    class StudentValidation
    {
        public static Student GetStudentDataByUser(User user)
        {
            List<Student> students = StudentData.TestStudents();
            return students.Find(s => s.name.Equals(user.username) && s.fakNo.Equals(user.fakNo));
        }
    }
}
