using System;
using System.IO;

namespace Constants
{
    public static class Logger
    {
        private static readonly string BASEPATH = @"D:\Test_Logs\";

        public static void LogInfo(string message)
        {
            try
            {
                // Ensure the logs directory exists
                if (!Directory.Exists(BASEPATH))
                {
                    Directory.CreateDirectory(BASEPATH);
                }

                string LOGS_FILEPATH = Path.Combine(BASEPATH, $"LOG_{DateTime.Now:yyyyMMdd}.txt");
                string logMessage = $"----------{DateTime.Now:yyyy-MM-dd HH:mm:ss}:" + Environment.NewLine+ 
                                    "---------------"+message;

                File.AppendAllText(LOGS_FILEPATH, logMessage + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error logging message: " + ex.Message);
            }
        }
    }
}
