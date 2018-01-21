using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public class Log
    {
        private static readonly ILog Logger;
        private static ILog GetLogger(string logName)
        {
           ILog logs = LogManager.GetLogger(logName);
            return logs;
        }
     
       static Log()
       {
           //logger names are mentioned in <log4net> section of config file
           Logger = GetLogger("MyApplicationDebugLog");
       }
    
       
       public static void WriteDebugLog(string message)
       {
           Logger.DebugFormat(message);
       }
   
    }
}
