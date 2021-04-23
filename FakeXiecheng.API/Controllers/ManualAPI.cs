using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiecheng.API.Controllers
{
    [Route("api/manualapi")]
    //public class ManualAPI:ControllerBase
    //public class ManualAPIController
    //[Controller]
    //public class ManualAPI
    public class ManualAPIController: ControllerBase
    {
        // GET: api/<TestAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
