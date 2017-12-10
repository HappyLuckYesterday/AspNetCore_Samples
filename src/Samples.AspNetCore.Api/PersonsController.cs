using Microsoft.AspNetCore.Mvc;
using Samples.AspNetCore.Domain.Services;

namespace Samples.AspNetCore.Api
{
    public class PersonsController : Controller
    {
        private readonly IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }


    }
}
