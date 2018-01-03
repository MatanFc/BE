using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Contract
    {
        public int contractID { get; set; }
        public int nannysID { get; set; }
        public int chldsID { get; set; }
        public bool isMeeted { get; set; }
        public bool hasDone { get; set; }
        public double perHour { get; set; }
        public double perMonth { get; set; }
        public string hourOrMonth { get; set; }
        public string beginDate { get; set; }
        public string endDate { get; set; }
        // my prop
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
