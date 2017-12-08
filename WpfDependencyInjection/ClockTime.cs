using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDependencyInjection
{
    public class ClockTime : IClockDigital
    {
        public String Get()
        {
            DateTime time = DateTime.Now;
            return String.Format("{0:HH:mm:ss}", DateTime.Now);
        }
    }
}
