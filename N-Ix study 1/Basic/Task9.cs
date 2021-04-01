using Newtonsoft.Json.Linq;
using System;

namespace N_Ix_study_1.Basic
{
    public class Task9
    {
        private string a = "{ \"name\":\"John\", \"age\":30, \"car\":null }";

        public void ParseToJson()
        {
            JObject json = JObject.Parse(a);
            Console.WriteLine(json["name"]);
            Console.WriteLine(json["age"]);
        }
    }
}
