using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTodo.Model;
using WebApiTodo.Persistence;

namespace WebApiTodo.Service.Impl
{
    public class PersonServiceImpl:PersonService
    {
        private readonly ApplicationDbContext _context;
        public PersonServiceImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> AllPersons()
        {
            return _context.Persons
                .OrderBy(x => x.DateOfBirth)
                .ToList();
        }

        public Person FindPerson(int id)
        {
            return _context.Persons
                .FirstOrDefault(x => x.Id == id);
        }
    }
}
