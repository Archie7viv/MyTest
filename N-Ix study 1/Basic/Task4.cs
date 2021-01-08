using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Ix_study_1.Basic
{
    public class Task4
    {
        public List<int> myList = new List<int>() { 1, 2, 3, 4, 5 };

        Dictionary<int, string> myDictionary = new Dictionary<int, string>();

        (string, int, double) myTuple = ("Tom", 25, 81.23);

        public void MyList()
        {
            myList[1] = 0;
            Console.WriteLine("List: " + myList[2]);
        }

        public void MyDictionary()
        {
            myDictionary.Add(1, "One");
            myDictionary.Add(2, "Two");
            Console.WriteLine("Dictionary: " + myDictionary[1]);
        }

        public void MyTuple()
        {
            Console.WriteLine(myTuple.Item1);
            Console.WriteLine(myTuple.Item2);
            Console.WriteLine(myTuple.Item3);
        }
    }
}
