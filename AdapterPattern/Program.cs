using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.Power.Power220;
using AdapterPattern.Power.Power120;
using AdapterPattern.Adapter;
namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Power220 power220 = new Power220();
            //220V电压
            power220.OutPutPower220();

            Console.WriteLine("转换电压中、、、");
            //转换电压
            IPower120 power120 = new PowerAdapter120(power220);
            power120.OutPutPower120();

            Console.WriteLine("Press any key to exit!");
            Console.ReadLine();
        }
    }
}
