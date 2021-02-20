using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Ix_study_1.Basic
{
    public class Task2
    {
        bool bool1 = true;
        bool bool2 = true;
        bool bool3 = false;
        bool bool4 = false;

        int x = 10;
        int x1 = 20;
        int x2 = 30;
        int x3 = 40;
        bool comparisonResult, comparisonResult1, comparisonResult2, comparisonResult3, comparisonResult4, comparisonResult5;

        string str1 = "Hello World!";
        string str2 = "Hello World!111";

        public void CompareBoolAndPrint()
        {
            Console.WriteLine(AreEqual(bool1, bool2).ToString());
            Console.WriteLine(AreEqual(bool1, bool3).ToString());
            Console.WriteLine(AreEqual(bool1, bool4).ToString());
            Console.WriteLine(AreEqual(bool2, bool3).ToString());
            Console.WriteLine(AreEqual(bool2, bool4).ToString());
            Console.WriteLine(AreEqual(bool3, bool4).ToString());
        }

        public void CompareDifferentNumericValues()
        {
            comparisonResult = Compare1(x, x1);
            comparisonResult1 = Compare2(x, x2);
            comparisonResult2 = Compare3(x, x3);
            comparisonResult3 = Compare4(x1, x2);
            comparisonResult4 = Compare5(x1, x3);
            comparisonResult5 = Compare6(x2, x3);
        }

        public void LogicalANDandOR()
        {
            if(x < x1 && x1 < x2)
            {
                Console.WriteLine("'x' is the lowest value, logical AND in action");
            }

            if(x3 > x2 || x3 > x1)
            {
                Console.WriteLine("'x3' is not the lowest value, logical OR in action");
            }

        }

        //trinar operator
        public void DifferentStrings()
        {
            Console.WriteLine(str1 == str2 ? "Equal" : "Not equal");
        }

        public void DifferentBetweenAndOr()
        {
            if(x < x1 || x < x2 || x < x3)
            {
                Console.WriteLine("'x' is not the lowest");
            }
            //&, | - This will check conditions 2 and 3, even if 1 is already true.
            //&&, || - If condition1 is true, condition 2 and 3 will NOT be checked.
        }

        public bool AreEqual(bool x, bool y)
        {
            if(x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Compare1(int x, int y)
        {
            if (x < y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Compare2(int x, int y)
        {
            if (x <= y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Compare3(int x, int y)
        {
            if (x != y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Compare4(int x, int y)
        {
            if (x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Compare5(int x, int y)
        {
            if (x >= y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Compare6(int x, int y)
        {
            if (x > y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
