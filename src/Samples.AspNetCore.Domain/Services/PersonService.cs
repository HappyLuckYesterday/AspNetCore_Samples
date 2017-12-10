using System.Collections.Generic;

namespace Samples.AspNetCore.Domain.Services
{
    public interface IPersonService
    {
        IEnumerable<Person> GetPersons();
    }

    public class PersonService : IPersonService
    {
        public PersonService()
        {
        }

        public IEnumerable<Person> GetPersons()
        {
            throw new System.NotImplementedException();
        }
    }
}
