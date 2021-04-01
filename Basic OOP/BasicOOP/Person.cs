using System;

namespace N_Ix_study_1.BasicOOP
{
    //Basic OOP task
    public class Person
    {
        private string _name;
        private DateTime _bDate;
        private int _age;
        private double _heigh;
        private int _weight;
        protected bool _isClient;

        public int Age
        {
            get 
            {
                var today = DateTime.Today;
                var age = today.Year - _bDate.Year;
                return age;
            }
        }
        public string Name { get; set; }

        protected Person() { }

        public Person(string name, DateTime bDate, double heigh = 180, int weight = 80, bool isClient = false)
        {
            _name = name;
            _bDate = bDate;
            _heigh = heigh;
            _weight = weight;
            _isClient = isClient;
        }

        public override string ToString()
        {
            return $"Person Name: {_name} | Age: {Age} | Height: {_heigh} | Weight: {_weight} | Already subscribed: {_isClient}";
        }

        //Print text representation of an instance
        public static void DescribePerson(Person person)
        {
            Console.WriteLine(person.ToString());
        }

        public static void GetAge(Person person)
        {
            Console.WriteLine("Age = " + person.Age);
        }
    }
}
