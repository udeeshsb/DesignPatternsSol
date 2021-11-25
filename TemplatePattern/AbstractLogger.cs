using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public abstract class AbstractLogger
    {
        public bool ConsoleLogging { get; set; }

        protected string SerializeMessage(object message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }

        protected abstract void OpenDataStoreOperation();

        protected abstract void LogMessage(string messageToLog);

        protected abstract void CloseDataStoreOpreation();

        protected virtual void LogToConsole(string messageToLog)
        {
            Console.WriteLine("Writing in Console : " + messageToLog);
        }

        public void Log(object message)
        {
            string messageToLog = SerializeMessage(message);
            OpenDataStoreOperation();
            LogMessage(messageToLog);
            CloseDataStoreOpreation();
            if (ConsoleLogging)
            {
                LogToConsole(messageToLog);
            }
        }
    }
}
