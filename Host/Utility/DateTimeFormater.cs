using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreDockerExample.Interface;

namespace DotNetCoreDockerExample.Utility
{
    public class DateTimeFormater : IDateTimeFormater
    {
        public string Format(DateTime time)
        {
            return time.ToString("yyyy/MM/dd hh:mm:ss");
        }
    }
}
