using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationWebApiDemo.Database;
using WebApplicationWebApiDemo.Models;

namespace WebApplicationWebApiDemo.Controllers
{
    /// <summary>
    /// This is where I give you all the information about my peoples.
    /// </summary>
    public class PersonController : ApiController
    {
        public PersonDB persons = new PersonDB();
        /// <summary>
        /// Gets a list of the first names of all usesrs.
        /// </summary>
        /// <param name="userId">The unique identifier for this person.</param>
        /// <param name="age">We want to know how old they are.</param>
        /// <returns>A list of first names.</returns>
        [Route("api/Person/GetFirstName/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstName()
        {
            return persons.getFirstName();
        }

        // GET api/<controller>
        public List<Person> Get()
        {
            return persons.getAllPerson();
        }

        // GET api/<controller>/5
        public Person Get(int id)
        {
            return persons.getPersonById(id);
        }

        // POST api/<controller>
        public void Post(Person value)
        {
            persons.addPerson(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}