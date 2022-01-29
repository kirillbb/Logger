using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public partial class Logger
    {
        private static Logger instance = new ();
        private static List<string> logList = new ();

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

        public static void WriteLog(object type, string logMesage)
        {
            string logType = FormatLogTypeText((LogType)type);

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

        private static string FormatLogTypeText(LogType type)
        {
            switch (type)
            {
                case LogType.Error:
                    return type.ToString() + "  ";
                case LogType.Info:
                    return type.ToString() + "   ";
                case LogType.Warning:
                    return type.ToString();
            }

            return null;
        }
    }
}
