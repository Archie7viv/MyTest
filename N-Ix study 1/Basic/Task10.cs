using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace N_Ix_study_1.Basic
{
    public class Task10
    {
        private readonly string stringA = "First string";
        private readonly string stringB = " Second string";
        private string stringC = "   egweerw  ererferw  kuy  yu i ";
        private string priceMessage = "this item previous price $5.99, Sale price $1.99. ";

        public void PrintConcatenatedStrings()
        {
            Console.WriteLine(stringA + stringB);

            Console.WriteLine("Some another {0}", "text");

            //interpolation
            Console.WriteLine($"{stringA} and Third string");

            //string builder
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.AppendLine(i.ToString());
            }
            Console.WriteLine(sb.ToString());

            //string.Concat
            string[] words = { "some", "words", "for", "vizualization" };
            var unreadablePhrase = string.Concat(words);
            Console.WriteLine(unreadablePhrase);

            //string.Join
            var readablePhrase = string.Join(" ", words);
            Console.WriteLine(readablePhrase);

            //LINQ Enumerable.Aggregate
            string[] anotherWords = { "another", "words", "are", "here" };
            var phrase = anotherWords.Aggregate((partialPhrase, word) => $"{partialPhrase} {word}");
            Console.WriteLine(phrase);
        }

        public void TrimString()
        {
            char[] charsToTrim = { ' ' };
            Console.WriteLine(stringC.Length.ToString());
            Console.WriteLine(stringC.Trim(charsToTrim).Length.ToString());
        }

        public void PrintWordsInSeparateRow()
        {
            string[] words = stringC.Split(' ');
            foreach (var word in words)
            {
                System.Console.WriteLine(word);
            }
        }

        public void CleanEmptySpaces()
        {
            string[] words = stringC.Split(' ');
            var noSpaces = new List<string>();

            foreach (var item in words)
            {
                if (item != string.Empty)
                {
                    noSpaces.Add(item);
                }
            }
            noSpaces.ForEach(word => Console.WriteLine(word));
        }

        public void ToUppercase()
        {
            Console.WriteLine(stringC.ToUpper());
        }

        public void AllWToUppercase()
        {
            Console.WriteLine(stringC.Replace('w', 'W'));
        }

        public void FirstWToUppercase()
        {
            char[] chars = stringC.ToCharArray(0, stringC.Length);
            for(int i=0; i<chars.Length; i++)
            {
                if(chars[i] == 'w')
                {
                    chars[i] = char.Parse(chars[i].ToString().ToUpper());
                    Console.WriteLine(chars);
                    break;
                }
            }         
        }

        public void ParsePrice()
        {
            MatchCollection m = Regex.Matches(priceMessage, "\\$\\d+(\\.\\d+)?");
            foreach (var item in m)
            {
                Console.WriteLine(item);
            }
        }
    }
}
