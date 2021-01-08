using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Ix_study_1.Basic
{
    public class Task5 : Task4
    {
        Task4 task4 = new Task4();

        public void ListGet()
        {
            int x = myList[0];
        }

        public void ListAdd()
        {
            myList.Add(66);
        }

        public void ListRemove()
        {
            myList.Remove(1);
        }

        public void PrintNewList()
        {
            foreach (int i in myList)
            {
                Console.WriteLine(i.ToString());
            }
        }

    }
}
