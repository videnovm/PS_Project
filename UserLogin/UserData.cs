using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static public class UserData
    {
        static private List<User> _testUsers;


        static private void ResetTestUserData()
        {
            _testUsers = new List<User>();
            _testUsers.Add(new User("Milosh", "asdfg", "123217004", 1, DateTime.Now, DateTime.MaxValue));
            _testUsers.Add(new User("Hristijan", "qwerty", "123217007", 4, DateTime.Now, DateTime.MaxValue));
            _testUsers.Add(new User("Stefan", "asdfg", "123217008", 4, DateTime.Now, DateTime.MaxValue));
        }
        static public User IsUserPassCorrect(String username, String password)
        {
            List<User> users = testUsers;

            foreach (User user in users)
            {
                if (user.username.Equals(username) && user.password.Equals(password))
                {
                    return user;
                }
            }
            return null;
        }

        static public void SetUserActiveTo(String name, DateTime dateTime)
        {
            List<User> users = testUsers;

            foreach (User user in users)
            {
                if (user.username.Equals(name))
                {
                    user.activeUntil = dateTime;
                    break;
                }
            }
            Logger.LogActivity("Activity changed to user: " + name + " Active until: " + dateTime);
        }

        static public void AssignUserRole(String name, Int32 role)
        {
            List<User> users = testUsers;
            foreach (User user in users)
            {
                if (user.username.Equals(name))
                {
                    user.role = role;
                    break;
                }
            }
            Logger.LogActivity("Role changed to: " + name + " New role: " + role);
        }

        static public List<User> testUsers
        {
            get
            {
                ResetTestUserData();
                return _testUsers;
            }
            private set
            {
            }
        }
    }
}
    