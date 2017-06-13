using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace myMVC.Controllers
{
    //[Produces("application/json")]
    //[Route("api/PerfAPI")]
    public class PerfAPIController : Controller
    {
        // GET: api/PerfAPI
        //[HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2", "value3" };
        }

        //// GET: api/PerfAPI/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        
        //// POST: api/PerfAPI
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}
        
        //// PUT: api/PerfAPI/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}
        
        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }

    //Release 3.0 : Feature 4 test comment
}
