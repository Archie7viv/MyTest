using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace N_Ix_study_1.RegularExpressionsTask
{
    public static class MyRegexp
    {
        static Regex re;
        static Match match;

        public static string ExtractDigits(string text)
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

        public static string ExtractLetters(string text)
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

        public static string ExtractTextAfterSymbol(string text, string symbol)
        {
            Regex re = new Regex(symbol + ".*$");
            Match match = re.Match(text);
            return match.Value;
        }

        public static string ExtractIp(string text)
        {
            re = new Regex(@"\d\d?\d?\.\d\d?\d?\.\d\d?\d?\.\d\d?\d?");
            match = re.Match(text);
            return match.Value;
        }
    }
}
