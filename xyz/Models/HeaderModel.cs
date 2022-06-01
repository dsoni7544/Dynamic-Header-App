using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xyz.Models
{
    public class HeaderModel
    {
        public string name { get; set; }
        public string home { get; set; }
        public string privacy { get; set; }
        public List<color> colour { get; set; }
        public string Selectedcolor { get; set; }

        public string colorName { get; set; }
    }
    public class color
    {
        public string name { get; set; }
        public int Id { get; set; }
        
    }
}
