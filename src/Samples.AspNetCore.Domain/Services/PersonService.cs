using System.Collections.Generic;
using System.Linq;
using Samples.AspNetCore.Data.Contracts.Providers;
using Samples.AspNetCore.Domain.Entities;

namespace Samples.AspNetCore.Domain.Services
{
    public interface IPersonService
    {
        IEnumerable<Person> GetPersons();
    }

    public class PersonService : IPersonService
    {
        readonly IPersonProvider _personsProvider;

        public PersonService(IPersonProvider personsProvider)
        {
            _personsProvider = personsProvider;
        }

        public IEnumerable<Person> GetPersons()
        {
            return _personsProvider.GetPersons().Select(t => new Person(t.FirstName, t.LastName));
        }
    }
}
