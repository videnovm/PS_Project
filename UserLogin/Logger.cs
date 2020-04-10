using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserLogin
{
    public class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();

        static public void LogActivity(string activity)
        {
            DateTime userLogDate = DateTime.Now;
            string activityLine = userLogDate + "; " + LoginValidation.currentUserUsername + "; " + LoginValidation.currentUserRole + "; " + activity + " ";
            currentSessionActivities.Add(activityLine);

            if (File.Exists("logfile") == true)
            {
                File.AppendAllText("logfile", activityLine + Environment.NewLine);
            }
        }

        static public void GetCurrentSessionActivities()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string line in currentSessionActivities)
            {
                sb.Append(line).Append(Environment.NewLine);
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
