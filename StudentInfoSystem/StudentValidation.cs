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
            String fakNo = user.fakNo;
            if (fakNo == null)
            {
                Console.WriteLine("Не е посочен факултетен номер.");
                return null;
            }
            return new Student();
        }
    }
}
