using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace N_Ix_study_1.Basic
{
    [Serializable]
    public class Task8_Serialization
    {
        public int ID;
        public string Name;
    }

    public class Task8_Serialization2
    {
        readonly string path = @"c:\Automation\MyTest_Serializaed.txt";

        public void Serialize()
        {
            Task8_Serialization obj = new Task8_Serialization();
            obj.ID = 1;
            obj.Name = "Jack";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            Task8_Serialization objnew = (Task8_Serialization)formatter.Deserialize(stream);

            Console.WriteLine("ID: " + objnew.ID);
            Console.WriteLine("Name: " + objnew.Name);

            Console.ReadKey();
        }        
    }
}
