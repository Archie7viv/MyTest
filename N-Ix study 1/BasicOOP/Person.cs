using System;

namespace N_Ix_study_1.BasicOOP
{
    //Basic OOP task
    public class Person
    {
        private string _name;
        private int _age;
        private double _heigh;
        private int _weight;
        protected bool _isClient;

        public static int Age
        {
            get { return Age; }
            set
            {
                if (Age < 12) throw new ArgumentException("too young");
                else if(Age > 100) throw new ArgumentException("too old");
            }
        }
        public string Name { get; set; }

        public Person() { }

        public Person(string name, int bDate, double heigh = 180, int weight = 80, bool isClient = false)
        {
            _name = name;
            _age = bDate;
            _heigh = heigh;
            _weight = weight;
            _isClient = isClient;
        }

        public override string ToString()
        {
            return "Person Name: " + _name + " | Age: " + _age + " | Height: " + _heigh + " | Weight: " + _weight + " | Already subscribed: " + _isClient;
        }

        //Print text representation of an instance
        public static void DescribePerson(Person person)
        {
            Console.WriteLine(person.ToString());
        }
    }

    public class ExtendedPerson : Person
    {
        //Constructor with no parameters
        public ExtendedPerson() : base()
        {

        }
    }
}
