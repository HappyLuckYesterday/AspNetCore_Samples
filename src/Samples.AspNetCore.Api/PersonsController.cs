using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Samples.AspNetCore.Domain.Entities;
using Samples.AspNetCore.Domain.Services;

namespace Samples.AspNetCore.Api
{
    [Route("api/[controller]")]
    public class PersonsController : Controller
    {
        private readonly IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _personService.GetPersons();
        }
    }
}
