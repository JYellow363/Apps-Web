using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTodo.Model;

namespace WebApiTodo.Service
{
    public interface PersonService
    {
        IEnumerable<Person> AllPersons();
        Person FindPerson(int id);
    }
}
