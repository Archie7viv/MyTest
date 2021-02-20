using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace N_Ix_study_1.Basic
{
    public class Task7
    {
        readonly string path = @"c:\Automation\MyTest.txt";
        List<int> numbers = new List<int>();
        int result1, result2;


        public void CreateWriteFile()
        {
            using (StreamWriter myWriter = new StreamWriter(path))
            {
                myWriter.WriteLine("Some text {0}4 {0}3 {0}99", Environment.NewLine);
            }
            //using (StreamReader myReader = new StreamReader(path))
            //{
            //    Console.Write(myReader.ReadToEnd());
            //    Console.ReadLine();
            //}

            //File.Delete(path);
        }

        public void MathOperationsOnNumbersFromString()
        {
            numbers = GetNumbersFromString();
            result1 = SumNumbers(numbers);
            result2 = MultiplyNumbers(numbers);
        }

        private List<int> GetNumbersFromString()
        {
            string text = File.ReadAllText(path).Replace("\r\n", string.Empty);
            string[] values = text.Split();
            int valueInt, greaterValuesCount = 0;

            foreach (var value in values)
            {
                if (int.TryParse(value, out valueInt))
                {
                    numbers.Add(valueInt);
                    greaterValuesCount++;            
                }
            }
            return numbers;
        }

        private int SumNumbers(List<int> numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        private int MultiplyNumbers(List<int> numbers)
        {
            int mult = 1;
            foreach (int number in numbers)
            {
                mult *= number;
            }
            return mult;
        }
    }
}
