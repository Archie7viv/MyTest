using System;
using System.IO;

namespace N_Ix_study_1.RegularExpressionsTask
{
    public class FileActions
    {
        string path = @"c:\Automation\MyTest.txt";

        public void CreateWriteFile(string text)
        {
            using (StreamWriter myWriter = new StreamWriter(path))
            {
                myWriter.WriteLine(text, Environment.NewLine);
            }
        }
        public string ReadFromFIle()
        {
            return File.ReadAllText(path).Replace("\r\n", string.Empty);
        }

        public void DeleteFile()
        {
            File.Delete(path);
        }
    }
}
