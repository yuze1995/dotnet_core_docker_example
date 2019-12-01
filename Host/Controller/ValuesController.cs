using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreDockerExample.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DotNetCoreDockerExample.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IDateTimeFormater dateTimeFormater;
        private readonly ILogger<ValuesController> logger;

        public ValuesController(IDateTimeFormater dateTimeFormater,
                                ILogger<ValuesController> logger)
        {
            this.dateTimeFormater = dateTimeFormater;
            this.logger = logger;
        }

        [HttpGet("now")]
        public object GetDateTimeNow()
        {
            var now = DateTime.Now;
            var formatedNow = this.dateTimeFormater.Format(now);
            this.logger.LogWarning($"Test Log | Log Time:{formatedNow}");
            return new { original = now, formated = formatedNow };
        }
    }
}