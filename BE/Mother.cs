using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Mother
    {
        public int momID { get; set; }
        public string momFName { get; set; }
        public string momLName { get; set; }
        public int momPNumber { get; set; }
        public string momAddress { get; set; }
        public string momLookup { get; set; }
        public bool[] momNeedNanny
        {
            get { return momNeedNanny; }
            set
            {
                int tmp = Console.Read();
                for (int i = 0; i < 6; i++)
                {
                    if (tmp == 1)
                        momNeedNanny[i] = true;
                    else momNeedNanny[i] = false;
                }
            }
        }
        public int[][] neededHours { get; set; }
        // my prop
        public string notes { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
