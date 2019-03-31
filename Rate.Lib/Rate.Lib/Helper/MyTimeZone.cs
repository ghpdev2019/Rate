using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rate.Lib
{
    public static class MyTimeZone
    {
        public static DateTime Today
        {
            get
            {
                return TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Taipei Standard Time"));
            }
        }
    }

}
