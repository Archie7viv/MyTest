using Basic_OOP.BasicOOP;
using Basic_OOP.BasicOOP.Interface;
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

            //Polymorphysm
            PolymorphysmBase polly = new Human();
            polly.PrintType();

            polly = new Cat();
            polly.PrintType();

            polly = new Spider();
            polly.PrintType();

            Jack jack = new Jack();
            John john = new John();

            jack.WriteName();
            john.WriteName();
            john.ShowAge();
        }
    }
}
