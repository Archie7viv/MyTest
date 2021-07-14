using Infrastructure;
using System;

namespace N_Ix_study_1.Common
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
