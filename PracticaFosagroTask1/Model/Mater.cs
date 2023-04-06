using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFosagroTask1.Model
{
    internal class Mater
    {
        public static List <string>MaterListt= new List <string>()
        {
            "Iron","Gold","Stil" 
        };
        public static Dictionary<string, double> Materialls = new Dictionary<string, double>()
        {
            { "Iron" , 3.38 },
            { "Gold", 5.34 },
            { "Stil", 4.56 }
        };
    }
}
