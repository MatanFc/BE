using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Child
    {
        public int childID { get; set; }
        public int momsID { get; set; }
        public string childFName { get; set; }
        public string childLName { get; set; }
        public bool isSpacial { get; set; }
        public string spacialNeeds { get; set; }
        // my prop
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
