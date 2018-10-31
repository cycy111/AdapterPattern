using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Power
{
    public abstract class PowerBase
    {
        public static string unit="V";
        private float Num;
        public PowerBase(float num)
        {
            this.Num = num;
        }
        public void SetUnit(string unitStr)
        {
            unit = unitStr;
        }
        public string GetUnit()
        {
            return unit;
        }

        public void SetNum(float num)
        {
            this.Num = num;
        }
        public float GetNum()
        {
            return this.Num;
        }
    }
}
