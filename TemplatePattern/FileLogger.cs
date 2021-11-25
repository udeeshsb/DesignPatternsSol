using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class FileLogger : AbstractLogger
    {
        protected override void OpenDataStoreOperation()
        {
            Console.WriteLine("Opening File.");
        }

        protected override void LogMessage(string messageToLog)
        {
            Console.WriteLine("Appending Log message to file : " + messageToLog);
        }

        protected override void CloseDataStoreOpreation()
        {
            Console.WriteLine("Close File.");
        }
    }


    public class EmailLogger : AbstractLogger
    {
        protected override void OpenDataStoreOperation()
        {
            Console.WriteLine("Connecting to mail server and logging in");
        }

        protected override void LogMessage(string messageToLog)
        {
            Console.WriteLine("Sending Email with Log Message : " + messageToLog);
        }

        protected override void CloseDataStoreOpreation()
        {
            Console.WriteLine("Dispose Connection");
        }
    }

    public class DatabaseLogger : AbstractLogger
    {
        protected override void OpenDataStoreOperation()
        {
            Console.WriteLine("Connecting to Database.");
        }

        protected override void LogMessage(string messageToLog)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + messageToLog);
        }

        protected override void CloseDataStoreOpreation()
        {
            Console.WriteLine("Closing DB connection.");
        }
    }
}
