using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiForData.Controllers
{
    public class ValuesController : ApiController
    {       
        /// <summary>
        /// GET api/values
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        /// <summary>
        ///  GET api/values/5 
        /// </summary>
        /// <param name="id"></param>
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        ///  POST api/values
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {
        }

        
    }
}
