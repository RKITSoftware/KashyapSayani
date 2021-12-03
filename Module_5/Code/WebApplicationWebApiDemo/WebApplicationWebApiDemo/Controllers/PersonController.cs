using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationWebApiDemo.Models;

namespace WebApplicationWebApiDemo.Controllers
{
    /// <summary>
    /// This is where I give you all the information about my peoples.
    /// </summary>
    public class PersonController : ApiController
    {

        List<Person> persons = new List<Person>();

        
        public PersonController()
        {
            persons.Add(new Person { FirstName = "Kashyap" , LastNAme = "Sayani" , id = 1 });
            persons.Add(new Person { FirstName = "Manas", LastNAme = "PArmar", id = 2 });
            persons.Add(new Person { FirstName = "Ritik", LastNAme = "Mehta", id = 3 });
        }


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
            List<string> output = new List<string>();

            foreach(var p in persons)
            {
                output.Add(p.FirstName);
            }

            return output;
        }

        // GET api/<controller>
        public List<Person> Get()
        {
            return persons;
        }

        // GET api/<controller>/5
        public Person Get(int id)
        {
            return persons.Where(x => x.id == id).FirstOrDefault();
        }

        // POST api/<controller>
        public void Post(Person value)
        {
            persons.Add(value);
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