using Basic_OOP.BasicOOP;
using Basic_OOP.BasicOOP.Interface;
using N_Ix_study_1.BasicOOP;

namespace Basic_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("Andy", 25);
            //Person person2 = new Person("John", 39, 194, 100, true);
            //Person.DescribePerson(person);
            //Person.DescribePerson(person2);
            //ExtendedPerson emptyPerson = new ExtendedPerson();
            //Person.DescribePerson(emptyPerson);

            ////Get person age
            //Person.GetAge(person);
            //Person.GetAge(person2);

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
        }
    }
}
