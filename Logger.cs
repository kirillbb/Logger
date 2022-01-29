using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public partial class Logger
    {
        private static Logger instance = new Logger();
        private static List<string> logList = new List<string>();

        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }

                return instance;
            }
        }

        public void WriteLog(object type, string logMesage)
        {
            string logType = FormatLogType((LogType)type);

            string logString = $"{DateTime.Now} : {logType} : {logMesage}";
            Console.WriteLine(logString);
            AddToLogList(logString);
        }

        public static void AddToLogList(string logString)
        {
            logList.Add(logString);
        }

        public static List<string> GetLogList()
        {
            return logList;
        }

        private static string FormatLogType(LogType type)
        {
            switch (type.ToString())
            {
                case "Error":
                    return type.ToString() + "  ";
                case "Info":
                    return type.ToString() + "   ";
                case "Warning":
                    return type.ToString();
            }

            return null;
        }
    }
}
