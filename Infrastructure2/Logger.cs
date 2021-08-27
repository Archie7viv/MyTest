using MyLogger;
using System;

namespace Infrastructure
{
    public static class Logger
    {
        private static ILogger instance;
        public static ILogger Get()
        {
            if (instance == null)
            {
                instance = new FileLogger("Test_execution" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"));
            }
            return instance;
        }
    }
}
