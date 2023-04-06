using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFosagroTask1.Model
{
    internal class ObjectLists
    {
        public static List<Object> ObjectList = new List<Object>() { };
        public static void YUDetail (Object O)
        {
            ObjectList.Add(O);
            DetailJS.Serialization(ObjectList, "List.json");
        }
    }
}
