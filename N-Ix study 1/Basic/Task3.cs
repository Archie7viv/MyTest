using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Ix_study_1.Basic
{
    public class Task3
    {
        int x, y, z;
        List<int> list = new List<int>() { 1, 2, 3, 10 };

        public void SimpleCycles()
        {
            for(x=1; x<2; x++)
            {
                Console.WriteLine("'For cycle'");
            }

            while(x < 3)
            {
                Console.WriteLine("'While' loop");
                x++;
            }

            foreach(int a in list)
            {
                Console.WriteLine("'Foreach' loop");
            }
        }

        public void TenTimesLoop()
        {
            for (y = 1; y <=10; y++)
            {
                Console.WriteLine(y);
            }

            z = 1;
            while (z <= 10)
            {
                Console.WriteLine(z);
                z++;
            }

            z = 1;
            do
            {
                Console.WriteLine(z);
                z++;
            } while(z <= 10);
        }
        
        public int RecursionWithExitCondition(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * RecursionWithExitCondition(x - 1);
            }
        }

        public void InfiniteLoop()
        {
            while (true)
            {
                // ...
            }
        }

        public int RecursionWithoutExitCondition(int x)
        {
            return RecursionWithoutExitCondition(x);
        }
    }
}
