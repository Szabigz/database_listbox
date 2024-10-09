using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database_listbox
{
    public class kolbasz
    {
        public static List<kolbasz> kolbaszok = new List<kolbasz>();
        public int id { get; set; }
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }
    }
}