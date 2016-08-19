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
        public customer Get(int id)
        {
            foreach (customer cust in db.customer)
            {
                if (cust.cust_id == id) return cust;
            }
            return null;
        }
    }
}
