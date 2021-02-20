using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Ix_study_1.BasicOOP
{
    public class BasicOop
    {
        public int age;
        public string name;
        public static int Age { get; set; }
        public string Name { get; set; }

        public BasicOop(string a, int x)
        {

        }
    }

    public class Program
    {
        BasicOop basic = new BasicOop("John", 55);
    }
}
