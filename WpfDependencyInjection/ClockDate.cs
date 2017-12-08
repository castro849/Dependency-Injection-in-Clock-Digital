using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDependencyInjection
{
    public class ClockDate : IClockDigital
    {
        public String Get()
        {
            return String.Format("{0:dd-MM-yyyy}", DateTime.Now);
        }
    }
}
