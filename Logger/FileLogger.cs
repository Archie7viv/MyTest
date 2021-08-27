using System;
using System.IO;
using System.Text;

namespace MyLogger
{
    public class FileLogger : ILogger
    {
        private readonly object fileLock = new object();
        private readonly string datetimeFormat;
        private string logFilename, filePath;
        string pathPrefix = "../../";

        public FileLogger(string logFilename)
        {
            datetimeFormat = "yyyy-MM-dd HH:mm:ss.fff";
            this.logFilename = $"{logFilename}.log";

            // Log file header line
            string logHeader = logFilename + " is created.";
            filePath = pathPrefix + this.logFilename;
            if (!File.Exists(filePath))
            {
                WriteLogToFile(DateTime.Now.ToString(datetimeFormat) + " " + logHeader);
            }
        }

        public void Error(string text)
        {
            WriteFormattedLog(LogLevel.ERROR, text);
        }

        public void Info(string text)
        {
            WriteFormattedLog(LogLevel.INFO, text);
        }

        public void Warning(string text)
        {
            WriteFormattedLog(LogLevel.WARNING, text);
        }

        private void WriteLogToFile(string text, bool append = false)
        {
            try
            {
                if (string.IsNullOrEmpty(text))
                {
                    return;
                }
                lock (fileLock)
                {
                    using (StreamWriter writer = new StreamWriter(filePath, append, Encoding.UTF8))
                    {
                        writer.WriteLine(text);
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void WriteFormattedLog(LogLevel level, string text)
        {
            string pretext;
            switch (level)
            {
                case LogLevel.INFO:
                    pretext = DateTime.Now.ToString(datetimeFormat) + " [INFO]    ";
                    break;
                case LogLevel.WARNING:
                    pretext = DateTime.Now.ToString(datetimeFormat) + " [WARNING] ";
                    break;
                case LogLevel.ERROR:
                    pretext = DateTime.Now.ToString(datetimeFormat) + " [ERROR]   ";
                    break;
                default:
                    pretext = "";
                    break;
            }

            WriteLogToFile(pretext + text, true);
        }

        [Flags]
        private enum LogLevel
        {
            INFO,
            WARNING,
            ERROR
        }
    }
}
