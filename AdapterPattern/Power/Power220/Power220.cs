using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.Power;

namespace AdapterPattern.Power.Power220
{
    public class Power220:PowerBase,IPower220
    {
        public Power220()
        : base(220) { }    

        public void OutPutPower220()
        {
            Console.WriteLine("---" + this.GetNum().ToString() + this.GetUnit().ToString() + "电源----");
        }
    }
}
