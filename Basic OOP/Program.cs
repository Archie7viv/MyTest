using Basic_OOP.BasicOOP;
using Basic_OOP.BasicOOP.MyDriver;
using N_Ix_study_1.BasicOOP;
using System;

namespace Basic_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime bDay = new DateTime(2000, 1, 29);
            DateTime bDay2 = new DateTime(1980, 2, 25);

            Person person = new Person("Andy", bDay);
            Person person2 = new Person("John", bDay2, 194, 100, true);
            Person.DescribePerson(person);
            Person.DescribePerson(person2);
            ExtendedPerson emptyPerson = new ExtendedPerson();
            
            Person.DescribePerson(emptyPerson);

            //Get person age
            Person.GetAge(person);
            Person.GetAge(person2);
        }
    }
}
