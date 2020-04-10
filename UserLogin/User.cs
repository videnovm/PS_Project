using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public String username { get; set; }
        public String password { get; set; }
        public String fakNo { get; set; }
        public int role { get; set; }
        public DateTime created;
        public DateTime activeUntil;

        public User()
        {
        }

        public User(String username, String password, String fakNo, int role, DateTime created, DateTime activeUntil)
        {
            this.username = username;
            this.password = password;
            this.fakNo = fakNo;
            this.role = role;
            this.created = created;
            this.activeUntil = activeUntil;
        }

        public override string ToString()
        {
            return "\nПотребителско име: " + this.username + "; " +
                "\nПарола: " + this.password + "; " +
                "\nФакултетен номер: " + this.fakNo + "; " +
                "\nРоля: " + this.role + "; " +
                "\nДата на регистриране: " + this.created + "; " +
                "\nАктивен до: " + this.activeUntil + ";"; 
        }
    }
}
