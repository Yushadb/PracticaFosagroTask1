using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFosagroTask1.Model
{
    internal class DetailJS
    {
        
        
            public static string JsonFileWay { get; set; }
            public static List<Object> Deserialization(string jsonFile)
            {
                var jsonString = File.ReadAllText(jsonFile);
                var deserializedEmployees = JsonConvert.DeserializeObject<List<Object>>(jsonString);
                return deserializedEmployees;
            }

            public static void Serialization(List<Object> employees, string jsonFile)
            {
                File.WriteAllText(jsonFile, JsonConvert.SerializeObject(employees));
            }

    }
}
