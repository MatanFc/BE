using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Nanny
    {
        public int nannyID { get; set; }
        public string nannyFName { get; set; }
        public string nannyLName { get; set; }
        public string nannyBDay { get; set; }
        public int nannyPNumber { get; set; }
        public string nannyAddress { get; set; }
        public bool isElivator { get; set; }
        public int nannyFloor { get; set; }
        public double nannyEXP { get; set; }
        public int nannyMaxKids { get; set; }
        public int nannyMinAge { get; set; }
        public int nannyMaxAge { get; set; }
        public bool isPerHour { get; set; }
        public double nannyPerHour { get; set; }
        public double nannyPerMonth { get; set; }
        public bool[] workDays
        {
            get { return workDays; }
            set
            {
                int tmp = Console.Read();   // 1 or 0
                for (int i = 0; i < 6; i++)
                {
                    if (tmp == 1)
                        workDays[i] = true;
                    else workDays[i] = false;
                }
            }
        }
        public DateTime[][] workHours { get; set; }
        public bool TMTVacation { get; set; }
        public string recomendations { get; set; }
        // my prop
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
