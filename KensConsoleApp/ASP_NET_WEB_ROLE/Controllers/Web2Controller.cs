using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP_NET_WEB_ROLE.Controllers
{
    public class Web2Controller : ApiController
    {
        // GET: api/Web2
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Web2/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Web2
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Web2/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Web2/5
        public void Delete(int id)
        {
        }
    }
}
