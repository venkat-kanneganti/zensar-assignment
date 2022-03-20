using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAssignment.Models;

namespace WebApiAssignment.Controllers
{
    [RoutePrefix("api/Country")]
    public class CountryController : ApiController
    {
        CountryContext cc = new CountryContext();

        [HttpPost]
        public IHttpActionResult Add([FromBody] Country countries)
        {
            cc.country.Add(countries);
            int count = cc.SaveChanges();
            if (count > 0)
            {
                return Ok(countries);
            }
            return BadRequest("Data not found");
        }

        [HttpGet]
        [Route("listofcountries")]
        public IHttpActionResult GetAll()
        {
            var res = cc.country.ToList();
            if (res.Count == 0)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [HttpGet]
        [Route("countrydetails")]
        public IHttpActionResult Getbyid(int id)
        {
            var res = cc.country.Find(id);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [HttpPut]

        public IHttpActionResult Edit([FromBody] Country countries)
        {
            if (countries.Id <= 0)
            {
                return NotFound();
            }
            cc.Entry(countries).State = System.Data.Entity.EntityState.Modified;
            int Count = cc.SaveChanges();
            if (Count > 0)
            {
                return Ok(countries);
            }
            return BadRequest("Modification Failed...");
        }

        [HttpDelete]
        public IHttpActionResult Delete([FromBody] Country countries)
        {
            if (countries.Id <= 0)
            {
                return NotFound();
            }
            cc.Entry(countries).State = System.Data.Entity.EntityState.Deleted;
            int Count = cc.SaveChanges();
            if (Count > 0)
            {
                return Ok(countries);
            }
            return BadRequest("Deletion Failed...");

        }
    }
}
