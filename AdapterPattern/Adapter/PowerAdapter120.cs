using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.Power.Power120;
using AdapterPattern.Power;
namespace AdapterPattern.Adapter
{
    public class PowerAdapter120:IPower120
    {
        public  PowerBase Adapter;
        public PowerAdapter120(PowerBase power220)
        {
            this.Adapter = power220;
        }
        public void OutPutPower120() {
            if (Adapter.GetNum() == 220)
            {
                Adapter.SetNum(220/18.3f);

            }
            else
            {
                Console.WriteLine("--找不到适配器--");
                return;
            }
            Console.WriteLine("---" + Adapter.GetNum().ToString() + Adapter.GetUnit().ToString() + "电源----");

        }

    }
}
