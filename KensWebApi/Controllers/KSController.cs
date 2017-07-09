using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KensWebApi.Controllers
{
    public class KSController : ApiController
    {
        // GET: api/KS
        public string Get()
        {
            KensLibDll.MainUtilityObject ksMUO = new KensLibDll.MainUtilityObject();
            string s = ksMUO.GetLibraryInfo();
            return s;
        }

        // GET: api/KS/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/KS
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/KS/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/KS/5
        public void Delete(int id)
        {
        }
    }
}
