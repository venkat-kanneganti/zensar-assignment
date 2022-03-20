using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAspAssignment2.Models;

namespace WebAspAssignment2.Controllers
{
    public class DefaultController : ApiController
    {
        ZensarDBEntities zdb = new ZensarDBEntities();
        public IHttpActionResult GetEmployeeSalById(int eid)
        {
            var details = zdb.getEmployeeSalary(eid).ToList();
            return Ok(details);
        }
    }
}
