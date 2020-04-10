using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;


namespace UserLogin
{
    public class LoginValidation
    {

        private String username;
        private String password;
        private String errorLog;
        private ActionOnError _actionOnError;
        static UserRoles _userRoles;
        static String _userUsername;
        static DateTime currentTime = DateTime.Now;

        public delegate void ActionOnError(String errorMes);

        public LoginValidation(String username, String password, ActionOnError _actionOnError)
        {
            this.username = username;
            this.password = password;
            this._actionOnError = _actionOnError;
        }

        public bool ValidateUserInput(ref User u)
        {

            Boolean emptyUserName;
            emptyUserName = username.Equals(String.Empty);
            if (emptyUserName == true)
            {
                errorLog = "Не е посочено потребителско име.";
                _actionOnError(errorLog);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }
            Boolean emptyPassword;
            emptyPassword = password.Equals(String.Empty);
            if (emptyPassword == true)
            {
                errorLog = "Не е посочена парола.";
                _actionOnError(errorLog);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            if (username.Length < 5)
            {
                errorLog = "Потребителското име трябва да съдържа поне 5 симбола.";
                _actionOnError(errorLog);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }
            if (password.Length < 5)
            {
                errorLog = "Паролата трябва да съдържа поне 5 симбола.";
                _actionOnError(errorLog);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            if ((u = UserData.IsUserPassCorrect(username, password)) != null)
            {
                _userUsername = (String)u.username;
                _userRoles = (UserRoles)u.role;
            }
            else
            {
                return false;
            }

            if (u == null)
            {
                errorLog = "Потребителя не съществува.";
                _actionOnError(errorLog);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }
           

            Logger.LogActivity(" Succes login on date: " + currentTime + ";");
            return true;
        }

        public static void CheckLogDate(User user)
        {
            StreamReader sr = new StreamReader("logfile");
            string[] lines = File.ReadAllLines("logfile");
            IEnumerable<string> revLines = lines.Reverse();

            List<DateTime> dateTimeList = new List<DateTime>();
            foreach (string line in revLines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }
                int ln = line.IndexOf(";");
                string dateString = line.Substring(0, ln);
                DateTime datesFromFile = DateTime.Parse(dateString);

                if (line.Contains(user.username))
                {
                    dateTimeList.Add(datesFromFile);
                }
            }
            DateTime lastDate = dateTimeList.ElementAt(1);

            DateTime lastLoginTime = lastDate;
            TimeSpan span = currentTime.Subtract(lastLoginTime);
            String yourString = string.Format("{0} дена, {1} часа, {2} минути, {3} секунди", span.Days, span.Hours, span.Minutes, span.Seconds);

            Console.WriteLine("\nДобре дошли, " + user.username + "." + "\nПоследен път сте се логнали преди " + yourString + "." + Environment.NewLine);
        }
       
        public static UserRoles currentUserRole
        { 
            get{
                return _userRoles;
            } 
            private set{
            }
        }
        public static String currentUserUsername
        {
            get
            {
                return _userUsername;
            }
            private set { 
            }
        }
    }
}
