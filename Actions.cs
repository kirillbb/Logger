using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW1
{
    public static class Actions
    {
        public static Result InfoMethod()
        {
            Logger logger = Logger.Instance;
            logger.WriteLog(Logger.LogType.Info, $"Start method: \t\t\tInfoMethod ");

            return new Result(true);
        }

        public static Result WarningMethod()
        {
            Logger logger = Logger.Instance;
            logger.WriteLog(Logger.LogType.Warning, $"Skipped logic in method: \tWarningMethod");

            return new Result(true);
        }

        public static Result ErrorMethod()
        {
            string errorText = "I broke a logic..";

            Logger logger = Logger.Instance;
            logger.WriteLog(Logger.LogType.Error, $"Action failed by a reason: \t{errorText}");

            return new Result(false, errorText);
        }
    }
}
