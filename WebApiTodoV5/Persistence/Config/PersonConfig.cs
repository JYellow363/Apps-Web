using GenFu;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTodo.Model;

namespace WebApiTodo.Persistence.Config
{
    public class PersonConfig
    {
        public PersonConfig(EntityTypeBuilder<Person> entityBuilder)
        {
            // seeding
            var i = 1;
            var personsToSeed = A.ListOf<Person>(26);
            personsToSeed.ForEach(x => x.Id = i++);
            entityBuilder.HasData(personsToSeed);

        }
    }
}
