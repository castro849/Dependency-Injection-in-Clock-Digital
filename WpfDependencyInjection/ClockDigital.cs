using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDependencyInjection
{
    public class ClockDigital
    {
        private StringBuilder result;
        private int index = 0;
        public ClockDigital()
        {
            result = new StringBuilder();
            Set(new ClockTime());
            Set(new ClockDate());
        }
        public void Set(IClockDigital icd)
        {
            result.AppendLine(icd.Get());
            if (index == 1)
            {
                result.AppendLine("\n");
            }
            index++;
        }
        public String GetResult()
        {
            return result.ToString();
        }
    }
}
