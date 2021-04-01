using N_Ix_study_1.Basic;

namespace N_Ix_study_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();
            task1.AssignDifferentValues();
            task1.DontAssignValues();
            task1.AssignSameValues();
            task1.SameValuesFloadDouble();
            task1.DivideByZero();
            task1.DivideByThree();
            task1.DivideByThreeAndRound();

            Task2 task2 = new Task2();
            task2.CompareBoolAndPrint(); //how to use 'case' here?
            task2.CompareDifferentNumericValues();
            task2.LogicalANDandOR();
            task2.DifferentStrings();

            Task3 task3 = new Task3();
            task3.SimpleCycles();
            task3.TenTimesLoop();
            int factorial = task3.RecursionWithExitCondition(3);
            //task3.InfiniteLoop();
            //task3.RecursionWithoutExitCondition(4);

            Task4 task4 = new Task4();
            task4.MyList();
            task4.MyDictionary();
            task4.MyTuple();

            Task5 task5 = new Task5();
            task5.ListGet();
            task5.ListAdd();
            task5.ListRemove();
            task5.PrintNewList();

            Task6 task6 = new Task6();
            task6.DivideByZero();

            Task7 task7 = new Task7();
            task7.CreateWriteFile();
            task7.MathOperationsOnNumbersFromString();

            Task8_Serialization2 task8 = new Task8_Serialization2();
            task8.Serialize();  //how to serialize a class, not an object? how to print serialized object?

            Task9 task9 = new Task9();
            task9.ParseToJson();

            Task10 task10 = new Task10();
            task10.PrintConcatenatedStrings();
            task10.TrimString();
            task10.PrintWordsInSeparateRow();
            task10.CleanEmptySpaces();
            task10.ToUppercase();
            task10.AllWToUppercase();
            task10.FirstWToUppercase();
            task10.ParsePrice();
        }
    }
}
