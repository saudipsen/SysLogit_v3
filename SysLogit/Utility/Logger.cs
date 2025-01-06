using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogit.Utility
{
    using System;
    using System.IO;

    public static class Logger
    {
        private static readonly string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs.txt");

        public static void LogError(string methodName, Exception ex)
        {
            File.AppendAllText(logFilePath, $"{DateTime.Now}: {methodName} - {ex.Message}{Environment.NewLine}");
        }
    }

}
