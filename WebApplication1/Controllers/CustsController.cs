using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustsController : ApiController
    {
        private List<Cust> customers = new List<Cust>()
        {
            new Cust {id=1, name="Panos" },
            new Cust {id=2, name="John" }
        };

        // GET: api/Custs
        public IEnumerable<Cust> GetCusts()
        {
            return customers.ToList();
        }

        // GET: api/Custs/5
        public IHttpActionResult GetCust(int id)
        {
            foreach (Cust cust in customers)
            {
                if (cust == null)
                {
                    break;
                }
                if (cust.id == id)
                {
                    return Ok(cust);
                }
            }
            return NotFound();
        }
    }
}