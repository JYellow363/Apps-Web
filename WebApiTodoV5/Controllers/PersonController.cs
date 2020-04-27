using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTodo.Model;
using WebApiTodo.Service;

namespace WebApiTodo.Controllers
{
    [Route("api/[controller]")]
    [ApiController()]
    public class PersonController : ControllerBase
    {
        private readonly PersonService _personService;

        public PersonController(PersonService personService)
        {
            _personService = personService;
        }
        // GET: api/Person
        [HttpGet]
        public IEnumerable<Person> GetPersons()
        {
            return _personService.AllPersons();
        }

        // GET: api/Person/5
        [HttpGet("{id}")]
        public ActionResult<Person> GetPerson(int id)
        {
            var todoItem = _personService.FindPerson(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }
    }
}
