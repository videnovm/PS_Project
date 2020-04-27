using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserLogin
{
    class Program
    {
        public static void printError(String message)
        {
            Console.WriteLine("!!! " + message + " !!!");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Въведете потребителското име:");
            String usernameInput = Console.ReadLine();
            Console.WriteLine("Въведете парола:");
            String passwordInput = Console.ReadLine();

            LoginValidation validation = new LoginValidation(usernameInput, passwordInput, printError);

            User user = new User();

            if (validation.ValidateUserInput(ref user))
            {
                Console.WriteLine(user.ToString());
                Console.WriteLine("Роля на потребителя: " + LoginValidation.currentUserRole);
                LoginValidation.CheckLogDate(user);

                switch (user.role)
                {
                    case 0:
                        Console.WriteLine("Потребителя е ANONYMOUS.\n");
                        break;
                    case 1:
                        Console.WriteLine("Потребителя е ADMINISTRATOR.\n");
                        break;
                    case 2:
                        Console.WriteLine("Потребителя е INSPECTOR.\n");
                        break;
                    case 3:
                        Console.WriteLine("Потребителя е PROFESSOR.\n");
                        break;
                    case 4:
                        Console.WriteLine("Потребителя е STUDENT.\n");
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
                if (user.role == 1)
                {
                    adminFunction();
                }
            }
        }

        public static void adminFunction()
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\nИзберете опция: ");
                Console.WriteLine("0: Изход");
                Console.WriteLine("1: Промяна на роля на потребителя");
                Console.WriteLine("2. Промяна на активност на потребителя");
                Console.WriteLine("3. Списък на потребителите");
                Console.WriteLine("4. Преглед на лог на активност");
                Console.WriteLine("5. Преглед на текуща активност");
                Console.WriteLine("Въведете вашия избор:");

                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Въведете потребителското име: ");
                        String username = Console.ReadLine();
                        Console.WriteLine("Новата роля: ");
                        Int32 role = Int32.Parse(Console.ReadLine());
                        UserData.AssignUserRole(username, role);
                        break;
                    case 2:
                        Console.WriteLine("Въведете потребителското име: ");
                        String name = Console.ReadLine();
                        Console.WriteLine("Новата дата на активност: ");
                        var date = DateTime.Now;

                        if (DateTime.TryParseExact(Console.ReadLine(), "yyyy-mm-dd", null, System.Globalization.DateTimeStyles.None, out date))
                        {
                            UserData.SetUserActiveTo(name, date);
                        }
                        break;
                    case 3:
                        foreach (User user1 in UserData.testUsers)
                        {
                            Console.WriteLine(user1.ToString());
                        }
                        break;
                    case 4:
                        StreamReader sr = new StreamReader("logfile");
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                        break;
                    case 5:
                        Logger.GetCurrentSessionActivities();
                        break;
                    case 0:
                        flag = false;
                        break;
                }
            }
        }
    }
}
