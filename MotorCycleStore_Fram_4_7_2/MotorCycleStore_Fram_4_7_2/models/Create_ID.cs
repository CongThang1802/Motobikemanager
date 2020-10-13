using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorCycleStore_Fram_4_7_2.models
{
    public static class Create_ID
    {
        public static string Gennaral_ID(string id)
        {
            string name = id.Substring(0, 6);
            int value = int.Parse(id.Substring(6, 4));
            if (value >= 0 && value < 9)
            {
                return name + "000" + ++value;
            }
            else if (value >= 9 && value < 99)
            {
                return name + "00" + ++value;
            }
            else if (value >= 99 && value < 999)
            {
                return name + "0" + ++value;
            }
            else
            {
                return name + ++value;
            }
        }
    }
}
