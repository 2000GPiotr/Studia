using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Zadanie1.Models.API;

namespace Zadanie1.Controllers.API
{
    public class PersonController : ApiController
    {
        List<Person> people = new List<Person>()
        {
            new Person() {ID = 1, Name = "A"},
            new Person() {ID = 2, Name = "B"},
            new Person() {ID = 3, Name = "C"}
        };

        public IHttpActionResult Get()
        {
            return this.Ok(people);
        }

        public IHttpActionResult Post(Person person)
        {
            if (person == null) return this.BadRequest("no data");

            var p = new Person()
            {
                ID = person.ID,
                Name = person.Name
            };

            people.Add(p);

            return this.Ok(p);
        }

    }
}
