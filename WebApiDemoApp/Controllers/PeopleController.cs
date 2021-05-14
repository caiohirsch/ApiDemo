using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemoApp.Models;

namespace WebApiDemoApp.Controllers
{
    /// <summary>
    /// This is where I give you all the information about people.
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { Id = 1, FirstName = "Tim", LastName = "Corey" });
            people.Add(new Person { Id = 2, FirstName = "Sue", LastName = "Storm" });
            people.Add(new Person { Id = 3, FirstName = "Bilbo", LastName = "Baggins" });
        }

        /// <summary>
        /// Gets a list of people.
        /// </summary>
        /// <returns>A list of people.</returns>
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person value)
        {
            people.Add(value);
        }
    }
}
