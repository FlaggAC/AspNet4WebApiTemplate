using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNet4WebApiTemplate.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values/Action1?id=5
        [HttpGet]
        public string Action1(int id)
        {
            return "value1";
        }

        // POST api/values/Action2
        [HttpPost]
        public void Action2([FromBody] string value)
        {
        }

        // PUT api/values/Action3
        [HttpPut]
        public void Action3([FromBody]int id, [FromBody] string value)
        {
        }

        [HttpGet]
        public string GetById(int id) => $"{id}";
    }
}
