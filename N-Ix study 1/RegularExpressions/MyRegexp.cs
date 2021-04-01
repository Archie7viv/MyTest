using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace N_Ix_study_1.RegularExpressions
{
    public class MyRegexp
    {
        readonly string path = @"c:\Automation\MyTest.txt";
        Regex re;
        Match match;

        public string ExtractDigits(string text)
        {
            List<string> myList = new List<string>();
            Regex re = new Regex(@"[0-9]+");
            var matches = re.Matches(text);
            foreach(Match m in matches)
            {
                myList.Add(m.ToString());
            }
            return string.Join("", myList);
        }

        public string ExtractLetters(string text)
        {
            List<string> myList = new List<string>();
            Regex re = new Regex(@"[a-z]+");
            var matches = re.Matches(text);
            foreach (Match m in matches)
            {
                myList.Add(m.ToString());
            }
            return string.Join("", myList);
        }

        public string ExtractTextAfterSymbol(string text, string symbol)
        {
            Regex re = new Regex(symbol + ".*$");
            Match match = re.Match(text);
            return match.Value;
        }

        public string ExtractIp(string text)
        {
            re = new Regex(@"\d\d?\d?\.\d\d?\d?\.\d\d?\d?\.\d\d?\d?");
            match = re.Match(text);
            return match.Value;
        }

        public void CreateWriteFile(string text)
        {
            using (StreamWriter myWriter = new StreamWriter(path))
            {
                myWriter.WriteLine(text, Environment.NewLine);
            }
        }

        public string ExtractIpFromFile()
        {
            string text = File.ReadAllText(path).Replace("\r\n", string.Empty);
            re = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            match = re.Match(text);
            return match.Value;
        }

        public void DeleteFile()
        {
            File.Delete(path);
        }
    }
}
