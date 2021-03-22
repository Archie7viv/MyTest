using System;

namespace Basic_OOP.BasicOOP
{
    public class PolymorphysmBase
    {
        public string Type { get; set; }
        public int Legs { get; set; }
        public virtual void PrintType()
        {
            Console.WriteLine("Default number of legs = 2");
        }
    }
}
