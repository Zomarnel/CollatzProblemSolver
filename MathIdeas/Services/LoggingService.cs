using System;
using System.IO;
using System.Collections.Generic;

namespace MathIdeas.Services
{
    public static class LoggingService
    {
        private const string LOG_FILE_DIRECTORY = "Logs";
        static LoggingService()
        {
            string logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, LOG_FILE_DIRECTORY);

            if(!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }
        }
        public static void Log(List<int> logNumbers)
        {
            using(StreamWriter sw = new StreamWriter(LogFileName(), true))
            {
                foreach(int num in logNumbers)
                {
                    sw.Write($"{num} {(num > 1 ? ", " : "")}");
                }

                sw.WriteLine();
            }
        }
        private static string LogFileName()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, LOG_FILE_DIRECTORY,
                                $"C'est une perte de temps Kinji.log");
        }
    }
}
