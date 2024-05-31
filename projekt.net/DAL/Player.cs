using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Player
    {
        public string name { get; set; }
        public string number { get; set; }
        public bool captain { get; set; }
        public string position { get; set; }
        public bool favourite { get; set; } = false;

        public string imagePath { get; set; } = ""; 
    }
}
