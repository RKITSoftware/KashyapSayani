using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationWebApiDemo.Models;

namespace WebApplicationWebApiDemo.Database
{
    public class PersonDB
    {
        public List<Person> persons = new List<Person>();

        public PersonDB()
        {
            persons.Add(new Person { FirstName = "Kashyap", LastNAme = "Sayani", id = 1 });
            persons.Add(new Person { FirstName = "Manas", LastNAme = "PArmar", id = 2 });
            persons.Add(new Person { FirstName = "Ritik", LastNAme = "Mehta", id = 3 });
        }

        public List<Person> getAllPerson()
        {
            return persons;
        }

        public List<string> getFirstName()
        {
            List<string> output = new List<string>();

            foreach (var p in persons)
            {
                output.Add(p.FirstName);
            }

            return output;

        }

        public Person getPersonById(int id)
        {
            return persons.ElementAt(id);
        }

        public void addPerson(Person person)
        {
            persons.Add(person);
        }
    }
}