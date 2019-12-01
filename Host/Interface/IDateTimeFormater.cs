using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreDockerExample.Interface
{
    public interface IDateTimeFormater
    {
        string Format(DateTime time);
    }
}
