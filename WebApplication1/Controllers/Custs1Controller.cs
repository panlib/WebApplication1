using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class Custs1Controller : ApiController
    {
        public Clima1_DBEntities db = new Clima1_DBEntities();
        
        public List<customer> Get()
        {
            return db.customer.ToList();
        }
        public IHttpActionResult Get(int id)
        {
            IEnumerable<customer> subset = from g in db.customer.ToList() where g.cust_id == id orderby g.sir_name select g;
            if (subset != null)
                return Ok(subset);
            return NotFound();
        }
    }
}
